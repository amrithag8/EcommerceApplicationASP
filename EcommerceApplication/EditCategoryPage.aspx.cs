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
    public partial class EditCategoryPage : System.Web.UI.Page
    {
        EditCategoryClass editCatObj = new EditCategoryClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getGridDetails();
            }
        }

        public void getGridDetails()
        {
            DataSet data = editCatObj.getCategoryDetails();
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            getGridDetails();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            getGridDetails();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            TextBox txtEditDesc = (TextBox)GridView1.Rows[i].FindControl("txtEditDesc");
            FileUpload Fl = (FileUpload)GridView1.Rows[i].FindControl("FileUpload1");
            DropDownList dl = (DropDownList)GridView1.Rows[i].FindControl("DropDownList1");
            int getID = Convert.ToInt32(GridView1.DataKeys[i].Value);

            string img_path = "";
            if (Fl.HasFile)
            {
                img_path = "~/NewImages/" + Fl.FileName;
                Fl.SaveAs(MapPath(img_path));
            }
            else
            {
                img_path= editCatObj.GetImageUrl(getID);
            }
            


            
            int k = editCatObj.EditCategoryDetails(txtEditDesc.Text, dl.SelectedItem.Text, img_path, getID);
            if (k == 1)
            {
                GridView1.EditIndex = -1;
                getGridDetails();
            }



        }
    }
}