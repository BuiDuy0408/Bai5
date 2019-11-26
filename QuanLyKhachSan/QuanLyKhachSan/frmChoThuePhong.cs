using BangKhachSan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmChoThuePhong : Form
    {
        string MaHD = "";
        BUS_KhachThuePhong kh = new BUS_KhachThuePhong();
        BUS_ThuePhong ThuePhong = new BUS_ThuePhong();
        BUS_Phong phong = new BUS_Phong();
        BUS_DichVu dv = new BUS_DichVu();
        public frmChoThuePhong()
        {
            InitializeComponent();
        }
        public void HienThiListKhach()
        {
            dgvKhachThuePhong.DataSource = kh.HienThiKhach_2TC();
        }
        public void HienThiPhongTrong_DV()
        {
            dgvPhongTrong.DataSource = phong.HienThiPhongTrong();
            dgvDichVu.DataSource = dv.HienThiDV();
        }
        private void btnThemKhachMoi_Click(object sender, EventArgs e)
        {
            KhachThue frm = new KhachThue();
            frm.Show();

        }

        private void frmChoThuePhong_Load(object sender, EventArgs e)
        {
            HienThiListKhach();
            HienThiPhongTrong_DV();
        }
        private void dgvKhachThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnChonPhong_Click(object sender, EventArgs e)
        {

        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            ThuePhong.ThemDV(MaHD, txtMaPhong.Text, txtMaDV.Text);
            HienThiPhongTrong_DV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HienThiListKhach();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
