using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace EcommerceApplication
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        UserHomeClass userObj = new UserHomeClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.Url.AbsolutePath.Contains("ViewAllProducts.aspx"))
            {
                searchDiv.Visible = false;
            }

            if (!Request.Url.AbsolutePath.Contains("AdminHomePage.aspx")&& !Request.Url.AbsolutePath.Contains("AddProduct.aspx")
                && !Request.Url.AbsolutePath.Contains("AddCategory.aspx")&& !Request.Url.AbsolutePath.Contains("EditCategoryPage.aspx")
                && !Request.Url.AbsolutePath.Contains("EditProductsPage.aspx")&& !Request.Url.AbsolutePath.Contains("AllOrdersPage.aspx")
                && !Request.Url.AbsolutePath.Contains("ViewFeedbackPage.aspx"))
            {
                viewFeedbackid.Visible = false;
            }

            if (!Request.Url.AbsolutePath.Contains("UserHomePage.aspx"))
            {
                feedbackID.Visible = false;
            }
        }

        protected void searchProduct(object sender, EventArgs e)
        {
             
            
            if (!string.IsNullOrEmpty(inputSearch.Text))
            {
                Session["searchInput"] = inputSearch.Text;
                inputSearch.Text = null;
                Response.Redirect("ViewAllProducts.aspx");
            }

        }
        }
}