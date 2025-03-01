<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminRegisterPage.aspx.cs" Inherits="EcommerceApplication.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
        .auto-style2 {
            font-size: large;
            width: 103px;
            height: 43px;
        }
        .auto-style3 {
            font-size: 16px;
            width: 12px;
        }
        .auto-style6 {
            height: 27px;
            width: 358px;
        }
        .auto-style7 {
            width: 358px;
        }
        .auto-style8 {
            height: 27px;
            width: 103px;
        }
        .auto-style9 {
            width: 103px;
        }
        .auto-style10 {
            width: 358px;
            font-size: large;
            height: 43px;
        }
        .auto-style14 {
            width: 358px;
            text-align: center;
        }
        .auto-style16 {
            height: 43px;
        }
        .auto-style17 {
            height: 27px;
            width: 12px;
        }
        .auto-style18 {
            height: 43px;
            width: 12px;
        }
        .auto-style19 {
            width: 12px;
        }
        .auto-style20 {
            width: 103px;
            text-align: center;
        }
    .auto-style21 {
        height: 27px;
        width: 358px;
        text-align: center;
    }
        .auto-style22 {
            height: 30px;
        }
        .auto-style23 {
            font-size: 16px;
            width: 12px;
            height: 30px;
        }
        .auto-style24 {
            width: 103px;
            text-align: center;
            height: 30px;
        }
        .auto-style25 {
            width: 358px;
            text-align: center;
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
    <tr>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
        <td class="auto-style17"></td>
        <td class="auto-style8"></td>
        <td class="auto-style6"></td>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
    </tr>
    <tr>
        <td class="auto-style16"></td>
        <td class="auto-style16"></td>
        <td class="auto-style16"></td>
        <td class="auto-style18"></td>
        <td class="auto-style2"></td>
        <td class="auto-style10"><strong>ADMIN REGISTRATION</strong></td>
        <td class="auto-style16"></td>
        <td class="auto-style16"></td>
        <td class="auto-style16"></td>
        <td class="auto-style16"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style19">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style22"></td>
        <td class="auto-style22"></td>
        <td class="auto-style22"></td>
        <td class="auto-style23"></td>
        <td class="auto-style24">Admin Name</td>
        <td class="auto-style25">
            <asp:TextBox ID="txtadminName" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style22"></td>
        <td class="auto-style22"></td>
        <td class="auto-style22"></td>
        <td class="auto-style22"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style19">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style14">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtadminName" ErrorMessage="Name field is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style20">Admin Email</td>
        <td class="auto-style14">
            <asp:TextBox ID="txtadminEmail" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
        <td class="auto-style17"></td>
        <td class="auto-style8"></td>
        <td class="auto-style21">
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtadminEmail" ErrorMessage="Email is not valid" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style20">Admin Phone</td>
        <td class="auto-style14">
            <asp:TextBox ID="txtadminPhone" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style19">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style14">
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtadminPhone" ErrorMessage="Phone number must be valid" ForeColor="#CC0000" ValidationExpression="^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$"></asp:RegularExpressionValidator>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style20">Username</td>
        <td class="auto-style14">
            <asp:TextBox ID="txtadminUsername" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style19">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style14">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtadminUsername" ErrorMessage="Username is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style20">Password</td>
        <td class="auto-style14">
            <asp:TextBox ID="txtadminPassword" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style19">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style14">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtadminPassword" ErrorMessage="Password is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style14">
            <asp:Button ID="btnAdminRegister" runat="server" Text="REGSITER" OnClick="Button1_Click" />
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
        <td class="auto-style17"></td>
        <td class="auto-style8"></td>
        <td class="auto-style6"></td>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
        <td class="auto-style1"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style19">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style14">
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style19">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style19">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style19">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style19">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
