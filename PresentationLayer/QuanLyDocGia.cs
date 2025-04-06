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
            dgvDocGia.DataSource = docGiaBL.GetAllDocGia();
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvDocGia.Rows[e.RowIndex];

                tbMaDocGia.Text = row.Cells["ID"].Value?.ToString();
                tbHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                tbSDT.Text = row.Cells["SDT"].Value?.ToString();
                tbEmail.Text = row.Cells["Email"].Value?.ToString();
                

            }
        }
    }
}
