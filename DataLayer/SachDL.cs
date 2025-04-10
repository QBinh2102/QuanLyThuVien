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
    public class SachDL : DataProvider
    {
        public List<Sach> GetAllSach()
        {
            List<Sach> sachs = new List<Sach>();

            string sql = @"
        SELECT 
            s.id, 
            s.tenSach, 
            s.tacGia, 
            s.idTheLoai,
            tl.tenTheLoai,  
            s.namXuatBan, 
            s.soLuong, 
            s.soLuongConLai, 
            s.giaBia 
        FROM Sach s
        JOIN TheLoaiSach tl ON s.idTheLoai = tl.id";

            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string tenSach = reader["tenSach"].ToString();
                    string tacGia = reader["tacGia"].ToString();
                    string idTheLoai = reader["idTheLoai"].ToString();
                    string tenTheLoai = reader["tenTheLoai"].ToString();
                    string namXuatBan = reader["namXuatBan"].ToString();
                    int soLuong = reader["soLuong"] != DBNull.Value ? Convert.ToInt32(reader["soLuong"]) : 0;
                    int soLuongConLai = reader["soLuongConLai"] != DBNull.Value ? Convert.ToInt32(reader["soLuongConLai"]) : 0;
                    double giaBia = reader["giaBia"] != DBNull.Value ? Convert.ToDouble(reader["giaBia"]) : 0.0;

                    Sach sach = new Sach(id, tenSach, tacGia, idTheLoai, tenTheLoai, namXuatBan, soLuong, soLuongConLai, giaBia);
                    sachs.Add(sach);
                }
                reader.Close();
                return sachs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
        public int AddSach(Sach sach)
        {
            string sql = "INSERT INTO Sach (tenSach, tacGia, idTheLoai, namXuatBan, soLuong, soLuongConLai, giaBia) " +
                "VALUES (N'" + sach.tenSach + "', N'" + sach.tacGia + "', '" + sach.idTheLoai + "', '" + sach.namXuatBan + "', " +
                "'" + sach.soLuong + "', '" + sach.soLuongConLai + "', '" + sach.giaBia + "')";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdateSach(Sach sach)
        {
            string sql = "UPDATE Sach SET " +
                "tenSach = N'" + sach.tenSach + "', " +
                "tacGia = N'" + sach.tacGia + "', " +
                "idTheLoai = '" + sach.idTheLoai + "', " +
                "namXuatBan = '" + sach.namXuatBan + "', " +
                "soLuong = '" + sach.soLuong + "', " +
                "soLuongConLai = '" + sach.soLuongConLai + "', " +
                "giaBia = '" + sach.giaBia + "' " +
                "WHERE id = '" + sach.id + "'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int DeleteSach(string id)
        {
            string sql = "DELETE FROM Sach WHERE id = '" + id + "'";
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
