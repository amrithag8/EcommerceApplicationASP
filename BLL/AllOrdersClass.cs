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
    public class AllOrdersClass
    {
        ConnectionClass obj = new ConnectionClass();
        public DataSet getAllPaidOrders()
        {
            string str= "select OrderID, ProductID, TotalAmt, OrderQty, OrderStatus, UserID, GrandTotal, User_ID, Date from Order_Table join Bill_Table on Order_Table.UserID=Bill_Table.User_ID where Order_Table.OrderStatus='paid'";
            DataSet ds = obj.Fn_Adapter(str);
            return ds;
        }

        public int updateOrderTable(string status, int orderID)
        {
            string str="update Order_Table set OrderStatus='"+status+"' where OrderID="+orderID+"";
            int i = obj.Fn_ExecuteNonQuery(str);
            return i;
        }
    }
}
