<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="vp_project.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>home page</title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>Home Page </strong>
    
    </div>
        <a href="#"> Home</a> | <a href ="sign_up.aspx" >Sign_Up</a>
        <p>
            <strong>Username</strong></p>
        <p>
            <asp:TextBox ID="usernameTextBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <strong>Password</strong><p>
            <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
        </p>
      
        
    </form>
</body>
</html>
