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
    public class SachBL
    {
        private SachDL sachDL;
        public SachBL()
        {
            sachDL = new SachDL();
        }

        public List<Sach> GetAllSach()
        {
            try
            {
               return sachDL.GetAllSach();
                
            }
            catch(SqlException ex) {
                throw ex;
            }
        }

        public List<Sach> TimKiemTheoTen(string keyword)
        {
            return GetAllSach()
                .Where(s => s.tenSach != null &&
                            s.tenSach.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public List<Sach> TimKiemTheoTacGia(string keyword)
        {
            return GetAllSach()
                .Where(s => s.tacGia != null &&
                            s.tacGia.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        //public List<Sach> TimKiemTheoTheLoai(string keyword)
        //{
        //    return GetAllSach()
        //        .Where(s => s.tenTheLoai != null &&
        //                    s.tenTheLoai.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
        //        .ToList();
        //}


        //public List<Sach> TimKiemTheoTheLoai(string keyword)
        //{
        //    return GetAllSach().Where(s => s.TenTheLoai.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
        //}
    }
}
