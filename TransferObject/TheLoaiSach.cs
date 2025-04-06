using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class TheLoaiSach
    {
        public string ID { get; set; }
        public string TenTheLoai { get; set; }

        public TheLoaiSach(string ID, string tenTheLoai) { 
            this.ID = ID;
            this.TenTheLoai = tenTheLoai;
        }
    }
}
