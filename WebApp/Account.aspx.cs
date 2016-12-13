using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

namespace WebApp
{
    public partial class Account : System.Web.UI.Page
    {
        String login;
        String sql;
        String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                BindData();
            }

        }

        private void BindData()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection cn = new MySqlConnection(connString))
            {
                login = (String)(Session["login"]);
                sql = "select b.title, b.isbn, l.loan_date, l.return_date " +
                             "from tbl_book b join tbl_loan l on b.id = l.book_id " +
                             "where l.user_id = (select id from tbl_user where username = '" + login + "')";

                MySqlDataAdapter adp = new MySqlDataAdapter(sql, cn);
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
        }

        //protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        //{

        //}
    }
}