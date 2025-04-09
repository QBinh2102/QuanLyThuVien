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
            string sql = "SELECT * FROM TheLoaiSach";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
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

        public int AddTheLoai(TheLoaiSach theLoai)
        {
            string sql = "INSERT INTO TheLoaiSach (tenTheLoai) " +
                         "VALUES (N'" + theLoai.TenTheLoai + "')";
            try
            {
                Connect();
                return MyExecuteNonQuery(sql, CommandType.Text);
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


        public int UpdateTheLoai(TheLoaiSach theLoai)
        {
            string sql = "UPDATE TheLoaiSach SET tenTheLoai = N'" + theLoai.TenTheLoai + "' " +
                         "WHERE id = '" + theLoai.ID + "'";
            try
            {
                Connect();
                return MyExecuteNonQuery(sql, CommandType.Text);
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

        public int DeleteTheLoai(string id)
        {
            string sql = "DELETE FROM TheLoaiSach WHERE id = '" + id + "'";
            try
            {
                Connect();
                return MyExecuteNonQuery(sql, CommandType.Text);
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
