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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitEventMethod(object sender, EventArgs e)
        {
            if(checkAgainstWhiteList(usernameTextBox.Text) == true 
                && checkAgainstWhiteList(passwordTextBox.Text) == true)
            {
                DoSQLQuery();
            }
            else
            {
                passwordTextBox.Text = "Does not pass White List test";
            }
            
        }

        private bool checkAgainstWhiteList(String userInput)
        {
            var regExpression = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9]*$");
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
                while (reader.HasRows && reader.Read())
                {
                    name = reader.GetString(reader.GetOrdinal("name"));
                    username = reader.GetString(reader.GetOrdinal("username"));
                }

                if (reader.HasRows)
                {
                    Session["uname"] = name;
                    Response.BufferOutput = true;
                    Response.Redirect("LoggedIn.aspx", false);
                    Session["login"] = username;
                }
                else
                {
                    passwordTextBox.Text = "invalid user";
                }

                reader.Close();
                conn.Close();
            } catch(Exception e)
            {
                passwordTextBox.Text = e.ToString();
            }
        }
    }
}