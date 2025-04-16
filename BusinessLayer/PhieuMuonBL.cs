using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class PhieuMuonBL
    {
        private PhieuMuonDL muonSachDL;
        private DocGiaDL docGiaDL;
        public PhieuMuonBL()
        {
            muonSachDL = new PhieuMuonDL();
            docGiaDL = new DocGiaDL();
        }

        public DocGia GetThongTinDocGia(string id)
        {
            try
            {
                return docGiaDL.GetDocGiaTheoId(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<string> GetThongTinSach(string id)
        {
            try
            {
                return muonSachDL.GetThongTinSach(id);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public int AddPhieuMuon(PhieuMuon phieuMuon)
        {
            try
            {
                muonSachDL.CapNhatSoSachConLaiTheoIdSach(phieuMuon.idSach, "-");
                muonSachDL.CapNhatSoSachDangMuonTheoIdDocGia(phieuMuon.idDocGia, "+");
                return muonSachDL.AddPhieuMuon(phieuMuon);
            }catch(SqlException ex)
            {
                throw ex;
            }
        }

        public List<PhieuMuonSach> GetAllPhieuMuon(string idDocGia)
        {
            try
            {
                return muonSachDL.GetAllPhieuMuon(idDocGia);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public int TraSach(string idPhieuMuon, string idDocGia)
        {
            try
            {
                string idSach = muonSachDL.GetIdSachTheoIdPhieuMuon(idPhieuMuon).ToString();
                muonSachDL.CapNhatSoSachConLaiTheoIdSach(idSach, "+");
                muonSachDL.CapNhatSoSachDangMuonTheoIdDocGia(idDocGia, "-");
                return muonSachDL.TraSach(idPhieuMuon);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
