<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductPage.aspx.cs" Inherits="Mukicik.Views.ProductPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Product Page</h1>
            <div>
                <asp:GridView ID="GridViewProduct" runat="server"></asp:GridView>            
            </div>
            <div>
                <asp:Label ID="InputProductIdLabel" runat="server" Text="Input Produk Id : "></asp:Label>
                <asp:TextBox ID="InputProductIdTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="InputValueLabel" runat="server" Text="Input Value :"></asp:Label>
                <asp:TextBox ID="ValueTextBox" runat="server"></asp:TextBox>
                <asp:Button ID="IncreaseButton" runat="server" Text="Increase" OnClick="IncreaseButton_Click"/>
                <asp:Button ID="DecreaseButton" runat="server" Text="Decrease" OnClick="DecreaseButton_Click" />
            </div>
        </div>
    </form>
</body>
</html>
