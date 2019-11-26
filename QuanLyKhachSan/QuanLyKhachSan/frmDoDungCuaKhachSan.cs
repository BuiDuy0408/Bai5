using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BangKhachSan;

namespace QuanLyKhachSan
{
    public partial class frmDoDungCuaKhachSan : Form
    {
        public frmDoDungCuaKhachSan()
        {
            InitializeComponent();
        }

        private void TxtMaDD_TextChanged(object sender, EventArgs e)
        {

        }
        BUS_DoDung dd = new BUS_DoDung();
        public void HienThi()
        {
            dgvDoDung.DataSource = dd.HienThiDoDung2();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void GroupBoxText_Enter(object sender, EventArgs e)
        {

        }
    }
}
