using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace EcommerceApplication
{
    public partial class FeedbackReplyPage : System.Web.UI.Page
    {
        FeedbackRplyClass fdbckObj = new FeedbackRplyClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox2.Text = "Reply from Ecom";
            int id = Convert.ToInt32(Request.QueryString["user"]);
            SqlDataReader i = fdbckObj.getUserEmail(id);
            while (i.Read())
            {
                TextBox1.Text = i["user_email"].ToString();
                TextBox4.Text = i["user_name"].ToString();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int j = fdbckObj.updateRplyMsg(Convert.ToInt32(Request.QueryString["feedbackID"]), TextBox3.Text);
            if (j == 1)
            {
                string k = fdbckObj.getAdminEmail(Convert.ToInt32(Session["ID"]));

                sendEmail(k, TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, "qhpw ruen evwq gtvl");
                Label1.Visible = true;
                Label1.Text = "email sent";
            }
            
        }

        public static void sendEmail(string receiverEmail, string receiverName, string sendEmail, string subject, string mailBody, string pass)
        {
            string to = sendEmail; //To address    
            string from = receiverEmail; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailStartContent = "Hello"+" "+ receiverName+","+" "+"Thank You for your valuable feedback";
            message.Subject = subject;
            message.Body = mailStartContent+" "+ mailBody;
            //message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(receiverEmail, pass);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            client.Send(message);
        }
    }
}