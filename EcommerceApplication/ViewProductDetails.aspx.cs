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
    public partial class ViewProductDetails : System.Web.UI.Page
    {
        ProductDetailsClass pdtDetailsObj = new ProductDetailsClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int id = Convert.ToInt32(Session["ProductID"]);
                SqlDataReader data = pdtDetailsObj.getProductDetails(id);
                while (data.Read())
                {
                    pdtName.Text = data["Product_name"].ToString();
                    pdtDesc.Text = data["Product_desc"].ToString();
                    pdtPrice.Text = data["Price"].ToString();
                    Image1.ImageUrl = data["Product_image"].ToString();
                }

                //DropDownList binding values 1 to 50

                DropDownList2.Items.Insert(0, "--Qty--");

                for (int i=1; i<=50; i++)
                {
                    
                    DropDownList2.Items.Add(i.ToString());
                    
                }

                //Show GO TO CART button instead of ADD TO CART button if pdt is already added to cart.

                string k = pdtDetailsObj.checkInCartTable(id, Convert.ToInt32(Session["ID"]));
                if (k != null)
                {
                    Label2.Visible = true;
                    Label2.Text = "Added to cart &#9989;";
                    DropDownList2.Visible = false;
                    Button1.Visible = false;
                    Button3.Visible = true;
                }
            }
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string qty = pdtDetailsObj.GetProductQty(Convert.ToInt32(Session["ProductID"]));
            int qtyVal = Convert.ToInt32(qty);
            if (DropDownList2.SelectedItem.Text != "--Qty--")
            {
                int selectedVal = Convert.ToInt32(DropDownList2.SelectedItem.Text);
                if (selectedVal > qtyVal)
                {
                    Label1.Visible = true;
                    Label1.Text = "Selected quantity is not available in the stock";
                }
                else
                {
                    Label1.Visible = false;
                    


                }
            }
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Label1.Visible == false && DropDownList2.SelectedItem.Text != "--Qty--") 
            {
                int maxCartID = pdtDetailsObj.generateID();
                int userID = Convert.ToInt32(Session["ID"]);
                int pdtID = Convert.ToInt32(Session["ProductID"]);
                int qty = Convert.ToInt32(DropDownList2.SelectedItem.Text);
                string pdtPrice = pdtDetailsObj.getPdtPrice(pdtID);
                decimal subtotal = Convert.ToDecimal(pdtPrice) * qty;

                
                    int i = pdtDetailsObj.insertValuesToCartTable(maxCartID, userID, pdtID, qty, subtotal);

                    if (i == 1)
                    {
                        Label2.Visible = true;
                        Label2.Text = "Added to cart &#9989;";
                        DropDownList2.Visible = false;
                        Button1.Visible = false;
                        Button3.Visible = true;
                    }
                
                
              



            }
        }
    }
}