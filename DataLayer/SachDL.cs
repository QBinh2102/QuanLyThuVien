﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransferObject;
namespace DataLayer
{
    public class SachDL:DataProvider
    {
        public List<Sach> GetSachs()
        {
            List<Sach> sachs = new List<Sach>();
            string sql = "Select * From Sach";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string tenSach = reader["tenSach"].ToString();
                    string tacGia = reader["tacGia"].ToString();
                    string idTheLoai = reader["idTheLoai"].ToString() ;
                    string namXuatBan = reader["namXuatBan"].ToString();
                   
                    int soLuong = reader["soLuong"] != DBNull.Value ? Convert.ToInt32(reader["soLuong"]) : 0;
                    int soLuongConLai = reader["soLuongConLai"] != DBNull.Value ? Convert.ToInt32(reader["soLuongConLai"]) : 0;
                    double giaBia = reader["giaBia"] != DBNull.Value ? Convert.ToDouble(reader["giaBia"]) : 0.0;

                    Sach sach = new Sach(id, tenSach, tacGia, idTheLoai, namXuatBan, soLuong, giaBia);
                    sachs.Add(sach);
                }
                reader.Close();
                return sachs;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }

        }
    }
}
