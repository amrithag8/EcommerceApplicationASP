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
   public class OrderClass
    {
        ConnectionClass conObj = new ConnectionClass();

        public DataSet getOrderDetails()
        {
            string str = "select * from Order_Table";
            DataSet ds = conObj.Fn_Adapter(str);
            return ds;

        }
    }
}
