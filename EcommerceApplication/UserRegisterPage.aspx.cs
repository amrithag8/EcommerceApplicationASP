using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace EcommerceApplication
{
    public partial class UserRegisterPage : System.Web.UI.Page
    {
        RegistrationClass regObj = new RegistrationClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int regID = regObj.FindRegID();
            int registered = regObj.InsertIntoUserTable(regID, txtUserName.Text, Convert.ToInt32(txtUserAge.Text), txtUserEmail.Text, txtUserPhone.Text, txtAddress.Text, txtUserCity.Text, DropDownList1.SelectedItem.Text, txtUserPin.Text, "active");
            if (registered == 1)
            {
                int setToLoginTab = regObj.InserIntoLoginTable(regID, txtUser.Text, txtPass.Text, "user");
                if (setToLoginTab == 1)
                {
                    Label1.Visible = true;
                    Label1.Text = "Registered";
                }
            }
        }
    }
}