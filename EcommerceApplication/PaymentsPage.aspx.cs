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
    public partial class PaymentsPage : System.Web.UI.Page
    {
        PaymentsClass payObj = new PaymentsClass();
        AccntService.ServiceClient ob = new AccntService.ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = payObj.getOrderProductDetails(Convert.ToInt32(Session["ID"]));
                GridView1.DataSource = ds;
                GridView1.DataBind();

                string totalAmt = payObj.getGrandTotal(Convert.ToInt32(Session["ID"]));
                
                txtGrandTotal.Text = totalAmt;
            }


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            string IsAccntNoValid = ob.getAccountNumber(TextBox1.Text);
            if (IsAccntNoValid == "1")
            {
                Label1.Visible = false;
                Button2.Visible = true;
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Invalid Account number";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string i = payObj.getGrandTotal(Convert.ToInt32(Session["ID"]));
            decimal totalAmt = Convert.ToDecimal(i);
            string bal = ob.BalanceCheck(TextBox1.Text);
            decimal balanceAmt = Convert.ToDecimal(bal);
            if(balanceAmt< totalAmt)
            {
                Label2.Visible = true;
            }
            else
            {
                Label2.Visible = false;
                decimal paidbal = balanceAmt - totalAmt;
                int j = ob.UpdateBalance(TextBox1.Text, paidbal);


                string val = payObj.getTotalAmount(Convert.ToInt32(Session["ID"]));
                decimal grandTotal = Convert.ToDecimal(val);

                int value = payObj.insertToBillTable(Convert.ToInt32(Session["ID"]), grandTotal);
                if (value == 1)
                {
                    payObj.updateOrderStatus(Convert.ToInt32(Session["ID"]));
                }


                

                SqlDataReader data = payObj.getProductID(Convert.ToInt32(Session["ID"]));
                List<int> pdtId = new List<int>();
                List<int> pdtqty = new List<int>();

                while (data.Read())
                {
                    pdtId.Add(Convert.ToInt32(data["ProductID"]));
                    pdtqty.Add(Convert.ToInt32(data["OrderQty"]));
                }

                for(int z=0; z< pdtId.Count; z++)
                {
                    string x = payObj.getPdtStock(pdtId[z]);
                    int stock = Convert.ToInt32(x);
                    int balStock = stock - pdtqty[z];


                    
                    if (balStock == 0)
                    {
                        int isPdtStatusUpdated = payObj.UpdateZeroStockStatus(pdtId[z]);
                        if (isPdtStatusUpdated > 0)
                        {
                            Response.Redirect("ViewBillPage.aspx");
                        }
                    }
                    else
                    {
                        int IsStockUpdated = payObj.updateProductQty(pdtId[z], balStock);
                        if (IsStockUpdated > 0)
                        {
                            Response.Redirect("ViewBillPage.aspx");
                        }
                    }
                    
                }

            }    
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }
    }
}

