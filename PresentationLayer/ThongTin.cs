using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class ThongTin : Form
    {
        //private readonly UserService userService;
        public ThongTin()
        {
            InitializeComponent();
            //userService = new UserService();
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            if (UserService.Instance.Acc != null)
            {
                txtUser.Text = UserService.Instance.Acc.Username;
                txtHoTen.Text = UserService.Instance.Acc.HoTen;
                txtSDT.Text = UserService.Instance.Acc.Sdt;
                txtEmail.Text = UserService.Instance.Acc.Email;
                txtQueQuan.Text = UserService.Instance.Acc.QueQuan;
            }
            else
            {
                txtUser.Text = "ABC";
            }
        }

        private void btnThayMatKhau_Click(object sender, EventArgs e)
        {
            using(ThayMatKhau tmk = new ThayMatKhau())
            {
                if(tmk.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
