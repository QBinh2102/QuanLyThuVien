using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class NhanVienDL : DataProvider
    {
        public List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string sql = "SELECT id, hoTen, email, soDienThoai, queQuan, username, vaiTro, CAST(ngayTao AS DATE) AS ngayTao, active FROM NhanVien";

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
                    string username = reader["username"].ToString();
                    int vaiTro = Convert.ToInt32(reader["vaiTro"]);
                    bool active = Convert.ToBoolean(reader["active"]); 
                    DateTime ngayTao = Convert.ToDateTime(reader["ngayTao"]);
                   

                    NhanVien nhanVien = new NhanVien(id, hoTen, email, soDienThoai, queQuan, username, vaiTro, active, ngayTao);
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

        public int AddNhanVien(NhanVien nv)
        {
            string sql = "INSERT INTO NhanVien (hoTen, email, soDienThoai, queQuan, username, vaiTro, active, password) " +
             "VALUES (N'" + nv.hoTen + "', '" + nv.email + "', '" + nv.soDienThoai + "', N'" + nv.queQuan +
             "', '" + nv.username + "', '" + nv.vaiTro + "', '" + nv.active + "', '" + nv.password + "')";

            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdateNhanVien(NhanVien nv)
        {
            string sql = "UPDATE NhanVien SET hoTen = N'" + nv.hoTen + "', email = '" + nv.email + "', soDienThoai = '" + nv.soDienThoai + "'," +
                         "queQuan = N'" + nv.queQuan + "', username = '" + nv.username + "', vaiTro = '" + nv.vaiTro + "', active = '" + nv.active + "' WHERE id = '" + nv.id + "'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int DeleteNhanVien(string id)
        {
            string sql = "DELETE FROM NhanVien WHERE id = '" + id + "'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
