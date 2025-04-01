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
    public class DocGiaDL : DataProvider
    {
        public List<DocGia> GetDocGias()
        {
            List<DocGia> docGias = new List<DocGia>();
            //string sql = "SELECT * FROM DocGia";
            string sql = "SELECT id, hoTen, email, soDienThoai, diaChi, CAST(ngayTao AS DATE) AS ngayTao, active FROM DocGia";

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
                    string diaChi = reader["diaChi"].ToString();
                    DateTime ngayTao = Convert.ToDateTime(reader["ngayTao"]);
                    bool active = Convert.ToBoolean(reader["active"]);

                    DocGia docGia = new DocGia(id, hoTen, email, soDienThoai, diaChi, ngayTao, active);
                    docGias.Add(docGia);
                }
                reader.Close();
                return docGias;
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

        //public int AddDocGia(DocGia docGia)
        //{
        //    string sql = "INSERT INTO DocGia (id, hoTen, email, soDienThoai, diaChi, ngayTao, active) " +
        //                 "VALUES (@id, @hoTen, @email, @soDienThoai, @diaChi, @ngayTao, @active)";

        //    try
        //    {
        //        List<SqlParameter> parameters = new List<SqlParameter>
        //        {
        //            new SqlParameter("@id", docGia.id),
        //            new SqlParameter("@hoTen", docGia.hoTen),
        //            new SqlParameter("@email", docGia.email),
        //            new SqlParameter("@soDienThoai", docGia.soDienThoai),
        //            new SqlParameter("@diaChi", docGia.diaChi),
        //            new SqlParameter("@ngayTao", docGia.ngayTao),
        //            new SqlParameter("@active", docGia.active)
        //        };

        //        return MyExecuteNonQuery(sql, CommandType.Text);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
