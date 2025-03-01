using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace EcommerceApplication
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        CategoryClass catObj = new CategoryClass();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filename = "~/NewImages/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(filename));

            int Isinserted = catObj.insertIntoCategoryTable(txtCgryName.Text, filename, txtCgryDesc.Text);
            if (Isinserted == 1)
            {
                Label1.Visible = true;
                Label1.Text = "New category added";
            }
            

        }
    }
}