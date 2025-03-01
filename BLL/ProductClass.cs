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
    public class ProductClass
    {
        ConnectionClass conObj = new ConnectionClass();

        public DataSet dropDownBind()
        {
            string str = "select Category_ID, Category_name from Category_table";
            DataSet ds = conObj.Fn_Adapter(str);
            return ds;
        }

        public int InsertToProductTable(int ctgryID, string pname, string pdesc, decimal price, int stock, string pdtImg, string pstatus )
        {
            string insertToPdtTable = "insert into Products_table values("+ ctgryID + ", '"+ pname + "', '"+ pdesc + "', "+ price + ", "+ stock + ", '"+ pdtImg + "', '"+ pstatus + "')";
            int isInserted = conObj.Fn_ExecuteNonQuery(insertToPdtTable);
            return isInserted;
        }
    }
}
