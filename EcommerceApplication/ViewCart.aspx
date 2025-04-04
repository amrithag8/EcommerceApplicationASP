<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="EcommerceApplication.ViewCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: left;
            font-size: x-large;
        }
        .auto-style2 {
            width: 359px;
        }
        .auto-style3 {
            text-align: center;
            font-size: x-large;
            width: 359px;
        }
        .auto-style4 {
            text-align: center;
            width: 359px;
        }
        .auto-style5 {
            width: 359px;
            height: 27px;
        }
        .auto-style6 {
            height: 27px;
        }
        .auto-style7 {
            width: 359px;
            height: 28px;
        }
        .auto-style8 {
            text-align: center;
            height: 28px;
        }
        .auto-style9 {
            width: 498px;
        }
        .auto-style10 {
            text-align: left;
            font-size: x-large;
            width: 498px;
        }
        .auto-style11 {
            text-align: center;
            width: 498px;
        }
        .auto-style12 {
            height: 27px;
            width: 498px;
        }
        .auto-style13 {
            text-align: right;
            height: 28px;
            width: 498px;
        }
        .auto-style14 {
            height: 27px;
            width: 498px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style10"><strong>View cart</strong></td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style11">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Product_ID" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                    <Columns>
                        <asp:BoundField DataField="Product_name" HeaderText="Product Name" />
                        <asp:BoundField DataField="Price" HeaderText="Price" />
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                        <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" />
                        <asp:ImageField DataImageUrlField="Product_image" HeaderText="Image">
                            <ControlStyle Height="100px" Width="100px" />
                        </asp:ImageField>
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                        <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
            <td class="text-center">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style12"></td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style14">
                <asp:Label ID="Label1" runat="server" Text="Your order items are ready. Continue with your payment NOW." Visible="False"></asp:Label>
                <asp:Button ID="Button2" runat="server" PostBackUrl="~/PaymentsPage.aspx" Text="GO TO PAYMENTS PAGE" Visible="False" />
            </td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style13">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm and order" />
            </td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
