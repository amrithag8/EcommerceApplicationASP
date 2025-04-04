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
    public partial class ViewFeedbackPage : System.Web.UI.Page
    {
        ViewFeedbackClass fbobj = new ViewFeedbackClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = fbobj.getFeedbackDetails();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow rw = GridView1.Rows[e.NewSelectedIndex];
            
            int id = Convert.ToInt32(rw.Cells[2].Text);
            int fid = Convert.ToInt32(rw.Cells[1].Text);
            Response.Redirect("feedbackReplyPage.aspx?user="+id+"&feedbackId="+fid+"");

        }
    }
}