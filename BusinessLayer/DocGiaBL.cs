using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using TransferObject;

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
    }
}
