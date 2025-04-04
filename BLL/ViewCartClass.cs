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
    public class ViewCartClass
    {
        ConnectionClass conObj = new ConnectionClass();

        public DataSet getCartDetails(int id)
        {
            string str = "select Product_ID, Product_name, Price, Quantity, SubTotal, Cart_ID, Product_image from Products_table join Cart_table on Products_table.Product_ID=Cart_table.ProductID where Cart_table.UserID=" + id + "";
            DataSet ds = conObj.Fn_Adapter(str);
            return ds;
        }

        public int deleteFromCartTable(int id)
        {
            string str = "delete from Cart_table where ProductID=" + id + "";
            int i = conObj.Fn_ExecuteNonQuery(str);
            return i;

        }

        public int updateCartTable(int qty, decimal total, int id)
        {
            string str = "update Cart_table set Quantity=" + qty + ", SubTotal=" + total + " where ProductID=" + id + "";
            int k = conObj.Fn_ExecuteNonQuery(str);
            return k;

        }

        public string getPriceOfProduct(int id)
        {
            string str = "select Price from Products_table where Product_ID=" + id + "";
            string i = conObj.Fn_ExecuteScalar(str);
            return i;
        }

        public string getMaxOfCartID(int userid)
        {
            string str = "select max(Cart_ID) from Cart_table where UserID=" + userid + "";
            string i = conObj.Fn_ExecuteScalar(str);
            return i;
        }

        public SqlDataReader getOrderDetails(int cartID, int userID)
        {
            string str1 = "select * from Cart_table where Cart_ID=" + cartID + " and UserID=" + userID + "";
            SqlDataReader dr = conObj.Fn_ExecuteReader(str1);
            return dr;
        }

        public string checkInOrderTable(int pdid, int userID)
        {
            string str = "select OrderQty from Order_Table where OrderStatus='order' and UserID=" + userID + " and ProductID=" + pdid + "";
            string i = conObj.Fn_ExecuteScalar(str);
            return i;
        }

        public int updateOrderTable(int pdid, int userID, int qty, decimal subtotal)
        {
            string str = "update Order_Table set OrderQty=" + qty + ", TotalAmt=" + subtotal + " where OrderStatus='order' and UserID=" + userID + " and ProductID=" + pdid + "";
            int i = conObj.Fn_ExecuteNonQuery(str);
            return i;

        }

        public int inserTToOrderTable(int userID, int pdtID, decimal Amount, int qty)
        {
            string str = "insert into Order_Table values(" + userID + "," + pdtID + "," + Amount + "," + qty + ",'order')";
            int i = conObj.Fn_ExecuteNonQuery(str);
            return i;
        }

        public int deleteFromCartTable(int userID, int cartID)
        {
            string str = "delete from Cart_table where UserID=" + userID + " and Cart_ID=" + cartID + " ";
            int i = conObj.Fn_ExecuteNonQuery(str);
            return i;
        }

        //public string getTotalAmount(int userId)
        //{
        //    string str = "select sum(TotalAmt) from Order_Table where UserID=" + userId + " and OrderStatus='order'";
        //    string i = conObj.Fn_ExecuteScalar(str);
        //    return i;

        //}

        //public int insertToBillTable(int userID, decimal total)
        //{
        //    string str = "insert into Bill_Table values(" + userID + "," + total + ", '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "')";
        //    int i = conObj.Fn_ExecuteNonQuery(str);
        //    return i;
        //}

        public string checkIfOrderItems(int userID)
        {
            string str = "select count(OrderID) from Order_Table where OrderStatus='order'";
            string i = conObj.Fn_ExecuteScalar(str);
            return i;
        }

        
    }
}
