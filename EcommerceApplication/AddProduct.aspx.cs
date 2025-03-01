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
    public partial class AddProduct : System.Web.UI.Page
    {
        ProductClass pdtObj = new ProductClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = pdtObj.dropDownBind();
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Category_name";
                DropDownList1.DataValueField = "Category_ID";
                DropDownList1.DataBind();
                
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string item = "~/NewImages/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(item));

            int isInsertedtotable = pdtObj.InsertToProductTable(Convert.ToInt32(DropDownList1.SelectedItem.Value), txtPdtName.Text, txtPdtDesc.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtPdtStock.Text), item, "available");
            if (isInsertedtotable == 1)
            {
                Label1.Visible = true;
                Label1.Text = "New product added";
                txtPdtName.Text = "";
            }
        }
    }
}