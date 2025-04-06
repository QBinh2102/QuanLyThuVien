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
                tbDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();

            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string hoTen = tbHoTen.Text.ToString();
            string email = tbEmail.Text.ToString();
            string sdt = tbSDT.Text.ToString();
            string diaChi = tbDiaChi.Text.ToString();
            DocGia docGia = new DocGia();
            docGia.hoTen = hoTen;
            docGia.email = email;
            docGia.soDienThoai = sdt;
            docGia.diaChi = diaChi;
            docGia.ngayTao = DateTime.Now;
            docGia.active = true;

            int result = docGiaBL.AddDocGia(docGia);
            if(result != 0)
            {
                MessageBox.Show("Thêm độc giả thành công!","Độc giả",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string id = tbMaDocGia.Text.ToString();
            string hoTen = tbHoTen.Text.ToString();
            string email = tbEmail.Text.ToString();
            string sdt = tbSDT.Text.ToString();
            string diaChi = tbDiaChi.Text.ToString();
            DocGia docGia = new DocGia();
            docGia.id = id;
            docGia.hoTen = hoTen;
            docGia.email = email;
            docGia.soDienThoai = sdt;
            docGia.diaChi = diaChi;
            docGia.active = true;

            int result = docGiaBL.UpdateDocGia(docGia);
            if (result != 0)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(docGia.hoTen +"-"+ docGia.email + "-" + docGia.soDienThoai + "-" + docGia.diaChi, "Độc giả", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
