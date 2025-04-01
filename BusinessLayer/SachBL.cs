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

        public List<Sach> GetSachs()
        {
            try
            {
               return sachDL.GetSachs();
                
            }
            catch(SqlException ex) {
                throw ex;
            }
        }
    }
}
