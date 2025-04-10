using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Sach
    {
        public string id { get; set; }
        public string tenSach { get; set; }
        public string tacGia { get; set; }
        public string tenTheLoai { get; set; } 
        public string namXuatBan { get; set; }
        public int soLuong { get; set; }
        public int soLuongConLai { get; set; }
        public double giaBia { get; set; }

        public string idTheLoai { get; set; }

        public Sach() { }
        public Sach(string id, string tenSach, string tacGia, string idTheLoai, string tenTheLoai, string namXuatBan, int soLuong, int soLuongConLai, double giaBia)
        {
            this.id = id;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.idTheLoai = idTheLoai;
            this.tenTheLoai = tenTheLoai;
            this.namXuatBan = namXuatBan;
            this.soLuong = soLuong;
            this.soLuongConLai = soLuongConLai;
            this.giaBia = giaBia;
        }
    }
}
