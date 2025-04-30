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
            else if (kieu == "Năm")
            {
                sql = "SELECT COUNT(*) AS SoLuong " +
                      "FROM MuonTraSach " +
                      "WHERE YEAR(ngayMuon) = @nam";
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
    }
}
