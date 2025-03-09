<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Sesi4.Views.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Stock Manager</h1>
        </div>
        <div>
            <asp:GridView ID="GridViewDatabase" runat="server"></asp:GridView>
        </div>
        <div>
            <div>
                <asp:Label ID="NameLabel" runat="server" Text="Item Name : "></asp:Label>
                <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="PriceLabel" runat="server" Text="Price : "></asp:Label>
                <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="StockLabel" runat="server" Text="Stock : "></asp:Label>
                <asp:TextBox ID="StockTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="ItemTypeLabel" runat="server" Text="Item Type : "></asp:Label>
                <asp:DropDownList ID="DropDownItemType" runat="server"></asp:DropDownList>
            </div>
            <div>
                <asp:Button ID="AddItemButton" runat="server" Text="Add Item" OnClick="AddItemButton_Click" />
            </div>
        </div>
    </form>
</body>
</html>
