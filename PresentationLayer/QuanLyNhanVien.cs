using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class QuanLyNhanVien : Form
    {
        private NhanVienBL nhanVienBL;
        public QuanLyNhanVien()
        {
            InitializeComponent();
            nhanVienBL = new NhanVienBL();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanVienBL.GetNhanViens();
        }
    }
}
