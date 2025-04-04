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
    public partial class ViewCart : System.Web.UI.Page
    {
        ViewCartClass viewObj = new ViewCartClass();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Bind_Data();
            }
            

        }

        public void Bind_Data()
        {
            DataSet data = viewObj.getCartDetails(Convert.ToInt32(Session["ID"]));
            GridView1.DataSource = data;
            GridView1.DataBind();
            if (GridView1.Rows.Count == 0)
            {
                string i = viewObj.checkIfOrderItems(Convert.ToInt32(Session["ID"]));
                int j = Convert.ToInt32(i);
                if ( j>0){
                    Button2.Visible = true;
                    Label1.Visible = true;
                    Button1.Visible = false;
                }
                else
                {
                    Button1.Visible = false;
                    Button2.Visible = false;
                    Label1.Visible = false;
                }
                
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getID = Convert.ToInt32(GridView1.DataKeys[i].Value);
            
            int k = viewObj.deleteFromCartTable(getID);
            if (k == 1)
            {
                Bind_Data();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind_Data();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Bind_Data();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getID = Convert.ToInt32(GridView1.DataKeys[i].Value);

            TextBox qtyDl = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
            string z = viewObj.getPriceOfProduct(getID);
            


            decimal newStock=Convert.ToDecimal(z) * Convert.ToInt32(qtyDl.Text);

            int k = viewObj.updateCartTable(Convert.ToInt32(qtyDl.Text), newStock, getID);


            if (k == 1)
            {
                GridView1.EditIndex = -1;
                Bind_Data();
            }

            




        }

        //Confirm and order button in view cart page
        protected void Button1_Click(object sender, EventArgs e)
        {
            string i = viewObj.getMaxOfCartID(Convert.ToInt32(Session["ID"]));
            int maxCartID = Convert.ToInt32(i);
           for(int k=1; k<= maxCartID; k++)
            {
                SqlDataReader data = viewObj.getOrderDetails(k, Convert.ToInt32(Session["ID"]));
                int User = 0;
                int pdtID = 0;
                int orderQty = 0;
                decimal totalAmt = 0;

                while (data.Read())
                {
                    User = Convert.ToInt32(data["UserID"]);
                    pdtID=Convert.ToInt32(data["ProductID"]);
                    orderQty = Convert.ToInt32(data["Quantity"]);
                    totalAmt = Convert.ToDecimal(data["SubTotal"]);

                }


                    if (User != 0)
                {
                    string j = viewObj.checkInOrderTable(pdtID, User);
                    if (j != null && j != "")
                    {
                        int qty = Convert.ToInt32(j) + orderQty;
                        decimal SubTotal = (totalAmt / orderQty) * qty;
                        viewObj.updateOrderTable(pdtID, User, qty, SubTotal);

                    }
                    else
                    {
                        viewObj.inserTToOrderTable(User, pdtID, totalAmt, orderQty);
                    }
                    
                    viewObj.deleteFromCartTable(User, k);
                    
                    
                }
   
            }
            Response.Redirect("PaymentsPage.aspx");
        }
    }
}