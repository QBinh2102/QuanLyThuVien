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
        private string emailTMP;
        public QuanLyDocGia()
        {
            InitializeComponent();
            docGiaBL = new DocGiaBL();
            tbMaDocGia.ReadOnly = true;
        }

        private void LoadForm()
        {
            tbMaDocGia.Clear();
            tbHoTen.Clear();
            tbSDT.Clear();
            tbEmail.Clear();
            tbDiaChi.Clear();
            tbTimKiem.Clear();
            cbActive.Checked = false;
            dgvDocGia.DataSource = docGiaBL.GetAllDocGia();
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
                cbActive.Checked = Convert.ToBoolean(row.Cells["Active"].Value);
                emailTMP = tbEmail.Text;

            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            string hoTen = tbHoTen.Text.ToString();
            string email = tbEmail.Text.ToString();
            string sdt = tbSDT.Text.ToString();
            string diaChi = tbDiaChi.Text.ToString();

            if (docGiaBL.CheckEmail(email))
            {
                MessageBox.Show("Email này đã tồn tại, vui lòng nhập email khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DocGia docGia = new DocGia();
            docGia.id = id.ToString();
            docGia.hoTen = hoTen;
            docGia.email = email;
            docGia.soDienThoai = sdt;
            docGia.diaChi = diaChi;
            docGia.ngayTao = DateTime.Now;
            docGia.active = true;

            int result = docGiaBL.AddDocGia(docGia);
            if (result != 0)
            {
                MessageBox.Show("Thêm độc giả thành công!", "Độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDocGia.DataSource = docGiaBL.GetAllDocGia();
                LoadForm();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string id = tbMaDocGia.Text.ToString();
            string hoTen = tbHoTen.Text.ToString();
            string email = tbEmail.Text.ToString();
            string sdt = tbSDT.Text.ToString();
            string diaChi = tbDiaChi.Text.ToString();
            bool active = cbActive.Checked;


            // Khi sửa chưa kiểm check Email với người khác 

            if (!emailTMP.Equals(email)) 
            if (docGiaBL.CheckEmail(email))
            {
                MessageBox.Show("Email này đã tồn tại, vui lòng nhập email khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DocGia docGia = new DocGia();
            docGia.id = id;
            docGia.hoTen = hoTen;
            docGia.email = email;
            docGia.soDienThoai = sdt;
            docGia.diaChi = diaChi;
            docGia.active = active;


            int result = docGiaBL.UpdateDocGia(docGia);
            if (result != 0)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDocGia.DataSource = docGiaBL.GetAllDocGia();
                emailTMP = tbEmail.Text;

            }
            else
            {
                MessageBox.Show(docGia.hoTen + "-" + docGia.email + "-" + docGia.soDienThoai + "-" + docGia.diaChi, "Độc giả", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string id = tbMaDocGia.Text.ToString();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Vui lòng chọn độc giả để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int kq = docGiaBL.DeleteDocGia(id);
                if (kq != 0)
                {
                    MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDocGia.DataSource = docGiaBL.GetAllDocGia();
                    tbMaDocGia.Clear();
                    tbHoTen.Clear();
                    tbSDT.Clear();
                    tbEmail.Clear();
                    tbDiaChi.Clear();
                    cbActive.Checked = false;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = tbTimKiem.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                dgvDocGia.DataSource = docGiaBL.TimKiemTheoTen(keyword);
            }
            else
            {
                dgvDocGia.DataSource = docGiaBL.GetAllDocGia();
            }
        }
    }
}
