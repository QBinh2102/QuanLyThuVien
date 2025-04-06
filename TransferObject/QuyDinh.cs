using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TransferObject
{
    public class QuyDinh
    {
        public int SoNgay { get; set; }
        public int SoSach { get; set; }

        public QuyDinh() { }

        public QuyDinh(int soNgay, int soSach)
        {
            SoNgay = soNgay;
            SoSach = soSach;
        }
    }
}

