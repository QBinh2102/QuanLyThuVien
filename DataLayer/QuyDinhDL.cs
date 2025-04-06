using System;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class QuyDinhDL : DataProvider
    {
        //public int SoNgay { get; private set; }
        //public int SoSach { get; private set; }
        
        public QuyDinh getQuyDinh()
        {
            QuyDinh q = new QuyDinh();
            string sql = "SELECT SoNgayTra, SoSachMuonToiDa FROM QuyDinh";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);

                if (reader.Read()) 
                {
                    q.SoNgay = reader.GetInt32(reader.GetOrdinal("SoNgayTra"));
                    q.SoSach = reader.GetInt32(reader.GetOrdinal("SoSachMuonToiDa"));
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


    }
}
