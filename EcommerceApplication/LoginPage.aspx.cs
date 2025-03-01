using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace EcommerceApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        LoginClass logObj = new LoginClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string isLogin = logObj.Fn_Login(txtUsername.Text, txtPassword.Text);
            if (isLogin == "1")
            {
                string Regid=logObj.GetRegId(txtUsername.Text, txtPassword.Text);
                int id = Convert.ToInt32(Regid);
                if (id > 0)
                {
                    Session["ID"] = id;
                    string logType = logObj.getLogType(txtUsername.Text, txtPassword.Text);
                    if (logType == "admin")
                    {
                        Response.Redirect("AdminHomePage.aspx");
                    }
                    else if(logType == "user")
                    {
                        Response.Redirect("UserHomePage.aspx");
                    }
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Invalid username/password";
                }
                
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Invalid username/password";
            }
        }
    }
}