using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class ProductDetailsClass
    {
        ConnectionClass conObj = new ConnectionClass();

        public SqlDataReader getProductDetails(int PdtID)
        {
            string getProductDetails = "select * from Products_table where Product_ID=" + PdtID + "";
            SqlDataReader data = conObj.Fn_ExecuteReader(getProductDetails);
            return data;
        }
    }
}
