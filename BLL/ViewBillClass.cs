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
    public class ViewBillClass
    {
        ConnectionClass conObj = new ConnectionClass();

        public SqlDataReader getUserOrderBillDetails(int id)
        {
            string str = "select OrderID, user_name, user_address_line1, user_city, Bill_ID, GrandTotal, Date from Order_Table join User_table on Order_Table.UserID = User_Table.user_id join Bill_Table on Bill_Table.User_ID = User_Table.user_id where Order_Table.OrderStatus='paid' and Order_Table.UserID=" + id+"";
            SqlDataReader ds = conObj.Fn_ExecuteReader(str);
            return ds;
        }

        public DataSet getOrderProductDetails(int userID)
        {
            string str = "select Product_name, Product_desc, Price, OrderQty, TotalAmt from Products_table join Order_Table on Products_table.Product_ID=Order_Table.ProductID where Order_Table.UserID="+userID+" and OrderStatus='paid'";
            DataSet ds = conObj.Fn_Adapter(str);
            return ds;
        }
    }
}
