using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace EcommerceApplication
{
    public partial class OrdersPage : System.Web.UI.Page
    {
        OrderClass orderObj = new OrderClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = orderObj.getOrderDetails();
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}