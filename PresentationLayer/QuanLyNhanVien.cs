﻿using BusinessLayer;
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

namespace PresentationLayer
{
    public partial class QuanLyNhanVien : Form
    {
        private NhanVienBL nhanVienBL;
        public QuanLyNhanVien()
        {
            InitializeComponent();
            nhanVienBL = new NhanVienBL();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanVienBL.GetAllNhanVien();
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
    }
}
