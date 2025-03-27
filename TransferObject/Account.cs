using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Account
    {
        private string id;
        private string username;
        private string password;
        private string hoTen;
        private string email;
        private string sdt;
        private string queQuan;

        public Account() { }
        public Account(string id, string username, string password, string hoTen, string email, string sdt, string queQuan)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.hoTen = hoTen;
            this.email = email;
            this.sdt = sdt;
            this.queQuan = queQuan;
        }

        public string Id 
        { 
            get { return id; } 
            set { id = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string HoTen
        {
            get { return this.hoTen; }
            set { this.hoTen = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Sdt
        {
            get { return this.sdt; }
            set { this.sdt = value; }
        }

        public string QueQuan
        {
            get { return this.queQuan; }
            set { this.queQuan = value; }
        }
    }
}
