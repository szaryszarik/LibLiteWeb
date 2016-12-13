<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoggedIn.aspx.cs" Inherits="WebApp.LoggedIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Logged In</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
<nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand" href="#">WebLibLite</a>
    </div>
    <ul class="nav navbar-nav">
        <li><a href="Default.aspx">Log out</a></li>
        <li><a href="#">Contact</a></li>
        <li class="active"><a href="#">My Account</a></li>
        <li><a href="Account.aspx">My Books</a></li>
        <li><a href="Library.aspx">My Library</a></li>
    </ul>
      <form id="form1" runat="server">
        
      </form>

  </div>
</nav>

<div class="container">
  <div class="jumbotron">
    <h1>My Account</h1>      
    <p>Feel free to search for books which we offer. From this panel you can also check your current repository</p>
  </div>
</div>

    
</body>
</html>
