using BusinessLayer;
using System;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class QuanLyTheLoaiSach : Form
    {
        public TheLoaiSachBL theLoaiSachBL;
        private string idTMP = null; // Biến tạm lưu ID

        public QuanLyTheLoaiSach()
        {
            InitializeComponent();
            theLoaiSachBL = new TheLoaiSachBL();
        }

        private void QuanLyTheLoaiSach_Load(object sender, EventArgs e)
        {
            dgvTheLoaiSach.DataSource = theLoaiSachBL.GetAllTheLoaiSach();
        }

        private void dgvTheLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTheLoaiSach.Rows[e.RowIndex];
                idTMP = row.Cells["ID"].Value?.ToString();
                tbTheLoai.Text = row.Cells["TenTheLoai"].Value?.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTheLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại.");
                return;
            }

            string newID = Guid.NewGuid().ToString(); // Tạo ID ngẫu nhiên (hoặc sinh theo cách khác nếu bạn muốn)
            TheLoaiSach theLoai = new TheLoaiSach(newID, tbTheLoai.Text.Trim());

            int result = theLoaiSachBL.AddTheLoai(theLoai);
            if (result > 0)
            {
                MessageBox.Show("Thêm thể loại thành công!");
                dgvTheLoaiSach.DataSource = theLoaiSachBL.GetAllTheLoaiSach();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (idTMP == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại để sửa.");
                return;
            }

            TheLoaiSach theLoai = new TheLoaiSach(idTMP, tbTheLoai.Text.Trim());

            int result = theLoaiSachBL.UpdateTheLoai(theLoai);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                dgvTheLoaiSach.DataSource = theLoaiSachBL.GetAllTheLoaiSach();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (idTMP == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại để xóa.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa thể loại này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int result = theLoaiSachBL.DeleteTheLoai(idTMP);
                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvTheLoaiSach.DataSource = theLoaiSachBL.GetAllTheLoaiSach();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            tbTheLoai.Clear();
            tbTimKiem.Clear();
            idTMP = null;
            dgvTheLoaiSach.DataSource = theLoaiSachBL.GetAllTheLoaiSach();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = tbTimKiem.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                dgvTheLoaiSach.DataSource = theLoaiSachBL.TimKiemTheoTen(keyword);
            }
            else
            {
                dgvTheLoaiSach.DataSource = theLoaiSachBL.GetAllTheLoaiSach();
            }
        }
    }
}
