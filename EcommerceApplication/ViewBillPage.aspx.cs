using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;

namespace EcommerceApplication
{
    public partial class ViewBillPage : System.Web.UI.Page
    {
        ViewBillClass billObj = new ViewBillClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlDataReader data = billObj.getUserOrderBillDetails(Convert.ToInt32(Session["ID"]));
                string billNo = "BLL";
                if (data.HasRows)
                {


                    if (data.Read())
                    {
                        lblName.Text = data["user_name"].ToString();
                        lblAddress.Text = data["user_address_line1"].ToString();
                        lblPlace.Text = data["user_city"].ToString();
                        lblBillNo.Text = billNo + data["Bill_ID"].ToString();
                        lblBillDate.Text = data["Date"].ToString();

                        lblTotalAmt.Text = data["GrandTotal"].ToString();
                    }

                }
                

                DataSet ds = billObj.getOrderProductDetails(Convert.ToInt32(Session["ID"]));
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }

        }
    }
}