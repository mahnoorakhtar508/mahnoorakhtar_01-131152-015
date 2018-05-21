<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sign_up.aspx.cs" Inherits="vp_project.sign_up" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 372px;
        }
        .auto-style1 {
            width: 100%;
            height: 226px;
        }
        .auto-style2 {
            width: 173px;
            text-align: right;
        }
        .auto-style6 {
            width: 173px;
            text-align: right;
            height: 45px;
        }
        .auto-style7 {
            height: 45px;
        }
        .auto-style8 {
            width: 173px;
            text-align: right;
            height: 28px;
        }
        .auto-style9 {
            height: 28px;
        }
        .auto-style10 {
            width: 361px;
        }
        .auto-style11 {
            height: 45px;
            width: 361px;
        }
        .auto-style12 {
            height: 28px;
            width: 361px;
        }
        .auto-style13 {
            width: 100%;
            height: 54px;
        }
        .auto-style14 {
            font-size: xx-large;
            text-align: center;
        }
    </style>
</head>
<body>
    <table class="auto-style13">
        <tr>
            <td class="auto-style14"><strong>Registration</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td id="first_nametext" class="auto-style2">First-name:</td>
                <td class="auto-style10">
                    <asp:TextBox ID="first_nameTextBox" runat="server" Width="163px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="first_nameTextBox" ErrorMessage="First name is required" style="color: #FF3300"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Last-name:</td>
                <td class="auto-style10">
                    <asp:TextBox ID="last_nameTextBox" runat="server" Width="160px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="last_nameTextBox" ErrorMessage="last name is required" style="color: #FF3300"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Email:</td>
                <td class="auto-style10">
                    <asp:TextBox ID="emailTextBox" runat="server" Width="158px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="emailTextBox" ErrorMessage="email is required" style="color: #FF3300"></asp:RequiredFieldValidator>
&nbsp;
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailTextBox" ErrorMessage="invalid email id " style="color: #FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Password:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" Width="156px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="passwordTextBox" ErrorMessage="password is required" style="color: #FF3300"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style7">Select
                    <asp:DropDownList ID="Category" runat="server">
                        <asp:ListItem>Vendor</asp:ListItem>
                        <asp:ListItem>Buyer</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Confirm Password:</td>
                <td class="auto-style12">
                    <asp:TextBox ID="confirm_passwordTextBox" runat="server" TextMode="Password" Width="153px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="confirm_passwordTextBox" ErrorMessage="password required" style="color: #FF3300"></asp:RequiredFieldValidator>
&nbsp;<br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passwordTextBox" ControlToValidate="confirm_passwordTextBox" ErrorMessage="password do not match" style="color: #FF3300"></asp:CompareValidator>
                </td>
                <td class="auto-style9">
                    <asp:Button ID="submitButton" runat="server" style="font-weight: 700" Text="Submit" OnClick="submitButton_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
