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

        public string GetProductQty(int id)
        {
            string getPdtID = "select Product_stock from Products_table where Product_ID=" + id + "";
            string i = conObj.Fn_ExecuteScalar(getPdtID);
            return i;
        }

        public int generateID()
        {
                string MaxVal = "select max(Cart_ID) from Cart_table";
                int cartID = 0;
                string ID = conObj.Fn_ExecuteScalar(MaxVal);
                if (ID == "")
                {
                    cartID = 1;
                }
                else
                {
                cartID = Convert.ToInt32(ID) + 1;
                }
                return cartID; 
        }

        public string getPdtPrice(int id)
        {
            string getPrice = "select Price from Products_table where Product_ID=" + id + "";
            string Price = conObj.Fn_ExecuteScalar(getPrice);
            return Price;
        }

        public int insertValuesToCartTable(int id, int userId, int pdtId, int qty, decimal total)
        {
            string insertVal = "insert into Cart_table values("+id+","+ userId + ","+ pdtId + ", "+qty+", "+total+", '"+DateTime.Now.Date.ToString("yyyy-MM-dd")+ "')";
            int i = conObj.Fn_ExecuteNonQuery(insertVal);
            return i;
        }

        public string checkInCartTable(int pdtid, int userid)
        {
            string str="select Quantity from Cart_table where ProductID="+ pdtid + " and UserID="+ userid + "";
            string i = conObj.Fn_ExecuteScalar(str);
            return i;
            
        }

        
        //public int updateCartTable(int pdtid, int userID, int qty, decimal subtotal)
        //{
        //    string str = "update Cart_table set Quantity=" + qty + ", SubTotal=" + subtotal + " where ProductID=" + pdtid + " and UserID=" + userID + "";
        //    int i = conObj.Fn_ExecuteNonQuery(str);
        //    return i;

        //}
    }
}
