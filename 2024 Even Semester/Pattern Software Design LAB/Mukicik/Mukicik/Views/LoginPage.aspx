<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Mukicik.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login Page</h1>
            <div>
                <asp:Label ID="EmailLabel" runat="server" Text="Email : "></asp:Label>
                <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="PasswordLabel" runat="server" Text="Password : "></asp:Label>
                <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:CheckBox ID="RememberMeCheckBox" runat="server" Text="Remember Me"/>
            </div>
            <div>
                <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click"/>
            </div>
            <br />
            <div>
                <asp:Label ID="WarningLabel" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
