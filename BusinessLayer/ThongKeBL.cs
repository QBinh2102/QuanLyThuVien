using System;
using System.Collections.Generic;
using DataLayer;
using TransferObject;
using System.Data;
using System.Linq;

namespace BusinessLayer
{
    public class ThongKeBL
    {
        private ThongKeDL thongKeDL;

        public ThongKeBL()
        {
            thongKeDL = new ThongKeDL();
        }

        public List<ThongKeData> GetThongKeData(string kieu, int nam)
        {
            DataTable dt = thongKeDL.GetThongKeData(kieu, nam);
            List<ThongKeData> result = new List<ThongKeData>();
            if (kieu == "Năm")
            {
     
                var row = dt.Rows.Count > 0 ? dt.Rows[0] : null;
                int soLuong = row != null ? Convert.ToInt32(row["SoLuong"]) : 0;

               
                result.Add(new ThongKeData { Label = "Năm " + nam, SoLuong = soLuong });
            }
            else
            {
               
                int maxCount = kieu == "Tháng" ? 12 : 4;

                for (int i = 1; i <= maxCount; i++)
                {
                    var row = dt.AsEnumerable().FirstOrDefault(r => r.Field<int>("Label") == i);
                    int soLuong = row != null ? Convert.ToInt32(row["SoLuong"]) : 0;
                    string label = kieu == "Tháng" ? "Tháng " + i :
                                   kieu == "Quý" ? "Quý " + i : "Năm " + nam;

                    result.Add(new ThongKeData { Label = label, SoLuong = soLuong });
                }
            }

            return result;
        }


    }
}
