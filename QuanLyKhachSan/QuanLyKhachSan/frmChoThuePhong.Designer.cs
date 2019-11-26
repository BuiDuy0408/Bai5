namespace QuanLyKhachSan
{
    partial class frmChoThuePhong
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
            this.btnThemKhachMoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvKhachThuePhong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachThuePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemKhachMoi
            // 
            this.btnThemKhachMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachMoi.Location = new System.Drawing.Point(40, 88);
            this.btnThemKhachMoi.Name = "btnThemKhachMoi";
            this.btnThemKhachMoi.Size = new System.Drawing.Size(132, 46);
            this.btnThemKhachMoi.TabIndex = 4;
            this.btnThemKhachMoi.Text = "Thêm Khách Mới";
            this.btnThemKhachMoi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvKhachThuePhong
            // 
            this.dgvKhachThuePhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvKhachThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvKhachThuePhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhachThuePhong.Location = new System.Drawing.Point(0, 140);
            this.dgvKhachThuePhong.Name = "dgvKhachThuePhong";
            this.dgvKhachThuePhong.Size = new System.Drawing.Size(778, 320);
            this.dgvKhachThuePhong.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã KH";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên Khách";
            this.Column2.Name = "Column2";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(40, 66);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(147, 22);
            this.txtMaKH.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Khách Thuê Phòng";
            // 
            // frmChoThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvKhachThuePhong);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemKhachMoi);
            this.Name = "frmChoThuePhong";
            this.Text = "frmChoThuePhong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachThuePhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemKhachMoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvKhachThuePhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
    }
}