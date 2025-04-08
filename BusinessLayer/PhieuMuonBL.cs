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
        public PhieuMuonBL()
        {
            muonSachDL = new PhieuMuonDL();
        }

        public List<string> GetThongTinDocGia(string id)
        {
            try
            {
                return muonSachDL.GetThongTinDocGia(id);
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

        public int TraSach(string id)
        {
            try
            {
                return muonSachDL.TraSach(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
