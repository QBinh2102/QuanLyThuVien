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
    public partial class QuanLySach : Form
    {
        private SachBL sachBL;
        public QuanLySach()
        {
            InitializeComponent();
            sachBL = new SachBL();
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            dgvSach.DataSource = sachBL.GetSachs();
        }
    }
}
