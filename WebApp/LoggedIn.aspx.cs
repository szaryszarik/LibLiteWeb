using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class LoggedIn : System.Web.UI.Page
    {
        String name;
        protected void Page_Load(object sender, EventArgs e)
        {
            name = (String)(Session["uname"]);
            
           /* if(name == null)
            {
                Response.BufferOutput = true;
                Response.Redirect("Default.aspx", false);

            } else
            {
                userLabel.Text = name;
            } */
        }

        protected void logoutEventMethod(object sender, EventArgs e)
        {
            Session["uname"] = null;
            Session.Abandon();
            Response.BufferOutput = true;
            Response.Redirect("Default.aspx", false);
        }
    }
}