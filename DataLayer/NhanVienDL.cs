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
    public class NhanVienDL:DataProvider
    {
        public List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string sql = "SELECT id, hoTen, email, soDienThoai, queQuan, vaiTro, CAST(ngayTao AS DATE) AS ngayTao, active FROM NhanVien\r\n";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string hoTen = reader["hoTen"].ToString();
                    string email = reader["email"].ToString();
                    string soDienThoai = reader["soDienThoai"].ToString();
                    string queQuan = reader["queQuan"].ToString();
                    int vaiTro = Convert.ToInt32(reader["vaiTro"]);
                    bool active = Convert.ToBoolean(reader["active"]);

                    NhanVien nhanVien = new NhanVien(id, hoTen, email, soDienThoai, queQuan, vaiTro, active);
                    nhanViens.Add(nhanVien);
                }
                reader.Close();
                return nhanViens;
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
