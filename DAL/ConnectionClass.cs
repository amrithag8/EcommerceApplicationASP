using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectionClass
    {
        SqlConnection con;
        SqlCommand cmd;
        public ConnectionClass()
        {
            con = new SqlConnection(@"server=LAPTOP-5LKA3HOK\SQLEXPRESS; database=EcommerceProject; Integrated security=true");
        }


        public int Fn_ExecuteNonQuery(string sqlQuery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public string Fn_ExecuteScalar(string sqlQuery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            object i = cmd.ExecuteScalar();
            con.Close();

            if (i==null)
            {
                return null;
            }
            else
            {
                return i.ToString();
            }
            
        }


        public SqlDataReader Fn_ExecuteReader(string sqlQuery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader data = cmd.ExecuteReader();

            
            return data;
        }

        public DataSet Fn_Adapter(string sqlQuery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataTable Fn_AdapterUsingTable(string sqlQuery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }




    }
}
