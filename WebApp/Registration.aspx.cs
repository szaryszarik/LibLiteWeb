using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Registration : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        String queryStr; 

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerEventMethod(object sender, EventArgs e)
        {
            registerUser();
        }

        private void registerUser()
        {
            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();

            conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            conn.Open();
            queryStr = "insert into tbl_user (username,password,name,surname,city,street,apartment_num,postal_code,phone,email,socsecnumber)" +
                "VALUES('" + usernameTextBox.Text + "','" + passwordTextBox.Text + "','" +
                nameTextBox.Text + "','" + surnameTextBox.Text + "','" + cityTextBox.Text + "','" +
                streetTextBox.Text + "','" + apartmentTextBox.Text + "','" + postalCodeTextBox.Text + "','" +
                phoneTextBox.Text + "','" + emailTextBox.Text + "','" + secNumTextBox.Text + "')";

            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

            cmd.ExecuteReader();

            conn.Close();
        }
    }
}