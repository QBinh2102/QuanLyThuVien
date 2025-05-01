using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransferObject;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class DangNhap : Form
    {
        SqlConnection cn;
        private LoginBL loginBL;
        public NhanVien nhanVien {  get; set; }

        public DangNhap()
        {
            InitializeComponent();
            loginBL = new LoginBL();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUsername.Text.Trim();
            pass = txtPassword.Text;

            nhanVien = loginBL.Login(user, pass);

            if (nhanVien != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lbThongBao.Text = "Tài khoản hoặc mật khẩu không đúng";
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
