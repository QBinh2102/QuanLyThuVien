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
    }
}
