using System;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class QuyDinhDL : DataProvider
    {
        public QuyDinh GetQuyDinh()
        {
            QuyDinh q = new QuyDinh();
            string sql = "SELECT SoNgayTra, SoSachMuonToiDa FROM QuyDinh";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);

                if (reader.Read()) 
                {
                    q.SoNgay = int.Parse(reader["SoNgayTra"].ToString());
                    q.SoSach = int.Parse(reader["SoSachMuonToiDa"].ToString());
                }

                reader.Close();
                return q;
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

        public int UpdateQuyDinh(QuyDinh quyDinh)
        {
            string sql = "UPDATE QuyDinh SET soNgayTra = '" + quyDinh.SoNgay + "', soSachMuonToiDa = '" + quyDinh.SoSach + "' " +
                "WHERE id = 1";
            try
            {
                Connect();
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch(SqlException ex)
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
