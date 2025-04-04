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
    public class UserHomeClass
    {
        ConnectionClass conObj = new ConnectionClass();
        public DataSet GetAllcategory()
        {
            string selectCategoryDetails="select * from Category_table where Category_status='available'";
            DataSet ds = conObj.Fn_Adapter(selectCategoryDetails);
            return ds;
        }

        public DataSet getAllProducts(int categoryID)
        {
            string getProducts = "select * from Products_table where Category_ID=" + categoryID + " and Product_status='available'";
            DataSet ds = conObj.Fn_Adapter(getProducts);
            return ds;
        }

        public DataSet getSearchedProduct(string productName)
        {
            string PdtName = productName.ToLower();
            string searchedProduct = "select * from Products_table where LOWER(Product_name) like '%" + PdtName + "%' ";
            DataSet ds = conObj.Fn_Adapter(searchedProduct);
            return ds;
        }
    }
}
