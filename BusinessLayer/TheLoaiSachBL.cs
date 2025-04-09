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

        public int AddTheLoai(TheLoaiSach theLoai)
        {
            return theLoaiSachDL.AddTheLoai(theLoai);
        }

        public int UpdateTheLoai(TheLoaiSach theLoai)
        {
            return theLoaiSachDL.UpdateTheLoai(theLoai);
        }

        public int DeleteTheLoai(string id)
        {
            return theLoaiSachDL.DeleteTheLoai(id);
        }

        public List<TheLoaiSach> TimKiemTheoTen(string keyword)
        {
            List<TheLoaiSach> all = GetAllTheLoaiSach();

            return all
                .Where(tl => !string.IsNullOrWhiteSpace(tl.TenTheLoai) &&
                             tl.TenTheLoai.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

    }

}
