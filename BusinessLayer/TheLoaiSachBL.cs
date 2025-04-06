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
   public class TheLoaiSachBL
    {
        private TheLoaiSachDL theLoaiSachDL;

        public TheLoaiSachBL()
        {
            theLoaiSachDL = new TheLoaiSachDL();
        }

        public List<TheLoaiSach> GetAllTheLoaiSach()
        {
            try
            {
                return theLoaiSachDL.GetAllTheLoai();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
    }
}
