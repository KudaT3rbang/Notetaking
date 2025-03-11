<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LatihanKuis.Views.LoginPage" %>

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
                <asp:Label ID="UsernameLabel" runat="server" Text="Username : "></asp:Label>
                <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="PasswordLabel" runat="server" Text="Password : "></asp:Label>
                <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:CheckBox ID="RememberMeCheckBox" runat="server" />
            </div>
            <div>
                <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click"/>
            </div>
            <div>
                <asp:LinkButton ID="LinkToRegisterButton" runat="server" OnClick="LinkToRegisterButton_Click">Don't Have An Account? Register</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
