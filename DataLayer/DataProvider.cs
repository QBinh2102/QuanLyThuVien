using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    internal class DataProvider
    {
        private SqlConnection cn;
        public DataProvider()
        {
            //string cnStr = "Data Source=HSANG\\SQLEXPRESS;Initial Catalog=librarydb;Integrated Security=True;";
            string cnStr = "Data Source=.;Initial Catalog=librarydb;Integrated Security=True;";
            cn = new SqlConnection(cnStr);
        }

        private void Connect()
        {
            try
            {
                if(cn!=null&&cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void DisConnect()
        {
            try
            {
                if(cn!=null&&cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public Object MyExecuteScalar(string sql, CommandType type)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = type;

            try
            {
                Connect();
                return (cmd.ExecuteScalar());
            }
            catch (SqlException ex)
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
