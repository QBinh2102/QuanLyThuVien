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
using TransferObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PresentationLayer
{
    public partial class QuanLyNhanVien : Form
    {
        private NhanVienBL nhanVienBL;
        private string emailTMP;
        public QuanLyNhanVien()
        {
            InitializeComponent();
            nhanVienBL = new NhanVienBL();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanVienBL.GetAllNhanVien();
            if (dgvNhanVien.Columns["password"] != null)
            {
                dgvNhanVien.Columns["password"].Visible = false;
            }
            cbVaiTro.Items.Add("Nhân viên");  
            cbVaiTro.Items.Add("Quản trị");
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                tbMaNhanVien.Text = row.Cells["ID"].Value?.ToString();
                tbHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                tbSDT.Text = row.Cells["SDT"].Value?.ToString();
                tbEmail.Text = row.Cells["Email"].Value?.ToString();
                tbUsername.Text = row.Cells["username"].Value?.ToString();
                tbQueQuan.Text = row.Cells["queQuan"].Value?.ToString();
                cbActive.Checked = Convert.ToBoolean(row.Cells["Active"].Value);
                emailTMP = tbEmail.Text;
                int vaiTro = Convert.ToInt32(row.Cells["vaiTro"].Value);
                cbVaiTro.SelectedIndex = vaiTro;
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = tbTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                var ketQua = nhanVienBL.TimKiemTheoTen(keyword);
                dgvNhanVien.DataSource = ketQua;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm.");
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbMaNhanVien.Clear();
            tbHoTen.Clear();
            tbSDT.Clear();
            tbQueQuan.Clear();
            tbTimKiem.Clear();
            tbUsername.Clear();
            tbTimKiem.Clear();
            tbEmail.Clear();
            cbActive.Checked = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.hoTen = tbHoTen.Text;
            nv.soDienThoai = tbSDT.Text;
            nv.queQuan = tbQueQuan.Text;
            nv.username = tbUsername.Text;
            nv.email = tbEmail.Text;
            nv.ngayTao = DateTime.Now;
            nv.vaiTro = cbVaiTro.SelectedIndex;
            nv.active = true;
            nv.password = "Demo@123";

            if (nhanVienBL.CheckEmail(nv.email))
            {
                MessageBox.Show("Email này đã tồn tại, vui lòng nhập email khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = nhanVienBL.AddNhanVien(nv);
            if (result != 0)
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNhanVien.DataSource = nhanVienBL.GetAllNhanVien();

            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhanVien nv = new NhanVien();
            nv.id = tbMaNhanVien.Text;
            nv.hoTen = tbHoTen.Text;
            nv.soDienThoai = tbSDT.Text;
            nv.queQuan = tbQueQuan.Text;
            nv.username = tbUsername.Text;
            nv.email = tbEmail.Text;
            nv.active = cbActive.Checked;
            nv.vaiTro = cbVaiTro.SelectedIndex;

            if (!emailTMP.Equals(nv.email))
                if (nhanVienBL.CheckEmail(nv.email))
                {
                    MessageBox.Show("Email này đã tồn tại, vui lòng nhập email khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            int result = nhanVienBL.UpdateNhanVien(nv);
            if (result != 0)
            {
                MessageBox.Show("Cập nhật nhân viên thành công!", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNhanVien.DataSource = nhanVienBL.GetAllNhanVien();
                emailTMP = tbEmail.Text;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string id = tbMaNhanVien.Text;
                int result = nhanVienBL.DeleteNhanVien(id);
                if (result != 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNhanVien.DataSource = nhanVienBL.GetAllNhanVien();
                    btReset.PerformClick(); // Xóa nội dung form
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
