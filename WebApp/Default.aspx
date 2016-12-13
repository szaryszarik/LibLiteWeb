<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" StyleSheetTheme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title> 
    <link href="css/bootstrap.css" rel="stylesheet" />
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
   <!-- 
    <nav class="navbar navbar-inverse">
        <div class="container-fluid">
            <div class ="navbar-header">
                <a class="navbar-brand" href="#">LibLite Home</a>
            </div>
            <ul class="nav navbar-nav">
                <li class="active"><a href="#">Home</a></li>
                <li><a href="#">Contact</a></li>
            </ul>
        </div>
    </nav>

    <!--
        username: root
        password: Zwierz1993
        -->
 <!--   <a href="#">Home</a> | <a href="Registration.aspx">Registration</a>   -->
 <!--   <div class="container-fluid">
                <div class="jumbotron">
                    <h1>Welcome in LibLite Web Service!</h1>
                </div>
    </div>  -->

 <nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand" href="#">WebLibLite</a>
    </div>
    <ul class="nav navbar-nav">
      <li class="active"><a href="#">Home</a></li>
      <li><a href="#">Contact</a></li>
    </ul>
  </div>
</nav>

<div class="container">
  <div class="jumbotron">
    <h1>Welcome in WebLibLite!</h1>      
    <p>WebLibLite is the Web version of LibLite client for users and borrowers.</p>
  </div>
</div>

<div class="container">  
    <h2>Log In</h2>
    <form class="form-horizontal" id="form1" runat="server"> 
      <div class="form-group">
         
              <label class="control-label col-sm-2" for="username">Username:</label>
              <div class="col-sm-10">
                <asp:TextBox ID="usernameTextBox" Text="" runat="server" />
              </div> 
        
    </div> 
        <div class="form-group">
            <label class="control-label col-sm-2" for="password">Password:</label>
            <div class="col-sm-10">
                <asp:TextBox type="password" ID="passwordTextBox" Text="" runat="server" />
            </div> 

        </div>

        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
              <asp:Button ID="submitButton" Text="Log in" runat="server" OnClick="submitEventMethod" /> 
            </div>
        </div>
   </form>
 </div>
</body>
</html>
