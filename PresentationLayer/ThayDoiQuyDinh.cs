using System;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class ThayDoiQuyDinh : Form
    {
        QuyDinhBL quyDinhBL;
        QuyDinh quyDinh;

        public ThayDoiQuyDinh()
        {
            InitializeComponent();
            quyDinhBL = new QuyDinhBL();
            quyDinh = new QuyDinh();
        }

        private void ThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            try
            {
                quyDinh = quyDinhBL.GetQuyDinh();

                tbSoNgayMuonToiDa.Text = quyDinh.SoNgay.ToString();
                tbSoSachMuonToiDa.Text = quyDinh.SoSach.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải quy định: " + ex.Message);
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            int soSach = int.Parse(tbSoSachMuonToiDa.Text.ToString());
            int soNgay = int.Parse(tbSoNgayMuonToiDa.Text.ToString());

            if (soNgay <= 0)
            {
                MessageBox.Show("Số ngày mượn phải lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (soSach <= 0)
            {
                MessageBox.Show("Số sách mượn phải lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            quyDinh.SoSach = soSach;
            quyDinh.SoNgay = soNgay;

            int result = quyDinhBL.UpdateQuyDinh(quyDinh);
            if (result != 0)
            {
                MessageBox.Show("Thay đổi quy định thành công!", "Quy Định", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thay đổi quy định thất bại!", "Quy Định", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
