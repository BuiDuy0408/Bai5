namespace QuanLyKhachSan
{
    partial class frmQuanLyKhachSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKhachSan));
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.BackgroundImage")));
            this.pictureBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(941, 529);
            this.pictureBoxBackground.TabIndex = 2;
            this.pictureBoxBackground.TabStop = false;
            // 
            // frmQuanLyKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 529);
            this.Controls.Add(this.pictureBoxBackground);
            this.Name = "frmQuanLyKhachSan";
            this.Text = "Quản Lý Khách Sạn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxBackground;
    }
}