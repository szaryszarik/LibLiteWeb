<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApp.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body>
    <p>Registration page</p>
    <a href="Default.aspx">Home</a> | <a href="#">Registration</a>
    <form id="form1" runat="server">
    <div>
    
        <p>Enter Username</p>
        <asp:TextBox ID="usernameTextBox" Text="" runat="server" />
        <p>Enter Password</p>
        <asp:TextBox ID="passwordTextBox" Text="" runat="server" />
        <p>Enter Name</p>
        <asp:TextBox ID="nameTextBox" Text="" runat="server" />
        <p>Enter Surname</p>
        <asp:TextBox ID="surnameTextBox" Text="" runat="server" />
        <p>Enter City</p>
        <asp:TextBox ID="cityTextBox" Text="" runat="server" />
        <p>Enter Street nr</p>
        <asp:TextBox ID="streetTextBox" Text="" runat="server" />
        <p>Enter Apartment nr</p>
        <asp:TextBox ID="apartmentTextBox" Text="" runat="server" />
        <p>Enter Postal Code</p>
        <asp:TextBox ID="postalCodeTextBox" Text="" runat="server" />
        <p>Enter Phone</p>
        <asp:TextBox ID="phoneTextBox" Text="" runat="server" />
        <p>Enter Email</p>
        <asp:TextBox ID="emailTextBox" Text="" runat="server" />
        <p>Enter Security Number</p>
        <asp:TextBox ID="secNumTextBox" Text="" runat="server" />
        <asp:Button ID="registrationButton" Text="REGISTER" runat="server" OnClick="registerEventMethod" />
    </div>
    </form>
</body>
</html>
