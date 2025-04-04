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
    public class PaymentsClass
    {
        ConnectionClass conObj = new ConnectionClass();

        public DataSet getOrderProductDetails(int userID)
        {
            string str = "select Product_name, Product_desc, Price, OrderQty, TotalAmt from Products_table join Order_Table on Products_table.Product_ID=Order_Table.ProductID where Order_Table.UserID=" + userID + " and OrderStatus='order'";
            DataSet ds = conObj.Fn_Adapter(str);
            return ds;
        }

        public string getGrandTotal(int userID)
        {
            string str="select sum(TotalAmt) from Order_Table where UserID="+ userID + " and OrderStatus='order'";
            string i = conObj.Fn_ExecuteScalar(str);
            return i;
        }


        public int updateOrderStatus(int userID)
        {
            string str = "update Order_Table set OrderStatus='paid' where UserID=" + userID + "";
            int i = conObj.Fn_ExecuteNonQuery(str);
            return i;
        }

        public SqlDataReader getProductID(int userID)
        {
            string str = "select ProductID, OrderQty from Order_Table where UserID=" + userID + " and OrderStatus='paid'";
            SqlDataReader da = conObj.Fn_ExecuteReader(str);
            return da;
        }

        public string getPdtStock(int pdtID)
        {
            string str="select Product_stock from Products_table where Product_ID="+pdtID+"";
            string i = conObj.Fn_ExecuteScalar(str);
            return i;
        }

        public int UpdateZeroStockStatus(int pdtID)
        {
            string str = "update Products_table set Product_stock=0, Product_status='unavailable' where Product_ID=" + pdtID + "";
            int i = conObj.Fn_ExecuteNonQuery(str);
            return i;
        }

        public int updateProductQty(int pdtID, int stock)
        {
            string str="update Products_table set Product_stock="+ stock + " where Product_ID="+pdtID+"";
            int i = conObj.Fn_ExecuteNonQuery(str);
            return i;
        }

        public string getTotalAmount(int userId)
        {
            string str = "select sum(TotalAmt) from Order_Table where UserID=" + userId + " and OrderStatus='order'";
            string i = conObj.Fn_ExecuteScalar(str);
            return i;

        }

        public int insertToBillTable(int userID, decimal total)
        {
            string str = "insert into Bill_Table values(" + userID + "," + total + ", '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "')";
            int i = conObj.Fn_ExecuteNonQuery(str);
            return i;
        }
    }
}
