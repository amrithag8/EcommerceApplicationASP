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
    public partial class UserHomePage : System.Web.UI.Page
    {
        UserHomeClass userhomeObj = new UserHomeClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet data = userhomeObj.GetAllcategory();
                DataList1.DataSource = data;
                DataList1.DataBind();
            }
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            
            Session["Category_ID"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("ViewAllProducts.aspx");
        }
    }
}