using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace EcommerceApplication
{
    public partial class FeedbackPage : System.Web.UI.Page
    {
        FeedbackClass fbObj = new FeedbackClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int k = fbObj.enterIntoTable(Convert.ToInt32(Session["ID"]), TextBox1.Text);
            if (k == 1)
            {
                Label1.Visible = true;
                Label1.Text = "Added Feedback";
            }
        }
    }
}