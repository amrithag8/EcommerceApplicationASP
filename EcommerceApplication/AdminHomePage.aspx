<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="EcommerceApplication.AdminHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 215px;
        }
        .auto-style2 {
            text-align: left;
            width: 215px;
            height: 27px;
        }
        .auto-style3 {
            height: 27px;
        }
        .auto-style4 {
            width: 215px;
            height: 27px;
        }
        .auto-style5 {
            width: 204px;
        }
        .auto-style6 {
            width: 204px;
            height: 27px;
        }
        .auto-style7 {
            width: 200px;
        }
        .auto-style8 {
            width: 200px;
            height: 27px;
        }
        .auto-style9 {
            width: 194px;
        }
        .auto-style10 {
            width: 194px;
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="114px" ImageUrl="~/assets/images.jpg" PostBackUrl="~/AddCategory.aspx" Width="112px" />
            </td>
            <td class="auto-style5">
                <asp:ImageButton ID="ImageButton2" runat="server" Height="114px" ImageUrl="~/assets/editCategory.png" Width="112px" PostBackUrl="~/EditCategoryPage.aspx" />
            </td>
            <td class="auto-style7">
                <asp:ImageButton ID="ImageButton3" runat="server" Height="114px" ImageUrl="~/assets/addProduct.png" Width="112px" PostBackUrl="~/AddProduct.aspx" />
            </td>
            <td class="auto-style9">
                <asp:ImageButton ID="ImageButton4" runat="server" Height="114px" ImageUrl="~/assets/editProducts.png" Width="112px" PostBackUrl="~/EditProductsPage.aspx" />
            </td>
            <td>
                <asp:ImageButton ID="ImageButton5" runat="server" Height="114px" ImageUrl="~/assets/ordersicon.jpg" PostBackUrl="~/AllOrdersPage.aspx" Width="112px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/AddCategory.aspx">Add Category</asp:LinkButton>
            </td>
            <td class="auto-style6">
                <asp:LinkButton ID="LinkButton2" runat="server">Edit Category</asp:LinkButton>
            </td>
            <td class="auto-style8">
                <asp:LinkButton ID="LinkButton3" runat="server">Add Products</asp:LinkButton>
            </td>
            <td class="auto-style10">
                <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/AddProduct.aspx">Edit Products</asp:LinkButton>
            </td>
            <td class="auto-style3">All Orders</td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
            <td class="auto-style6"></td>
            <td class="auto-style8"></td>
            <td class="auto-style10"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
