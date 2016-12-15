<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoggedIn.aspx.cs" Inherits="WebApp.LoggedIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Logged In</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
<nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand" href="#">WebLibLite</a>
    </div>
    <ul class="nav navbar-nav">
        <li><a href="Default.aspx">Log out</a></li>
        <li class="active"><a href="#">My Account</a></li>
        <li><a href="Account.aspx">My Books</a></li>
        <li><a href="Library.aspx">My Library</a></li>
    </ul>

  </div>
</nav>

<div class="container">
  <div class="jumbotron">
    <h1>My Account</h1>      
    <p>Feel free to search for books which we offer. From this panel you can also check your current repository</p>
  </div>
</div>

<div class="container">
  <div class="jumbotron">
    <form id="form2" runat="server">
        <div class="container" style="margin-top:50px">
            <div class="row">
                <div class="col-md-4">
                    <h2>Personal</h2>
                    <asp:Label ID="Label11" runat="server" Text=""></asp:Label>  <br />       
                    <asp:Label ID="Label12" runat="server" Text=""></asp:Label>  <br />
                    <asp:Label ID="Label19" runat="server" Text=""></asp:Label>  <br />
                </div>
                <div class="col-md-4">
                    <h2>Residence</h2>
                    <asp:Label ID="Label13" runat="server" Text=""></asp:Label>  <br />
                    <asp:Label ID="Label14" runat="server" Text=""></asp:Label>  <br />
                    <asp:Label ID="Label15" runat="server" Text=""></asp:Label>  <br />
                    <asp:Label ID="Label16" runat="server" Text=""></asp:Label>  <br />
                </div>
                <div class="col-md-4">
                    <h2>Contact</h2>
                    <asp:Label ID="Label17" runat="server" Text=""></asp:Label>  <br />
                    <asp:Label ID="Label18" runat="server" Text=""></asp:Label>  <br />
                </div>
            </div>
        </div>
    </form>
  </div>
</div>

    
</body>
</html>
