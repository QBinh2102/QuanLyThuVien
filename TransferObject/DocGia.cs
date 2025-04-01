using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class DocGia
    {
       public string id { get; set; }
       public string hoTen { get; set; }
       public string email { get; set; }
       public string soDienThoai { get; set; }
       public string diaChi { get; set; }

        public DateTime ngayTao { get; set; }  
        public bool active { get; set; }

        public DocGia(string id, string hoTen, string email, string soDienThoai, string diaChi, DateTime ngayTao, bool active)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.diaChi = diaChi;
            this.ngayTao = ngayTao;
            this.active = active;
        }


    }
}
