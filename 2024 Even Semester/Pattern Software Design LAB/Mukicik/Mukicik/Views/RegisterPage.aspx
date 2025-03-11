<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Mukicik.Views.RegisterPage" %>

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
                <asp:Label ID="EmailLabel" runat="server" Text="Email : "></asp:Label>
                <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="NameLabel" runat="server" Text="Name : "></asp:Label>
                <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="PasswordLabel" runat="server" Text="Password : "></asp:Label>
                <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="ConfirmPasswordLabel" runat="server" Text="Confirm Password : "></asp:Label>
                <asp:TextBox ID="ConfirmPasswordTextBox" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="GenderLabel" runat="server" Text="Gender : "></asp:Label>
                <asp:RadioButton ID="MaleRadioButton" runat="server" GroupName="GenderGroup" Checked="true" Text="Male" />
                <asp:RadioButton ID="FemaleRadioButton" runat="server" GroupName="GenderGroup" Text="Female" />
            </div>
            <br />
            <div>
                <asp:Label ID="DobLabel" runat="server" Text="Date Of Birth : "></asp:Label>
                <asp:Calendar ID="DobCalendar" runat="server" OnSelectionChanged="DobCalendar_SelectionChanged"></asp:Calendar>
                <asp:TextBox ID="DobText" runat="server" Enabled="false"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:CheckBox ID="ConfirmationCheckBox" runat="server" Text="I Agree To Terms And Conditions" />
            </div>
            <br />
            <div>
                <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click"/>
            </div>
            <br />
            <div>
                <asp:Label ID="WarningLabel" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
