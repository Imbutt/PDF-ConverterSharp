
namespace PdfConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.webBrowserTermplate = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogFile = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogFile = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonImageTemplate = new System.Windows.Forms.Button();
            this.buttonRemoveImage = new System.Windows.Forms.Button();
            this.buttonMoveImage = new System.Windows.Forms.Button();
            this.panelPreview.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(358, 441);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(75, 23);
            this.buttonAddImage.TabIndex = 0;
            this.buttonAddImage.Text = "Add Image";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // panelPreview
            // 
            this.panelPreview.AutoScroll = true;
            this.panelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreview.Controls.Add(this.buttonImageTemplate);
            this.panelPreview.Location = new System.Drawing.Point(358, 28);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(273, 407);
            this.panelPreview.TabIndex = 1;
            // 
            // webBrowserTermplate
            // 
            this.webBrowserTermplate.Location = new System.Drawing.Point(12, 28);
            this.webBrowserTermplate.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserTermplate.Name = "webBrowserTermplate";
            this.webBrowserTermplate.Size = new System.Drawing.Size(330, 433);
            this.webBrowserTermplate.TabIndex = 4;
            this.webBrowserTermplate.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(796, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonFile
            // 
            this.toolStripDropDownButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.toolStripDropDownButtonFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFile.Image")));
            this.toolStripDropDownButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFile.Name = "toolStripDropDownButtonFile";
            this.toolStripDropDownButtonFile.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButtonFile.Text = "File";
            this.toolStripDropDownButtonFile.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveFileDialogFile
            // 
            this.saveFileDialogFile.RestoreDirectory = true;
            // 
            // openFileDialogFile
            // 
            this.openFileDialogFile.FileName = "openFileDialogFile";
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialog1";
            this.openFileDialogImage.RestoreDirectory = true;
            // 
            // buttonImageTemplate
            // 
            this.buttonImageTemplate.Location = new System.Drawing.Point(3, 3);
            this.buttonImageTemplate.Name = "buttonImageTemplate";
            this.buttonImageTemplate.Size = new System.Drawing.Size(120, 120);
            this.buttonImageTemplate.TabIndex = 0;
            this.buttonImageTemplate.Text = "button1";
            this.buttonImageTemplate.UseVisualStyleBackColor = true;
            this.buttonImageTemplate.Visible = false;
            // 
            // buttonRemoveImage
            // 
            this.buttonRemoveImage.Location = new System.Drawing.Point(439, 441);
            this.buttonRemoveImage.Name = "buttonRemoveImage";
            this.buttonRemoveImage.Size = new System.Drawing.Size(93, 23);
            this.buttonRemoveImage.TabIndex = 6;
            this.buttonRemoveImage.Text = "Remove Image";
            this.buttonRemoveImage.UseVisualStyleBackColor = true;
            this.buttonRemoveImage.Click += new System.EventHandler(this.buttonRemoveImage_Click);
            // 
            // buttonMoveImage
            // 
            this.buttonMoveImage.Location = new System.Drawing.Point(538, 441);
            this.buttonMoveImage.Name = "buttonMoveImage";
            this.buttonMoveImage.Size = new System.Drawing.Size(93, 23);
            this.buttonMoveImage.TabIndex = 7;
            this.buttonMoveImage.Text = "Move Image";
            this.buttonMoveImage.UseVisualStyleBackColor = true;
            this.buttonMoveImage.Click += new System.EventHandler(this.buttonMoveImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 500);
            this.Controls.Add(this.buttonMoveImage);
            this.Controls.Add(this.buttonRemoveImage);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.webBrowserTermplate);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.buttonAddImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelPreview.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.WebBrowser webBrowserTermplate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonImageTemplate;
        private System.Windows.Forms.Button buttonRemoveImage;
        private System.Windows.Forms.Button buttonMoveImage;
    }
}

