using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class QuyDinhBL
    {
        private QuyDinhDL quyDinhDL;

        public QuyDinhBL()
        {
            quyDinhDL = new QuyDinhDL();
        }

        public QuyDinh GetQuyDinh()
        {
            QuyDinh q = new QuyDinh();
            q = quyDinhDL.GetQuyDinh();
            return new QuyDinh
            {
                SoNgay = q.SoNgay,
                SoSach = q.SoSach
            };
        }

        public int UpdateQuyDinh(QuyDinh quyDinh)
        {
            try
            {
                return quyDinhDL.UpdateQuyDinh(quyDinh);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}
