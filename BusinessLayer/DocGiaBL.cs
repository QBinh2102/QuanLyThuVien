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
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateDocGia(DocGia docGia)
        {
            try
            {
                return docGiaDL.UpdateDocGia(docGia);
            }catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}
