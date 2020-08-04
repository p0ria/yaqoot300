namespace Yaqoot300
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelPage = new System.Windows.Forms.Panel();
            this.imageList32 = new System.Windows.Forms.ImageList(this.components);
            this.imageList64 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // panelPage
            // 
            this.panelPage.Location = new System.Drawing.Point(-6, -1);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(1280, 990);
            this.panelPage.TabIndex = 0;
            // 
            // imageList32
            // 
            this.imageList32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList32.ImageStream")));
            this.imageList32.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList32.Images.SetKeyName(0, "tick_32x32.png");
            this.imageList32.Images.SetKeyName(1, "cross_32x32.png");
            this.imageList32.Images.SetKeyName(2, "sync_blue_32x32.png");
            // 
            // imageList64
            // 
            this.imageList64.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList64.ImageStream")));
            this.imageList64.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList64.Images.SetKeyName(0, "error_64x64.png");
            this.imageList64.Images.SetKeyName(1, "gray_circle_64x64.png");
            this.imageList64.Images.SetKeyName(2, "red_circle_64x64.png");
            this.imageList64.Images.SetKeyName(3, "green_circle_64x64.png");
            this.imageList64.Images.SetKeyName(4, "yellow_circle_64x64.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.panelPage);
            this.Name = "MainForm";
            this.Text = "Yaqoot 300";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPage;
        private System.Windows.Forms.ImageList imageList32;
        private System.Windows.Forms.ImageList imageList64;
    }
}

