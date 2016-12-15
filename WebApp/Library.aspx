<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Library.aspx.cs" Inherits="WebApp.Library" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        <li><a href="LoggedIn.aspx">My Account</a></li>
        <li><a href="Account.aspx">My Books</a></li>
        <li class="active"><a href="#">My Library</a></li>
    </ul>
 <div>
        
        <form id="form1" runat="server">
            <div class="navbar-form navbar-left">
                <asp:TextBox ID="searchTextBox" placeholder="Search for..." runat="server" />
                <asp:Button ID="searchButton" Text="Search" runat="server" OnClick="searchEventMethod" /> 
            </div>
        
        
    
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"
            GridLines="None"
            AllowPaging="true" CssClass="mGrid" PagerStyle-CssClass="pgr"
            AlternatingRowStyle-CssClass="alt" PageSize="15" OnPageIndexChanging="GridView1_PageIndexChanging"> 
            <AlternatingRowStyle CssClass="alt" />
            <Columns>
                <asp:TemplateField HeaderText="Title">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Author">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("author") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Category">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("category") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Avaiable">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("avaiable") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <PagerStyle CssClass="pgr" />
        </asp:GridView>
    
            </form>
    </div>
    

  </div>
    </nav>

    
</body>
</html>
