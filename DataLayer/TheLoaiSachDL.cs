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
    public class TheLoaiSachDL : DataProvider
    {
        public List<TheLoaiSach> GetAllTheLoai()
        {
            List<TheLoaiSach> allTheLoai = new List<TheLoaiSach>();
            string sql = "Select * from TheLoaiSach";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read()) {
                    string id = reader["id"].ToString();
                    string tenTheLoai = reader["tenTheLoai"].ToString();

                    TheLoaiSach theLoai = new TheLoaiSach(id, tenTheLoai);
                    allTheLoai.Add(theLoai);
                }
                reader.Close();
                return allTheLoai;

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
