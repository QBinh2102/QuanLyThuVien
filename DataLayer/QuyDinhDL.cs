using System;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class QuyDinhDL : DataProvider
    {
        public int SoNgay { get; private set; }
        public int SoSach { get; private set; }

        public QuyDinhDL()
        {
            string sql = "SELECT SoNgayTra, SoSachMuonToiDa FROM QuyDinh";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, System.Data.CommandType.Text);

                if (reader.Read()) 
                {
                    SoNgay = reader.GetInt32(reader.GetOrdinal("SoNgayTra"));
                    SoSach = reader.GetInt32(reader.GetOrdinal("SoSachMuonToiDa"));
                }

                reader.Close();
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
