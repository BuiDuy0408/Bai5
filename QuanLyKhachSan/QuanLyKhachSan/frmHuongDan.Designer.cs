namespace QuanLyKhachSan
{
    partial class frmHuongDan
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
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Đăng nhập");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Màn hình chính");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Cho thuê phòng");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Đồ dùng của khách sạn");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Đồ dùng theo phòng");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Khách thuê");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Phòng");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Trả phòng");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Các chức năng", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Giới thiệu phần mềm", new System.Windows.Forms.TreeNode[] {
            treeNode29});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGioiThieu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode21.Name = "gtDangNhap";
            treeNode21.Text = "Đăng nhập";
            treeNode22.Name = "gtManHinhChinh";
            treeNode22.Text = "Màn hình chính";
            treeNode23.Name = "gtChoThuePhong";
            treeNode23.Text = "Cho thuê phòng";
            treeNode24.Name = "gtDoDungCuaKhachSan";
            treeNode24.Text = "Đồ dùng của khách sạn";
            treeNode25.Name = "gtDoDungTheoPhong";
            treeNode25.Text = "Đồ dùng theo phòng";
            treeNode26.Name = "gtKhachThue";
            treeNode26.Text = "Khách thuê";
            treeNode27.Name = "gtPhong";
            treeNode27.Text = "Phòng";
            treeNode28.Name = "gtTraPhong";
            treeNode28.Text = "Trả phòng";
            treeNode29.Name = "gtChucNang";
            treeNode29.Text = "Các chức năng";
            treeNode30.Name = "gtPhanMem";
            treeNode30.Text = "Giới thiệu phần mềm";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode30});
            this.treeView1.Size = new System.Drawing.Size(172, 284);
            this.treeView1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(172, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 220);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtGioiThieu
            // 
            this.txtGioiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGioiThieu.Location = new System.Drawing.Point(172, 220);
            this.txtGioiThieu.Multiline = true;
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.Size = new System.Drawing.Size(379, 64);
            this.txtGioiThieu.TabIndex = 5;
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 284);
            this.Controls.Add(this.txtGioiThieu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHuongDan";
            this.Text = "frmHuongDan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGioiThieu;
    }
}