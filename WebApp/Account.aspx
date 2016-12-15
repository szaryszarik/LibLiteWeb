<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="WebApp.Account" %>

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
        <li class="active"><a href="#">My Books</a></li>
        <li><a href="Library.aspx">My Library</a></li>
    </ul>

  </div>
    </nav>

    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            GridLines="None"
            AllowPaging="true" CssClass="mGrid" PagerStyle-CssClass="pgr"
            AlternatingRowStyle-CssClass="alt" PageSize="15" OnPageIndexChanging="GridView2_PageIndexChanging"> 
            <AlternatingRowStyle CssClass="alt" />
            <Columns>
                <asp:TemplateField HeaderText="Title">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ISBN">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("isbn") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Date from">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("loan_date") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Date to">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("return_date") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <PagerStyle CssClass="pgr" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
