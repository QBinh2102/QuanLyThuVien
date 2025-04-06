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
        private TheLoaiSachBL theLoaiSachBL;
        public QuanLySach()
        {
            InitializeComponent();
            sachBL = new SachBL();
            theLoaiSachBL = new TheLoaiSachBL();

        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            dgvSach.DataSource = sachBL.GetAllSach();
            
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

                LoadTheLoaiToComboBox();

                DataGridViewRow row = dgvSach.Rows[e.RowIndex];

                tbMaSach.Text = row.Cells["ID"].Value?.ToString();
                tbTenSach.Text = row.Cells["TenSach"].Value?.ToString();
                tbTacGia.Text = row.Cells["TacGia"].Value?.ToString();
                cbTheLoaiSach.Text = row.Cells["tenTheLoai"].Value?.ToString();
                tbNamXB.Text = row.Cells["NamXuatBan"].Value?.ToString();
                tbSoLuongNhap.Text = row.Cells["SoLuong"].Value?.ToString();
                tbSoLuongConLai.Text = row.Cells["SoLuongConLai"].Value?.ToString();
                tbGiaBia.Text = row.Cells["GiaBia"].Value?.ToString();
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
    }
}
