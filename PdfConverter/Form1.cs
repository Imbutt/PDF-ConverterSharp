using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;



namespace PdfConverter
{
    public partial class Form1 : Form
    {

        private static PdfDocument Document { get; set; } = new PdfDocument();
        public static List<RadioButton> ButtPicList { get; set; } = new List<RadioButton>();
        public int HighlightedImageNum { get; set; } = -1;

        public string OutputFileName { get; set; } = String.Empty;
        public static WebBrowser PDFReader { get; set; }
        public int TempFileNum { get; set; } = 0;
        private static List<Button> ControlButtonsList { get; set; } 


        public Form1()
        {
            InitializeComponent();

            ControlButtonsList = new List<Button>()
            {
                buttonRemoveImage,
                buttonMoveImage
            };

            Document.Info.Title = "Created with PDFSharp";

            foreach (Button button in ControlButtonsList)
            {
                button.Enabled = false;
            }
            
        }

        private void CreateButton(Image img)
        {
            RadioButton rb = new RadioButton();
            rb.AutoSize = false;
            rb.Appearance = Appearance.Button;
            rb.Size = new Size(buttonImageTemplate.Width, buttonImageTemplate.Height);

            // Add Image to the button
            rb.BackgroundImage = img;
            rb.BackgroundImageLayout = ImageLayout.Stretch;

            //Events
            rb.Click += new EventHandler(Image_Click);

            ButtPicList.Add(rb);

        }

        private void UpdatePdf()
        {
            // Switch between two temp files to avoid reopening the same one and causing a crash
            if (TempFileNum == 0)
                TempFileNum = 1;
            else
                TempFileNum = 0;

            // Replace PDFReader with a new one
            if (PDFReader != null)
            {
                this.Controls.Remove(PDFReader);
                PDFReader.Dispose();
            }
            PDFReader = new WebBrowser();
            PDFReader.Size = webBrowserPDF.Size;
            PDFReader.Location = webBrowserPDF.Location;
            this.Controls.Add(PDFReader);

            // Navigate to the file
            string tempPath = Path.GetTempPath() + $"PDFConverterTEMP{TempFileNum}.pdf";
            
            if(Document.PageCount > 0)
            {
                Document.Save(tempPath);
                PDFReader.Navigate(tempPath);
                labelPDFReader.Visible = false;
            }
            else
            {
                PDFReader.Dispose();
                // Reset document
                Document.Dispose();
                Document = new PdfDocument();

                labelPDFReader.Visible = true;

            }
            Document.Close();


        }

        private void UpdateButtons()
        {
            int offset = 5;

            // Dispose of all active radio button instances
            var rbList = panelPreview.Controls.OfType<RadioButton>();
            foreach(RadioButton rb in rbList)
            {
                panelPreview.Controls.Remove(rb);
            }

            // Create new radio button
            for (int i = 0; i < ButtPicList.Count; i++)
            {
                RadioButton rb = ButtPicList[i];

                // Posizion and size the button
                rb.Location = new Point(
                    (buttonImageTemplate.Width + offset) * (i % 2),
                    (buttonImageTemplate.Height + offset) * Math.Abs(i / 2));

                this.panelPreview.Controls.Add(rb);
            }
        }

        private static int[] GetAutoSizeParams(int iw, int ih, int pw, int ph)
        {
            // Resize image
            int w = Math.Min(iw, pw);
            int h = ih * w / iw;
            // Center image
            int x = (iw - w) / 2;
            int y = (ph - h) / 2;

            return new int[] { x, y, w, h };
        }

        private bool IsImageValid(string filePath)
        {
            try
            {
                using (var bmp = new Bitmap(filePath))
                {
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {

            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                PdfPage page = Document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);    // Pdf Graphics class

                string filePath = openFileDialogImage.FileName;

                if (IsImageValid(filePath))
                {
                    XImage image = XImage.FromFile(filePath);    // Get image

                    int[] ps = GetAutoSizeParams(image.PixelWidth, image.PixelHeight,
                        (int)page.Width, (int)page.Height);
                    gfx.DrawImage(image, 0, ps[1], ps[2], ps[3]);   // Draw image to pdf page
                    UpdatePdf();


                    // Add button
                    CreateButton(Image.FromFile(filePath));
                    UpdateButtons();
                }
                else
                {
                    MessageBox.Show("Image invalid or corrupted", "ERROR");
                    Document.Pages.Remove(page);
                }
                   





            }


        }

        public void Image_Click(object sender,EventArgs e)
        {
            // Highlight image
            RadioButton buttPic = sender as RadioButton;
            HighlightedImageNum = ButtPicList.FindIndex(x => x == buttPic);
            foreach (Button button in ControlButtonsList)
            {
                button.Enabled = true;
            }
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {

                
        }



        

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Document != null && Document.PageCount > 0)
            {
                if (saveFileDialogFile.ShowDialog() == DialogResult.OK)
                {
                    Document.Save(saveFileDialogFile.FileName);
                }
            }
            else
                MessageBox.Show("Can't save document with no pages", "ERROR");

        }

        private void buttonRemoveImage_Click(object sender, EventArgs e)
        {
            if (HighlightedImageNum > -1)
            {
                // Delete image from PDF
                Document.Pages.Remove(Document.Pages[HighlightedImageNum]);

                // Delete radiobutton
                ButtPicList.RemoveAt(HighlightedImageNum);

                HighlightedImageNum = -1;

                UpdateButtons();
                UpdatePdf();
            }
            else
                MessageBox.Show("Select an image before deleting it", "ERROR");

        }

        private void buttonMoveImage_Click(object sender, EventArgs e)
        {

        }
    }
}
