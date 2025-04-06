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
            return new QuyDinh
            {
                SoNgay = quyDinhDL.SoNgay,
                SoSach = quyDinhDL.SoSach
            };
        }
    }
}
