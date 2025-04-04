<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewBillPage.aspx.cs" Inherits="EcommerceApplication.ViewBillPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        font-size: large;
        text-align: center;
        width: 54px;
    }
    .auto-style2 {
        font-size: large;
        width: 54px;
    }
    .auto-style3 {
        font-size: medium;
            width: 472px;
        }
    .auto-style5 {
        height: 27px;
    }
        .auto-style8 {
            font-size: large;
            text-align: center;
            width: 472px;
        }
        .auto-style9 {
            width: 472px;
        }
        .auto-style10 {
            height: 27px;
            width: 472px;
        }
        .auto-style11 {
            width: 54px;
        }
        .auto-style12 {
            height: 27px;
            width: 54px;
        }
        .auto-style13 {
            text-align: center;
            width: 54px;
        }
        .auto-style14 {
            width: 472px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style8"><strong>View Bill</strong></td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5"></td>
        <td class="auto-style12"></td>
        <td class="auto-style10"></td>
        <td class="auto-style5"></td>
        <td class="auto-style5"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3"><strong>Invoice/Bill</strong></td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9"><strong>Shipping Address</strong></td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9">
            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9">
            <asp:Label ID="lblAddress" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9"><strong>Place of Delivery:</strong>
            <asp:Label ID="lblPlace" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9"><strong>Invoice Number:</strong>
            <asp:Label ID="lblBillNo" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9"><strong>Invoice Date</strong>:<asp:Label ID="lblBillDate" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5"></td>
        <td class="auto-style12"></td>
        <td class="auto-style10"></td>
        <td class="auto-style5"></td>
        <td class="auto-style5"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style13">
            &nbsp;</td>
        <td class="auto-style14">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Product_name" HeaderText="Product Name" />
                    <asp:BoundField DataField="Product_desc" HeaderText="Description" />
                    <asp:BoundField DataField="Price" HeaderText="Unit Price" />
                    <asp:BoundField DataField="OrderQty" HeaderText="Quantity" />
                    <asp:BoundField DataField="TotalAmt" HeaderText="Total Amount" />
                </Columns>
            </asp:GridView>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9">Total Amount Paid:
            <asp:Label ID="lblTotalAmt" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
