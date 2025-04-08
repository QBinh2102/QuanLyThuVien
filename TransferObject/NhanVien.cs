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
        public string username { get; set; }

        public string password { get; set; }    
        public string email { get; set; }
        public string soDienThoai { get; set; }
        public string queQuan { get; set; }
        public int vaiTro {  get; set; }

        public DateTime ngayTao { get; set; }

        public bool active {  get; set; }

        public NhanVien() { }
        public NhanVien( string id, string hoTen, string email, string soDienThoai,string queQuan, string username,string password, int vaiTro, bool active, DateTime ngayTao)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.queQuan = queQuan;
            this.username = username;
            this.password = password;
            this.vaiTro = vaiTro;
            this.active = active;
            this.ngayTao = ngayTao;
        }
        public NhanVien(string id, string hoTen, string email, string soDienThoai, string queQuan, string username, int vaiTro, bool active, DateTime ngayTao)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.queQuan = queQuan;
            this.username = username;
           
            this.vaiTro = vaiTro;
            this.active = active;
            this.ngayTao = ngayTao;
        }
    }
}
