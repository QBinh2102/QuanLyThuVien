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

namespace PresentationLayer
{
    public partial class ThayMatKhau : Form
    {
        SqlConnection cn;
        public ThayMatKhau()
        {
            InitializeComponent();

            string cnSql = "Data Source=.;Initial Catalog=librarydb;Integrated Security=True";
            cn = new SqlConnection(cnSql);
        }

        private void btnHuyThayMatKhau_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnXacNhanMatKhau_Click(object sender, EventArgs e)
        {
            string pass, newPass, confirmNewPass;
            pass = txtMatKhauHienTai.Text.ToString();
            newPass = txtMatKhauMoi.Text.ToString();
            confirmNewPass = txtXacNhanMatKhauMoi.Text.ToString();

            if (pass != UserService.Instance.Acc.Password)
            {
                lbThongBaoMK.Text = "Mật khẩu hiện tại không đúng";
            } else
                if (newPass != confirmNewPass)
            {
                lbThongBaoMK.Text = "Mật khẩu không khớp";
            }
            else {
                string strSql = "UPDATE NhanVien SET password = '" + newPass + "' WHERE id = '" + UserService.Instance.Acc.Id + "'";
                SqlCommand cmd = new SqlCommand(strSql, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
