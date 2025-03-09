<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Sesi1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="UsernameLabel" runat="server" Text="Enter Username"></asp:Label>
            <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PasswordLabel" runat="server" Text="Enter Password"></asp:Label>
            <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="GenderLabel" runat="server" Text="Gender :"></asp:Label>
            <asp:RadioButton ID="MaleRadioButton" runat="server" GroupName="GenderRadioButton" Text="Male" Checked="true"/>
            <asp:RadioButton ID="FemaleRadioButton" runat="server" GroupName="GenderRadioButton" Text="Female" />
        </div>
        <div>
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click"/>
        </div>
        <div>
            <asp:Label ID="WarningLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
