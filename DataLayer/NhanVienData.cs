using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

using TransferObject;

namespace DataLayer
{
    public class NhanVienData
    {
        private string _connectionString = "Data Source=HSANG\\SQLEXPRESS;Initial Catalog=librarydb;Integrated Security=True"; // Thay thế bằng chuỗi kết nối thực tế
        //private string _connectionString = "Data Source=.;Initial Catalog=librarydb;Integrated Security=True";
        public Account GetUserByUsernameAndPassword(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT id, hoTen, email, soDienThoai, queQuan FROM NhanVien WHERE username = @Username AND password = @Password"; // Lưu ý: Cần mã hóa mật khẩu trong CSDL
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password); 

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Account user = new Account();
                    user.Username = username;
                    user.Password = password;
                    user.Id = reader["id"].ToString();
                    user.HoTen = reader["hoTen"].ToString();
                    user.Email = reader["email"].ToString();
                    user.Sdt = reader["soDienThoai"].ToString();
                    user.QueQuan = reader["queQuan"].ToString();
                    return user;
                }
            }
            return null;
        }
    }
}
