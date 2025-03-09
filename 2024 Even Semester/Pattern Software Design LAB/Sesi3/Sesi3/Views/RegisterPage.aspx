<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Sesi3.Views.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Register Page</h1>
    </div>
    <div>
        <asp:Label ID="LabelUsername" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Register" runat="server" Text="Button" OnClick="Register_Click"/>
    </div>
</asp:Content>
