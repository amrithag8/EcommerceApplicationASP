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
    public class EditCategoryClass
    {
        ConnectionClass conObj = new ConnectionClass();

        public DataSet getCategoryDetails()
        {
            string str = "select * from Category_table";
            DataSet ds = conObj.Fn_Adapter(str);
            return ds;
        }

        public int EditCategoryDetails(string desc, string status, string img, int id)
        {
            string str = "update Category_table set Category_desc='" + desc + "' , Category_status='" + status+ "', Category_image='"+img+"' where Category_ID=" + id + "";
            int i = conObj.Fn_ExecuteNonQuery(str);
            return i;
        }

        public string GetImageUrl(int id)
        {
            string str="select Category_image from Category_table where Category_ID="+id+"";
            string img = conObj.Fn_ExecuteScalar(str);
            return img;
        }
    }
}
