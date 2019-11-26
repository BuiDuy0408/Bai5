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
    }
}
