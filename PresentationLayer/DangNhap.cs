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

        private readonly UserService _userService;
        public DangNhap()
        {
            InitializeComponent();
            //string cnStr = "Data Source=.;Initial Catalog=librarydb;Integrated Security=True";
            //cn = new SqlConnection(cnStr);

            //_userService = new UserService();
        }

        private bool isLogin(string us, string pass)
        {
            string sqlStr = "SELECT COUNT(username) FROM NhanVien WHERE username = '" + us + "' and password = '" + pass + "'";
            SqlCommand cmd = new SqlCommand(sqlStr, cn);
            cmd.CommandType = CommandType.Text;
            
            
            cn.Open();
            int result = (int)cmd.ExecuteScalar();
            cn.Close();
            return (result>0);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUsername.Text.Trim();
            pass = txtPassword.Text;

            if (UserService.Instance.AuthenticateUser(user,pass))
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
