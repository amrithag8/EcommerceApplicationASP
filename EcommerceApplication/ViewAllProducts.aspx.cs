﻿using System;
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
    public partial class ViewAllProducts : System.Web.UI.Page
    {
        UserHomeClass userHomeObj = new UserHomeClass();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if(Session["searchInput"]!= null)
                {
                    DataSet ds = userHomeObj.getSearchedProduct(Session["searchInput"].ToString());
                    DataList1.DataSource = ds;
                    DataList1.DataBind();
                    TextBox searchbar=(TextBox) Master.FindControl("inputSearch");
                    searchbar.Text = "";
                    Session["searchInput"] = null;
                }

                else
                {
                    int id = Convert.ToInt32(Session["Category_ID"]);
                    DataSet data = userHomeObj.getAllProducts(id);
                    DataList1.DataSource = data;
                    DataList1.DataBind();
                }

               
            }

        }

       
        

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            
            Session["ProductID"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("ViewProductDetails.aspx");
        }
    }
}