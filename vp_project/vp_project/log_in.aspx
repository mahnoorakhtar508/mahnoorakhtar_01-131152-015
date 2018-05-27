<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="log_in.aspx.cs" Inherits="vp_project.log_in" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign_in</title>
    <style type="text/css">
        #form1 {
            height: 337px;
        }
        .auto-style2 {
            font-size: x-large;
            text-align: center;
        }
    </style>
</head>
<body>
    <p class="auto-style2"> <strong>Sign in page</strong></p>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="emailTextBox" runat="server" Width="179px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailTextBox" ErrorMessage="Email Required" style="color: #FF3300"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;<asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" Width="178px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="passwordTextBox" ErrorMessage="Password required" style="color: #FF3300"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Select"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Vendor</asp:ListItem>
            <asp:ListItem>Buyer</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="loginbutton" runat="server" OnClick="loginbutton_Click" style="font-weight: 700" Text="Login" Width="70px" />
    </form>
</body>
</html>
