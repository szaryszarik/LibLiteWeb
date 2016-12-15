using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;
        String queryStr;
        String name;
        String username;
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

        }

        protected void submitEventMethod(object sender, EventArgs e)
        {
            if(checkAgainstWhiteList(usernameTextBox.Text) == true 
                && checkAgainstWhiteList(passwordTextBox.Text) == true)
            {
                lab.Text = "";
                DoSQLQuery();
            }
            else
            {
                //passwordTextBox.Text = "Does not pass White List test";
                lab.Text = "";
                lab.Text = "Does not pass White List test";
                lab.ForeColor = System.Drawing.Color.Red;
            }
            
        }

        private bool checkAgainstWhiteList(String userInput)
        {
            var regExpression = new System.Text.RegularExpressions.Regex(@"^[A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ0-9]*$");
            if (regExpression.IsMatch(userInput))
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void DoSQLQuery()
        {
            try
            {
                String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
                conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
                conn.Open();

                queryStr = "select * from tbl_user where username='" + usernameTextBox.Text + "' and password = '" + passwordTextBox.Text + "'";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

                reader = cmd.ExecuteReader();
                name = "";
                username = "";
                surname = "";
                city = "";
                street = "";
                apartment = "";
                postal = "";
                phone = "";
                mail = "";
                pesel = "";

                while (reader.HasRows && reader.Read())
                {
                    name = reader.GetString(reader.GetOrdinal("name"));
                    username = reader.GetString(reader.GetOrdinal("username"));
                    surname = reader.GetString(reader.GetOrdinal("surname"));
                    city = reader.GetString(reader.GetOrdinal("city"));
                    street = reader.GetString(reader.GetOrdinal("street"));
                    apartment = reader.GetString(reader.GetOrdinal("apartment_num"));
                    postal = reader.GetString(reader.GetOrdinal("postal_code"));
                    phone = reader.GetString(reader.GetOrdinal("phone"));
                    mail = reader.GetString(reader.GetOrdinal("email"));
                    pesel = reader.GetString(reader.GetOrdinal("socsecnumber"));
                }

                if (reader.HasRows)
                {
                    Session["uname"] = name;
                    Session["login"] = username;
                    Session["usurname"] = surname;
                    Session["ucity"] = city;
                    Session["ustreet"] = street;
                    Session["uapartment"] = apartment;
                    Session["upostal"] = postal;
                    Session["uphone"] = phone;
                    Session["umail"] = mail;
                    Session["upesel"] = pesel;
                    Response.BufferOutput = true;
                    Response.Redirect("LoggedIn.aspx", false);
                
                }
                else
                {
                    //passwordTextBox.Text = "invalid user";
                    lab.Text = "";
                    lab.Text = "invalid user";
                    lab.ForeColor = System.Drawing.Color.Red;
                }

                reader.Close();
                conn.Close();
            } catch(Exception e)
            {
                //passwordTextBox.Text = e.ToString();
                lab.Text = "";
                lab.Text = e.ToString();
                lab.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
