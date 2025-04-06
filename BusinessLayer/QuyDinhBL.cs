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

        public QuyDinh LayQuyDinh()
        {
            QuyDinh q = new QuyDinh();
            q = quyDinhDL.getQuyDinh();
            return new QuyDinh
            {
                SoNgay = q.SoNgay,
                SoSach = q.SoSach
            };
        }
    }
}
