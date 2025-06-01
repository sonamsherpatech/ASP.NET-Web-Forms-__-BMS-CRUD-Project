<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateBook.aspx.cs" Inherits="CRUD_Application.UpdateBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Update Book</h1>
    <a href="ReadBook.aspx">Return to HomePage</a>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server">Book Title</asp:Label> <br />
        <asp:TextBox runat="server" ID="txtTitle"/>
        <asp:RequiredFieldValidator ID="rfTitle" runat="server" ControlToValidate="txtTitle" ErrorMessage="*Title Field is required" ForeColor="Red" />
        <asp:RegularExpressionValidator ID="regTitle" runat="server" ControlToValidate="txtTitle" ErrorMessage="*Title Field can't contain special character" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9\s]+$" />
         <br /><br />
        
        <asp:Label ID="lblAuthor" runat="server" >Book Author</asp:Label> <br />
        <asp:TextBox ID="txtAuthor" runat="server" />
        <asp:RequiredFieldValidator ID="rfAuthor" runat="server" ControlToValidate="txtAuthor" ErrorMessage="*Author Field is required" ForeColor="Red" />
        <asp:RegularExpressionValidator ID="regAuthor" runat="server" ControlToValidate="txtAuthor" ErrorMessage="*Name can't contain number or special character" ForeColor="Red" ValidationExpression="^[A-Za-z\s]+$" />
        <br /><br />
        
        <asp:Label ID="lblGenre" runat="server" >Book Genre</asp:Label> <br />
        <asp:TextBox ID="txtGenre" runat="server" />
        <asp:RequiredFieldValidator ID="rfGenre" runat="server" ControlToValidate="txtGenre" ErrorMessage="*Genre Field is required" ForeColor="Red" />
        <asp:RegularExpressionValidator ID="regGenre" runat="server" ControlToValidate="txtGenre" ErrorMessage="*Genre can't contain number or special character" ForeColor="Red" ValidationExpression="^[A-Za-z\s]+$" />
        <br /><br />
        
        <asp:Label ID="lblPrice" runat="server" >Book Price</asp:Label> <br />
        <asp:TextBox ID="txtPrice" runat="server"/>
        <asp:RequiredFieldValidator ID="rfPrice" runat="server" ControlToValidate="txtPrice" ErrorMessage="*Price Field is required" ForeColor="Red" />
        <asp:RegularExpressionValidator ID="regPrice" runat="server" ControlToValidate="txtPrice" ErrorMessage="*Put correct price format(e.g: 99.99)" ForeColor="Red" ValidationExpression="^\d+(\.\d{1,2})?$" />
        <br /><br />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnSubmit_Click" Text="Update Book" />
    </form>
</body>
</html>
