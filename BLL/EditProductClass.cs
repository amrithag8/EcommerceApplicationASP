using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class EditProductClass
    {
        ConnectionClass conObj = new ConnectionClass();
        
        public DataSet GetAllProducts()
        {
            string str = "select * from Products_table";
            DataSet ds = conObj.Fn_Adapter(str);
            return ds;
        }

        public string GetImageUrl(int id)
        {
            string str = "select Product_image from Products_table where Product_ID=" + id + "";
            string img = conObj.Fn_ExecuteScalar(str);
            return img;
        }

        public int EditProductsDetails(int cid, string desc, decimal price, int stock, string img, string status, int id)
        {
            string str="update Products_table set Category_ID="+cid+", Product_desc='"+desc+"', Price="+price+", Product_stock="+stock+", Product_image='"+img+"', Product_status='"+status+"' where Product_ID="+id+" ";
            int i = conObj.Fn_ExecuteNonQuery(str);
            return i;
        }
        

        
    }
}
