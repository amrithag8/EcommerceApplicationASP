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
    public partial class ViewProductDetails : System.Web.UI.Page
    {
        ProductDetailsClass pdtDetailsObj = new ProductDetailsClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["ProductID"]);
            SqlDataReader data = pdtDetailsObj.getProductDetails(id);
            while (data.Read())
            {
                pdtName.Text = data["Product_name"].ToString();
                pdtDesc.Text = data["Product_desc"].ToString();
                pdtPrice.Text = data["Price"].ToString();
                Image1.ImageUrl = data["Product_image"].ToString();
            }
        }
    }
}