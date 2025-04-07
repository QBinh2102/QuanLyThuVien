using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class PhieuMuon
    {
        public string id { get; set; }
        public string idDocGia { get; set; }
        public string idSach { get; set; }
        public string idNhanVien { get; set; }
        public string ngayMuon { get; set; }
        public string ngayTra { get; set; }
        public string trangThai { get; set; }

        public PhieuMuon() { }

        public PhieuMuon(string id, string idDocGia, string idSach, string idNhanVien, string ngayMuon, string ngayTra, string trangThai)
        {
            this.id = id;
            this.idDocGia = idDocGia;
            this.idSach = idSach;
            this.idNhanVien = idNhanVien;
            this.ngayMuon = ngayMuon;
            this.ngayTra = ngayTra;
            this.trangThai = trangThai;
        }
    }
}
