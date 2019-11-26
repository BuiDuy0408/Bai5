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
        private void dgvKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMa.Text = dgvKhach.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvKhach.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbGT.Text = dgvKhach.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgay.Text = dgvKhach.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCMND.Text = dgvKhach.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch { }
        }
    }
}
