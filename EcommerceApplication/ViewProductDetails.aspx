<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewProductDetails.aspx.cs" Inherits="EcommerceApplication.ViewProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
        .auto-style2 {
            width: 412px;
        }
        .auto-style3 {
            text-align: center;
            width: 412px;
        }
        .auto-style4 {
            height: 27px;
            width: 412px;
        text-align: left;
    }
        .auto-style5 {
            width: 69px;
        }
        .auto-style6 {
            height: 27px;
            width: 69px;
        }
        .auto-style7 {
            font-size: x-large;
        }
    .auto-style8 {
        text-align: center;
        width: 412px;
        height: 27px;
    }
    .auto-style9 {
        height: 27px;
        text-align: center;
        width: 283px;
    }
    .auto-style10 {
        width: 283px;
    }
    .auto-style11 {
        height: 27px;
        width: 283px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="pdtName" runat="server" CssClass="auto-style7" Font-Bold="True" Text="Label"></asp:Label>
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style4">
                <asp:Image ID="Image1" runat="server" Height="398px" Width="439px" />
            </td>
            <td class="auto-style9">
                <asp:Button ID="Button2" runat="server" Height="35px" PostBackUrl="~/ViewAllProducts.aspx" Text="BACK TO PRODUCTS" Width="163px" />
            </td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="pdtDesc" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="pdtPrice" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="text-center">
                <asp:Button ID="Button1" runat="server" BorderColor="#0066FF" ForeColor="Black" OnClick="Button1_Click" Text="ADD TO CART" />
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Height="35px" Width="79px">
                </asp:DropDownList>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Gray" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style8">
                <asp:Label ID="Label1" runat="server" ForeColor="#CC0000" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style11"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="Button3" runat="server" Text="GO TO CART" Visible="False" BorderColor="#3366FF" Font-Bold="True" ForeColor="Black" PostBackUrl="~/ViewCart.aspx" />
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style8">
                </td>
            <td class="auto-style11"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
