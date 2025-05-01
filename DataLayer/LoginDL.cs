using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class LoginDL : DataProvider
    {
        public NhanVien Login(string username, string password)
        {
            string sql = "SELECT *  FROM NhanVien WHERE username = '" + username + "' AND password = '" + password + "'";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                NhanVien nhanVien = null;
                if (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string hoTen = reader["hoTen"].ToString();
                    string userName = reader["username"].ToString();
                    string passWord = reader["password"].ToString();
                    string email = reader["email"].ToString();
                    string soDienThoai = reader["soDienThoai"].ToString();
                    string queQuan = reader["queQuan"].ToString();
                    int vaiTro;
                    if (bool.Parse(reader["vaiTro"].ToString()))
                    {
                        vaiTro = 1;
                    }
                    else
                    {
                        vaiTro = 0;
                    }
                    DateTime ngayTao = DateTime.Parse(reader["ngayTao"].ToString());
                    bool active = bool.Parse(reader["active"].ToString());
                    nhanVien = new NhanVien(id, hoTen, email, soDienThoai, queQuan, userName, passWord, vaiTro, active, ngayTao);
                }
                reader.Close();
                return nhanVien;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
    }
}
