using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class PhieuMuonSach
    {
        public string id { get; set; }
        public string tenDocGia { get; set; }
        public string tenSach { get; set; }
        public string tenNhanVien { get; set; }
        public string ngayMuon { get; set; }
        public string ngayTra { get; set; }
        public string trangThai { get; set; }

        public PhieuMuonSach() { }

        public PhieuMuonSach(string id, string tenDocGia, string tenSach, string tenNhanVien, string ngayMuon, string ngayTra, string trangThai)
        {
            this.id = id;
            this.tenDocGia = tenDocGia;
            this.tenSach = tenSach;
            this.tenNhanVien = tenNhanVien;
            this.ngayMuon = ngayMuon;
            this.ngayTra = ngayTra;
            this.trangThai = trangThai;
        }
    }
}
