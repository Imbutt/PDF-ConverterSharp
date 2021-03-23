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
        public int HighlightedImage { get; set; } = -1;

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

                    
                    int offset = 5;

                    RadioButton buttPic = new RadioButton();  // Add Image button object
                    buttPic.AutoSize = false;
                    buttPic.Appearance = Appearance.Button;

                    // Posizion and size the button
                    buttPic.Location = new Point(
                        (buttonImageTemplate.Width + offset) *
                        (ButtPicList.Count % 2) ,

                        (buttonImageTemplate.Height + offset) * 
                        Math.Abs(ButtPicList.Count / 2));
                    buttPic.Size = new Size(buttonImageTemplate.Width, buttonImageTemplate.Height);

                    // Add Image to the button
                    buttPic.BackgroundImage = Image.FromFile(filePath);
                    buttPic.BackgroundImageLayout = ImageLayout.Stretch;

                    //Events
                    buttPic.Click += new EventHandler(Image_Click);
                    this.panelPreview.Controls.Add(buttPic);

                    ButtPicList.Add(buttPic); // Add to list
                }
                else
                    MessageBox.Show("Image invalid or corrupted","ERROR");





            }


        }

        public void Image_Click(object sender,EventArgs e)
        {
            // Highlight image
            RadioButton buttPic = sender as RadioButton;
            HighlightedImage = ButtPicList.FindIndex(x => x == buttPic);
            foreach (Button button in ControlButtonsList)
            {
                button.Enabled = true;
            }
        }

        private static int[] GetAutoSizeParams(int iw,int ih, int pw, int ph)
        {
            // Resize image
            int w = Math.Min(iw, pw);
            int h = ih * w / iw;
            // Center image
            int x = (iw - w) / 2;
            int y = (ph - h) / 2;

            return new int[] { x, y, w, h };
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

                
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

        private void UpdatePdf()
        {
            if (TempFileNum == 0)
                TempFileNum = 1;
            else
                TempFileNum = 0;

            if (PDFReader != null)
            {
                this.Controls.Remove(PDFReader);
                PDFReader.Dispose();
            }

            PDFReader = new WebBrowser();
            PDFReader.Size = webBrowserTermplate.Size;
            PDFReader.Location = webBrowserTermplate.Location;
            this.Controls.Add(PDFReader);
            

            string tempPath = Path.GetTempPath() + $"PDFConverterTEMP{TempFileNum}.pdf";
            Document.Close();
            Document.Save(tempPath);

            PDFReader.Navigate(tempPath);

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogFile.ShowDialog() == DialogResult.OK)
            {
                Document.Save(saveFileDialogFile.FileName);
            }
        }

        private void buttonRemoveImage_Click(object sender, EventArgs e)
        {

        }

        private void buttonMoveImage_Click(object sender, EventArgs e)
        {

        }
    }
}
