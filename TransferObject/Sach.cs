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
        public string idTheLoai { get; set; }
        public string namXuatBan { get; set; }
        public int soLuong { get; set; }
        public int soLuongConLai { get; set; }
        public double giaBia { get; set; }


        public Sach(string id, string tenSach,string tacGia, string idTheLoai, string namXuatBan, int soLuong, int soLuongConLai, double giaBia)
        {
            this.id = id;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.idTheLoai = idTheLoai;
            this.namXuatBan = namXuatBan;
            this.soLuong = soLuong;
            this.soLuongConLai = soLuongConLai;
            this.giaBia = giaBia;
        }

        public Sach(string id, string tenSach, string tacGia, string idTheLoai, string namXuatBan, int soLuong, double giaBia)
        {
            this.id = id;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.idTheLoai = idTheLoai;
            this.namXuatBan = namXuatBan;
            this.soLuong = soLuong;
            this.giaBia = giaBia;
        }
    }
}
