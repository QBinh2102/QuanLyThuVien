using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class QuanLyMuonTraSach : Form
    {
        private PhieuMuonBL phieuMuonBL;
        private QuyDinhBL quyDinhBL;
        private QuyDinh quyDinh;
        private string idPhieuMuonTMP ="";
        public NhanVien nhanVien { get; set;}
        public QuanLyMuonTraSach()
        {
            InitializeComponent();
            phieuMuonBL = new PhieuMuonBL();
            quyDinhBL = new QuyDinhBL();
            quyDinh = new QuyDinh();
        }

        private void btCheckDocGia_Click(object sender, EventArgs e)
        {
            string id = tbMaDG.Text.ToString();
            DocGia docGia = phieuMuonBL.GetThongTinDocGia(id);
            if(docGia != null)
            {
                tbHoTen.Text = docGia.hoTen;
                tbSoSachDaMuon.Text = docGia.soSachDangMuon;
            }
            else
            {
                tbHoTen.Clear();
                tbSoSachDaMuon.Clear();
                MessageBox.Show("Không tồn tại độc giả!", "Độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btCheckSach_Click(object sender, EventArgs e)
        {
            string id = tbMaSach.Text.ToString();
            List<string> arr = phieuMuonBL.GetThongTinSach(id);
            if(arr != null)
            {
                tbTenSach.Text = arr[0];
                tbSoLuongSach.Text = arr[1];
            }
            else
            {
                tbTenSach.Clear();
                tbSoLuongSach.Clear();
                MessageBox.Show("Không tồn tại sách!", "Độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void QuanLyMuonTraSach_Load(object sender, EventArgs e)
        {
            quyDinh = quyDinhBL.GetQuyDinh();
            DateTime ngayMuon = dtNgayMuon.Value;
            dtNgayTra.Value = ngayMuon.AddDays(quyDinh.SoNgay);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string maDocGia = tbMaDG.Text.ToString();
            string maSach = tbMaSach.Text.ToString();
            string hoTen = tbHoTen.Text.ToString();
            string tenSach = tbTenSach.Text.ToString();
            if (maDocGia.Equals("") || maSach.Equals("") || hoTen.Equals("") || tenSach.Equals(""))
            {
                MessageBox.Show("Cần kiểm tra thông tin độc giả hoặc sách", "Phiếu mượn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int soSachDangMuon = int.Parse(tbSoSachDaMuon.Text.ToString());
            int soSachHienCo = int.Parse(tbSoLuongSach.Text.ToString());
            if(soSachHienCo == 0)
            {
                MessageBox.Show("Sách đã hết, không thể mượn!", "Phiếu mượn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (soSachDangMuon < quyDinh.SoSach)
            {
                string idDocGia = tbMaDG.Text.ToString();
                string idSach = tbMaSach.Text.ToString();
                string idNhanVien = nhanVien.id;
                DateTime ngayMuon = dtNgayMuon.Value;
                DateTime ngayTra = dtNgayTra.Value;
                PhieuMuon phieuMuon = new PhieuMuon();
                phieuMuon.idDocGia = idDocGia;
                phieuMuon.idSach = idSach;
                phieuMuon.idNhanVien = idNhanVien;
                phieuMuon.ngayMuon = ngayMuon.ToString("yyyy-MM-dd");
                phieuMuon.ngayTra = ngayTra.ToString("yyyy-MM-dd");

                int result = phieuMuonBL.AddPhieuMuon(phieuMuon);
                if (result != 0)
                {
                    tbMaDG.Clear();
                    tbHoTen.Clear();
                    tbSoSachDaMuon.Clear();
                    tbMaSach.Clear();
                    tbTenSach.Clear();
                    tbSoLuongSach.Clear();
                    MessageBox.Show("Mượn thành công!", "Phiếu mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mượn thất bại!", "Phiếu mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Đã đạt giới hạn số sách đang mượn!", "Phiếu mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btCheckDocGia2_Click(object sender, EventArgs e)
        {
            string idDocGia = tbMaDG2.Text.ToString();
            List<PhieuMuonSach> phieuMuons = phieuMuonBL.GetAllPhieuMuon(idDocGia);
            dgvSachMuon.DataSource = phieuMuons;
        }

        private void dgvSachMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSachMuon.Rows[e.RowIndex];

                dtNgayMuon2.Value = Convert.ToDateTime(row.Cells["ngayMuon"].Value);
                dtNgayTra2.Value = Convert.ToDateTime(row.Cells["ngayTra"].Value);
                int henTra = DateTime.Now.Date.Subtract(dtNgayTra2.Value.Date).Days;
                tbSoNgayTre.Text = henTra < 0 ? "0" : henTra.ToString();
                int tienPhat = int.Parse(tbSoNgayTre.Text) * 10000;
                tbTienPhat.Text = tienPhat.ToString("C0", new CultureInfo("vi-VN"));
                idPhieuMuonTMP = row.Cells["id"].Value.ToString();
            }
        }

        private void btLuu2_Click(object sender, EventArgs e)
        {
            string idDocGia = tbMaDG2.Text.ToString();
            if (idPhieuMuonTMP != "")
            {
                string henTra = tbSoNgayTre.Text.ToString();
                bool treHen;

                if (henTra.Equals("0"))
                    treHen = false;
                else
                    treHen = true;
                int result = phieuMuonBL.TraSach(idPhieuMuonTMP, idDocGia, treHen);
                if (result != 0)
                {
                    idPhieuMuonTMP = "";
                    dtNgayMuon2.Value = DateTime.Now;
                    dtNgayTra2.Value = DateTime.Now;
                    tbSoNgayTre.Clear();
                    tbTienPhat.Clear();
                    List<PhieuMuonSach> phieuMuons = phieuMuonBL.GetAllPhieuMuon(idDocGia);
                    dgvSachMuon.DataSource = phieuMuons;
                    MessageBox.Show("Trả sách thành công!", "Phiếu mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
