using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using BusinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class QuanLyDocGia : Form
    {

        private DocGiaBL docGiaBL;
        public QuanLyDocGia()
        {
            InitializeComponent();
            docGiaBL = new DocGiaBL();
        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            dgvDocGia.DataSource = docGiaBL.GetDocGias();
        }
    }
}
