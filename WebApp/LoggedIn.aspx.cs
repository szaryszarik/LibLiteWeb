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
        String surname;
        String city;
        String street;
        String apartment;
        String postal;
        String phone;
        String mail;
        String pesel;

        protected void Page_Load(object sender, EventArgs e)
        {
            name = (String)(Session["uname"]);
            Label11.Text = "Name: " + name;
            surname = (String)(Session["usurname"]);
            Label12.Text = "Surname: " + surname;
            city = (String)(Session["ucity"]);
            Label13.Text = "City: " + city;
            street = (String)(Session["ustreet"]);
            Label14.Text = "Street: " + street;
            apartment = (String)(Session["uapartment"]);
            Label15.Text = "Apartment: " + apartment;
            postal = (String)(Session["upostal"]);
            Label16.Text = "Postal Code: " + postal;
            phone = (String)(Session["uphone"]);
            Label17.Text = "Phone: " + phone;
            mail = (String)(Session["umail"]);
            Label18.Text = "Email: " + mail;
            pesel = (String)(Session["upesel"]);
            Label19.Text = "SEC ID: " + pesel;

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