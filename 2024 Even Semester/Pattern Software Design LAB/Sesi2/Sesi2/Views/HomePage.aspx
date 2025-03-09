<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Sesi2.Views.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Homepage</h1>     
        </div>
        <div>
            <asp:GridView ID="GridViewItems" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
