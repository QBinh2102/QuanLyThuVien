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
        public List<DocGia> GetAllDocGia()
        {
            List<DocGia> docGias = new List<DocGia>();
            //string sql = "SELECT * FROM DocGia";
            string sql = "SELECT id, hoTen, email, soDienThoai, diaChi, CAST(ngayTao AS DATE) AS ngayTao, active, soSachDangMuon FROM DocGia";

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
                    string soSachDangMuon = reader["soSachDangMuon"].ToString();

                    DocGia docGia = new DocGia(id, hoTen, email, soDienThoai, diaChi, ngayTao, active, soSachDangMuon);
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

        public int AddDocGia(DocGia docGia)
        {
            string sql = "INSERT INTO DocGia (hoTen, email, soDienThoai, diaChi, ngayTao, active) " +
                         "VALUES (N'" + docGia.hoTen + "', '" + docGia.email + "', '" + docGia.soDienThoai + "'," +
                         " N'" + docGia.diaChi + "', '" + docGia.ngayTao + "', '" + docGia.active + "')";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int UpdateDocGia(DocGia docGia)
        {
            string sql = "UPDATE DocGia SET hoTen = N'" + docGia.hoTen + "', email = '" + docGia.email + "', soDienThoai = '" + docGia.soDienThoai + "'," +
                         "diaChi = N'" + docGia.diaChi + "', active = '" + docGia.active + "' WHERE id = '" + docGia.id + "'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public int DeleteDocGia(string id)
        {
            string sql = "DELETE FROM DocGia WHERE id = '" + id + "'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DocGia GetDocGiaTheoId(string idDocGia)
        {
            DocGia docGia = new DocGia();
            string sql = "SELECT * FROM DocGia WHERE id = '" + idDocGia + "' AND active = '"+true+"'";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                if (reader.Read())
                {
                    docGia.id = idDocGia;
                    docGia.hoTen = reader["hoTen"].ToString();
                    docGia.email = reader["email"].ToString();
                    docGia.soDienThoai = reader["soDienThoai"].ToString();
                    docGia.diaChi = reader["diaChi"].ToString();
                    docGia.ngayTao = Convert.ToDateTime(reader["ngayTao"]);
                    docGia.active = Convert.ToBoolean(reader["active"]);
                    docGia.soSachDangMuon = reader["soSachDangMuon"].ToString();
                }
                else
                {
                    docGia = null;
                }
                reader.Close();
                return docGia;
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