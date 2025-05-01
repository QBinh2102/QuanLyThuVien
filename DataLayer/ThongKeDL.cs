using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class ThongKeDL : DataProvider
    {
        public DataTable GetThongKeData(string kieu, int nam)
        {
            string sql = "";
            if (kieu == "Tháng")
            {
                sql = "SELECT MONTH(ngayMuon) AS Label, COUNT(*) AS SoLuong " +
                      "FROM MuonTraSach " +
                      "WHERE YEAR(ngayMuon) = @nam " +
                      "GROUP BY MONTH(ngayMuon) " +
                      "ORDER BY Label";
            }
            else if (kieu == "Quý")
            {
                sql = "SELECT DATEPART(QUARTER, ngayMuon) AS Label, COUNT(*) AS SoLuong " +
                      "FROM MuonTraSach " +
                      "WHERE YEAR(ngayMuon) = @nam " +
                      "GROUP BY DATEPART(QUARTER, ngayMuon) " +
                      "ORDER BY Label";
            }
         

            DataTable dt = new DataTable();

            try
            {
                Connect(); 

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nam", nam);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect(); 
            }

            return dt;
        }

        public DataTable GetTiLeTraDungHan(int nam)
        {
            string sql = @"
                            SELECT 
                                CASE 
                                    WHEN trangThai = 'da_tra' THEN N'Đúng hạn' 
                                    WHEN trangThai = 'tra_tre' THEN N'Trễ hạn'
                                END AS TinhTrang,
                                COUNT(*) AS SoLuong,
                                (COUNT(*) * 100.0) / (SELECT COUNT(*) FROM MuonTraSach WHERE YEAR(ngayTra) = @nam AND trangThai <> 'dang_muon') AS TiLe
                            FROM MuonTraSach
                            WHERE YEAR(ngayMuon) = @nam
                            AND trangThai <> 'dang_muon' 
                            GROUP BY 
                                CASE 
                                    WHEN trangThai = 'da_tra' THEN N'Đúng hạn' 
                                    WHEN trangThai = 'tra_tre' THEN N'Trễ hạn'
                                END";



            DataTable dt = new DataTable();
            try
            {
                Connect();  
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@nam", nam);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();  
            }

            return dt;
        }
    }
}
