<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Sesi5.Views.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Home Page</h1>
            <div>
                <div>
                    <asp:Label ID="LabelName" runat="server" Text="Product Name : "></asp:Label>
                    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="LabelPrice" runat="server" Text="Price : "></asp:Label>
                    <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="LabelStock" runat="server" Text="Stock : "></asp:Label>
                    <asp:TextBox ID="StockTextBox" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="LabelType" runat="server" Text="Type : "></asp:Label>
                    <asp:DropDownList ID="TypeDropDownList" runat="server"></asp:DropDownList>
                </div>
            </div>
            <div>
                <asp:GridView ID="GridViewProducts" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField HeaderText="Id" DataField="Id" />
                        <asp:BoundField HeaderText="Name" DataField="Name" />
                        <asp:BoundField HeaderText="Type" DataField="Type" />
                        <asp:BoundField HeaderText="Price" DataField="Price" />
                        <asp:BoundField HeaderText="Stock" DataField="Stock" />
                    </Columns>
                </asp:GridView>
            </div>
            <div>
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
