using BangKhachSan;
using KetNoiDB;
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
    public partial class KhachThue : Form
    {
        public KhachThue()
        {
            InitializeComponent();
        }
        BUS_KhachThuePhong khach = new BUS_KhachThuePhong();
        int chon = 0;
        TimKiem tk = new TimKiem();

        public void Khoa()
        {
            txtHoTen.Enabled = txtCMND.Enabled = cbGT.Enabled = dtpNgay.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        public void Mo()
        {
            txtHoTen.Enabled = txtCMND.Enabled = cbGT.Enabled = dtpNgay.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        public void SetNull()
        {
            txtMa.Text = txtHoTen.Text = txtCMND.Text = cbGT.Text = txtTK.Text = cbTK.Text = "";
            dtpNgay.Text = DateTime.Now.ToString();
        }
    }
}
