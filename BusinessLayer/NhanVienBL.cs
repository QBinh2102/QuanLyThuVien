using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using TransferObject; 

namespace BusinessLayer
{
    public class NhanVienBL
    {
        private NhanVienDL nhanVienDL;
        public NhanVienBL()
        {
            nhanVienDL = new NhanVienDL();
        }

        public List<NhanVien> GetAllNhanVien()
        {
            try
            {
                return nhanVienDL.GetAllNhanVien();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<NhanVien> TimKiemTheoTen(string keyword)
        {
            try
            {
                var allNhanVien = nhanVienDL.GetAllNhanVien();
                return allNhanVien
                    .Where(nv => nv.hoTen != null &&
                                 nv.hoTen.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
