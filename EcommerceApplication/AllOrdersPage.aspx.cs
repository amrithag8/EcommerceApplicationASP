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
    public partial class AllOrdersPage : System.Web.UI.Page
    {
        AllOrdersClass orderObj = new AllOrdersClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid_bind();
            }

        }

        public void grid_bind()
        {
            DataSet ds = orderObj.getAllPaidOrders();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            grid_bind();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            grid_bind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getID = Convert.ToInt32(GridView1.DataKeys[i].Value);
            DropDownList dlist = (DropDownList)GridView1.Rows[i].FindControl("dlist");
            int k = orderObj.updateOrderTable(dlist.Text, getID);
            if (k == 1)
            {
                GridView1.EditIndex = -1;
                grid_bind();

            }

        }
    }
}