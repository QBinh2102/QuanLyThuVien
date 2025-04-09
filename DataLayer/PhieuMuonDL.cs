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

        public List<PhieuMuonSach> GetAllPhieuMuon(string idDocGia)
        {
            string sql = "SELECT pm.id, dg.hoTen as tenDocGia, s.tenSach as tenSach, nv.hoTen as tenNhanVien, pm.ngayMuon, pm.ngayTra, pm.trangThai " +
                "FROM MuonTraSach pm " +
                "JOIN DocGia dg ON pm.idDocGia = dg.id " +
                "JOIN Sach s ON pm.idSach = s.id " +
                "JOIN NhanVien nv ON pm.idNhanVien = nv.id " +
                "WHERE pm.idDocGia = '" + idDocGia + "' AND pm.trangThai = 'dang_muon'";
            List<PhieuMuonSach> phieuMuons = new List<PhieuMuonSach>();

            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql,CommandType.Text);
                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string tenDocGia = reader["tenDocGia"].ToString();
                    string tenSach = reader["tenSach"].ToString();
                    string tenNhanVien = reader["tenNhanVien"].ToString();
                    string ngayMuon = reader["ngayMuon"].ToString();
                    string ngayTra = reader["ngayTra"].ToString();
                    string trangThai = reader["trangThai"].ToString();
                    phieuMuons.Add(new PhieuMuonSach(id, tenDocGia, tenSach, tenNhanVien, ngayMuon, ngayTra, trangThai));
                }
                reader.Close();
                return phieuMuons;
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

        public int TraSach(string idPhieuMuon)
        {
            string sql = "UPDATE MuonTraSach SET trangThai = 'da_tra' WHERE id = '" + idPhieuMuon + "'";
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

        public int GetSoSachDangMuonTheoIdDocGia(string idDocGia)
        {
            string sql = "SELECT soSachDangMuon FROM DocGia WHERE id = '" + idDocGia + "'";

            try
            {
                Connect();
                return (int) MyExecuteScalar(sql, CommandType.Text);
            }catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        public int CapNhatSoSachDangMuonTheoIdDocGia(string idDocGia, string toanTu)
        {
            int soSachDangMuon = GetSoSachDangMuonTheoIdDocGia(idDocGia);
            if(toanTu == "+")
            {
                soSachDangMuon++;
            }
            else if(toanTu == "-")
            {
                soSachDangMuon--;
            }

            string sql = "UPDATE DocGia SET soSachDangMuon = '" + soSachDangMuon + "' WHERE id = '" + idDocGia + "'";
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

        public int GetSoSachConLaiTheoIdSach(string idSach)
        {
            string sql = "SELECT soLuongConLai FROM Sach WHERE id = '" + idSach + "'";

            try
            {
                Connect();
                return (int)MyExecuteScalar(sql, CommandType.Text);
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

        public int GetIdSachTheoIdPhieuMuon(string idPhieuMuon)
        {
            string sql = "SELECT idSach FROM MuonTraSach WHERE id = '"+idPhieuMuon + "'";
            try
            {
                Connect();
                return (int) MyExecuteScalar(sql, CommandType.Text);
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

        public int CapNhatSoSachConLaiTheoIdSach(string idSach, string toanTu)
        {
            int soSachConLai = GetSoSachConLaiTheoIdSach(idSach);
            if (toanTu == "+")
            {
                soSachConLai++;
            }
            else if (toanTu == "-")
            {
                soSachConLai--;
            }

            string sql = "UPDATE Sach SET soLuongConLai = '" + soSachConLai + "' WHERE id = '" + idSach + "'";
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
