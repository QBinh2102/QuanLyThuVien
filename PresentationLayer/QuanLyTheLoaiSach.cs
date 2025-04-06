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
    public partial class QuanLyTheLoaiSach : Form
    {
        public TheLoaiSachBL theLoaiSachBL;
        public QuanLyTheLoaiSach()
        {
            InitializeComponent();
            theLoaiSachBL = new TheLoaiSachBL();
        }

        private void QuanLyTheLoaiSach_Load(object sender, EventArgs e)
        {
            dgvTheLoaiSach.DataSource = theLoaiSachBL.GetAllTheLoaiSach();  
        }
    }
}
