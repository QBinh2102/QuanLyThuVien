using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class PhieuMuonDL:DataProvider
    {
        public List<string> GetThongTinDocGia(string id)
        {
            List<string> arr = new List<string>();
            string sql = "SELECT hoTen, soSachDangMuon FROM DocGia WHERE id = '" + id + "'";

            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                if (reader.Read())
                {
                    arr.Add(reader["hoTen"].ToString());
                    arr.Add(reader["soSachDangMuon"].ToString());
                }
                else
                {
                    arr = null;
                }
                reader.Close();
                return arr;
            }catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        public List<string> GetThongTinSach(string id)
        {
            List<string> arr = new List<string>();
            string sql = "SELECT tenSach, soLuongConLai FROM Sach WHERE id = '" + id + "'";

            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql,CommandType.Text);
                if (reader.Read())
                {
                    arr.Add(reader["tenSach"].ToString());
                    arr.Add(reader["soLuongConLai"].ToString());
                }
                else
                {
                    arr = null;
                }
                reader.Close();
                return arr;
            }catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        public int AddPhieuMuon(PhieuMuon phieuMuon)
        {
            string sql = "INSERT INTO MuonTraSach (idDocGia, idSach, idNhanVien, ngayMuon, ngayTra)" +
                "VALUES ('" + phieuMuon.idDocGia + "','" + phieuMuon.idSach + "','" + phieuMuon.idNhanVien + 
                "','" + phieuMuon.ngayMuon + "','" + phieuMuon.ngayTra + "')";
            try
            {
                Connect();
                return MyExecuteNonQuery(sql,CommandType.Text);
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
