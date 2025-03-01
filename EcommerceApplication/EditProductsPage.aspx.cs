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
    public partial class EditProductsPage : System.Web.UI.Page
    {
        EditProductClass pdtObj = new EditProductClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_Products();
            }
        }

        public void load_Products()
        {
            DataSet ds = pdtObj.GetAllProducts();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            load_Products();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            load_Products();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getId = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtCategoryID = (TextBox)GridView1.Rows[i].FindControl("txtCategoryID");
            TextBox txtDesc = (TextBox)GridView1.Rows[i].FindControl("txtDesc");
            TextBox txtPrice = (TextBox)GridView1.Rows[i].FindControl("txtPrice");
            TextBox txtStock = (TextBox)GridView1.Rows[i].FindControl("txtStock");
            FileUpload Fl = (FileUpload)GridView1.Rows[i].FindControl("FileUpload1");
            DropDownList Dl = (DropDownList)GridView1.Rows[i].FindControl("DropDownList1");



            string img_path = "";
            if (Fl.HasFile)
            {
                img_path = "~/NewImages/" + Fl.FileName;
                Fl.SaveAs(MapPath(img_path));
            }

            else
            {
                img_path= pdtObj.GetImageUrl(getId);
            }

            int k = pdtObj.EditProductsDetails(Convert.ToInt32(txtCategoryID.Text), txtDesc.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtStock.Text), img_path, Dl.SelectedItem.Text, getId);
            if (k == 1)
            {
                GridView1.EditIndex = -1;
                load_Products();
            }
            
        }
    }
}