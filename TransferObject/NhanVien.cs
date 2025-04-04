using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public  class NhanVien
    {
        public string id { get; set; }
        public string hoTen { get; set; }
        public string email { get; set; }
        public string soDienThoai { get; set; }
        public string queQuan { get; set; }
        public int vaiTro {  get; set; }
        
        public bool active {  get; set; }

        public NhanVien( string id, string hoTen, string email, string soDienThoai,string queQuan, int vaiTro, bool active)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.queQuan = queQuan;
            this.vaiTro = vaiTro;
            this.active = active;
        }
    }
}
