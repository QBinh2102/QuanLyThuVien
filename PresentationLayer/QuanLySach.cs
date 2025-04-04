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

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];

                tbMaSach.Text = row.Cells["ID"].Value?.ToString();
                tbTenSach.Text = row.Cells["TenSach"].Value?.ToString();
                tbTacGia.Text = row.Cells["TacGia"].Value?.ToString();
                tbTheLoai.Text = row.Cells["tenTheLoai"].Value?.ToString();
                tbNamXB.Text = row.Cells["NamXuatBan"].Value?.ToString();
                tbSoLuongNhap.Text = row.Cells["SoLuong"].Value?.ToString();
                tbSoLuongConLai.Text = row.Cells["SoLuongConLai"].Value?.ToString();
                tbGiaBia.Text = row.Cells["GiaBia"].Value?.ToString();
            }
        }
    }
}
