<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="LatihanKuis.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register Page</h1>
            <div>
                <asp:Label ID="UsernameLabel" runat="server" Text="Username : "></asp:Label>
                <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="PasswordLabel" runat="server" Text="Password : "></asp:Label>
                <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click"/>
            </div>
            <div>
                <asp:LinkButton ID="LinkToLoginButton" runat="server" OnClick="LinkToLoginButton_Click">Already Have An Account? Login</asp:LinkButton>
            </div>
            <div>
                <asp:Label ID="WarningLabel" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
