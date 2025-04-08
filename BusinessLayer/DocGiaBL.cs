using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using TransferObject;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class DocGiaBL
    {
        private DocGiaDL docGiaDL;
        public DocGiaBL()
        {
            docGiaDL = new DocGiaDL();
        }

        public List<DocGia> GetAllDocGia()
        {
            try
            {
                return docGiaDL.GetAllDocGia();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddDocGia(DocGia docGia)
        {
            try
            {
                return docGiaDL.AddDocGia(docGia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateDocGia(DocGia docGia)
        {
            try
            {
                return docGiaDL.UpdateDocGia(docGia);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int DeleteDocGia(string id)
        {
            try
            {
                return docGiaDL.DeleteDocGia(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DocGia> TimKiemTheoTen(string keyword)
        {
            List<DocGia> allDocGias = GetAllDocGia();

            return allDocGias
                .Where(dg => !string.IsNullOrWhiteSpace(dg.hoTen) &&
                             dg.hoTen.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public bool CheckEmail(string email)
        {
            return docGiaDL.GetAllDocGia().Any(d => d.email == email);
        }




    }
}