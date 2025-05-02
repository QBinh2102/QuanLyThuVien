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
        private string idSachTMP;
        private TheLoaiSachBL theLoaiSachBL;
        public QuanLySach()
        {
            InitializeComponent();
            sachBL = new SachBL();
            theLoaiSachBL = new TheLoaiSachBL();

            this.tbSoLuongNhap.TextChanged += new System.EventHandler(this.tbSoLuongNhap_TextChanged);
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            dgvSach.DataSource = sachBL.GetAllSach();
            if (dgvSach.Columns.Contains("idTheLoai"))
            {
                dgvSach.Columns["idTheLoai"].Visible = false;
            }
            LoadTheLoaiToComboBox();
            rbTen.Checked = true;
        }

        private void LoadTheLoaiToComboBox()
        {
            var listTheLoai = theLoaiSachBL.GetAllTheLoaiSach(); 
            cbTheLoaiSach.DataSource = listTheLoai;          
            cbTheLoaiSach.DisplayMember = "TenTheLoai";       
            cbTheLoaiSach.ValueMember = "ID";
        }
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];

                tbMaSach.Text = row.Cells["ID"].Value?.ToString();
                tbTenSach.Text = row.Cells["TenSach"].Value?.ToString();
                tbTacGia.Text = row.Cells["TacGia"].Value?.ToString();
                cbTheLoaiSach.Text = row.Cells["tenTheLoai"].Value?.ToString();
                tbNamXB.Text = row.Cells["NamXuatBan"].Value?.ToString();
                tbSoLuongNhap.Text = row.Cells["SoLuong"].Value?.ToString();
                tbSoLuongConLai.Text = row.Cells["SoLuongConLai"].Value?.ToString();
                tbGiaBia.Text = row.Cells["GiaBia"].Value?.ToString();

                idSachTMP = row.Cells["idTheLoai"].Value?.ToString();
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = tbTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm.");
                return;
            }

            List<Sach> ketQua = new List<Sach>();

            if (rbTen.Checked)
            {
                ketQua = sachBL.TimKiemTheoTen(keyword);
            }
            else if (rbTacGia.Checked)
            {
                ketQua = sachBL.TimKiemTheoTacGia(keyword);
            }
            //else if (rbTheoTheLoai.Checked)
            //{
            //    ketQua = sachBL.TimKiemTheoTheLoai(keyword);
            //}
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu tìm kiếm.");
                return;
            }

            dgvSach.DataSource = ketQua;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.tenSach = tbTenSach.Text.Trim();
            sach.tacGia = tbTacGia.Text.Trim();
            sach.namXuatBan = tbNamXB.Text.Trim();
            sach.soLuong = Convert.ToInt32(tbSoLuongNhap.Text);
            sach.soLuongConLai = Convert.ToInt32(tbSoLuongConLai.Text);
            sach.giaBia = Convert.ToDouble(tbGiaBia.Text);
            sach.idTheLoai = cbTheLoaiSach.SelectedValue.ToString();
            sach.tenTheLoai = cbTheLoaiSach.Text;
            if (sach.soLuongConLai > sach.soLuong)
            {
                MessageBox.Show("Số lượng còn lại không được lớn hơn số lượng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int result = sachBL.AddSach(sach);
            if (result != 0)
            {
                MessageBox.Show("Thêm sách thành công!", "Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSach.DataSource = sachBL.GetAllSach();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Console.WriteLine(cbTheLoaiSach.Text.ToString());
            if (cbTheLoaiSach.Text.ToString() == "")
            {
                MessageBox.Show("Cần cập nhật đủ thông tin", "Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Sach sach = new Sach();
                sach.id = tbMaSach.Text;
                sach.tenSach = tbTenSach.Text.Trim();
                sach.tacGia = tbTacGia.Text.Trim();
                sach.namXuatBan = tbNamXB.Text.Trim();
                sach.soLuong = Convert.ToInt32(tbSoLuongNhap.Text);
                sach.soLuongConLai = Convert.ToInt32(tbSoLuongConLai.Text);
                sach.giaBia = Convert.ToDouble(tbGiaBia.Text);
                sach.idTheLoai = cbTheLoaiSach.SelectedValue.ToString();
                sach.tenTheLoai = cbTheLoaiSach.Text;
                if (sach.soLuongConLai > sach.soLuong)
                {
                    MessageBox.Show("Số lượng còn lại không được lớn hơn số lượng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int result = sachBL.UpdateSach(sach);
                if (result != 0)
                {
                    MessageBox.Show("Cập nhật sách thành công!", "Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSach.DataSource = sachBL.GetAllSach();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string id = tbMaSach.Text;
                int result = sachBL.DeleteSach(id);

                if (result != 0)
                {
                    MessageBox.Show("Xóa sách thành công!", "Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSach.DataSource = sachBL.GetAllSach();
                }
                else
                {
                    MessageBox.Show("Xóa sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            tbMaSach.Clear();
            tbTenSach.Clear();
            tbTacGia.Clear();
            tbNamXB.Clear();
            tbSoLuongNhap.Clear();
            tbSoLuongConLai.Clear();
            tbGiaBia.Clear();
            tbTimKiem.Clear();

            if (cbTheLoaiSach.Items.Count > 0)
                cbTheLoaiSach.SelectedIndex = 0;

            idSachTMP = null;
            dgvSach.DataSource = sachBL.GetAllSach();
        }

        private void tbSoLuongNhap_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbSoLuongNhap.Text.Trim(), out int soLuong))
            {
                tbSoLuongConLai.Text = soLuong.ToString();
            }
        }
    }
}
