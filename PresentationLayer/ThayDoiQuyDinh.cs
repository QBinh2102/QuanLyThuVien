using System;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class ThayDoiQuyDinh : Form
    {
        QuyDinhBL quyDinhBL;

        public ThayDoiQuyDinh()
        {
            InitializeComponent();
            quyDinhBL = new QuyDinhBL();
        }

        private void ThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            try
            {
                QuyDinh qd = quyDinhBL.GetQuyDinh();

                tbSoNgayMuonToiDa.Text = qd.SoNgay.ToString();
                tbSoSachMuonToiDa.Text = qd.SoSach.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải quy định: " + ex.Message);
            }
        }
    }
}
