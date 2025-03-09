<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Sesi3.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is Homepage!</h1>
    <asp:Button ID="LogoutButton" runat="server" Text="Log Out" Onclick="LogoutButton_Click"/>
</asp:Content>
