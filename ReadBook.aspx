<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadBook.aspx.cs" Inherits="CRUD_Application.ReadBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Book Data</h1>
        <a href="InsertBook.aspx">Insert a Book</a>
        
        <asp:Table ID="tblBook" runat="server" BorderStyle="Solid" BorderColor="Black" GridLines="Both" BorderWidth="1px"  CellPadding="8">
               <asp:TableHeaderRow runat="server" ID="tblHeader" BackColor="LightBlue" ForeColor="White">
                   <asp:TableHeaderCell runat="server" ID="tblSN">S.N</asp:TableHeaderCell>
                   <asp:TableHeaderCell runat="server" ID="tblTitle">Book Title</asp:TableHeaderCell> 
                   <asp:TableHeaderCell runat="server" ID="tblAuthor">Book Author</asp:TableHeaderCell>
                   <asp:TableHeaderCell runat="server" ID="tblGenre">Book Genre</asp:TableHeaderCell>
                   <asp:TableHeaderCell runat="server" ID="tblPrice">Book Price</asp:TableHeaderCell>
                   <asp:TableHeaderCell runat="server" ID="tblAction">Action</asp:TableHeaderCell>
               </asp:TableHeaderRow>
        </asp:Table>
    </form>
</body>
</html>
