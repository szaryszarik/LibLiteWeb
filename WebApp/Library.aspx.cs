using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Library : System.Web.UI.Page
    {
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
                sql = "select b.title, concat(a.name, ' ', a.surname) as author, " +
                    " group_concat(distinct c.category separator ', ') as category, " +
                    "case when l.id is null then 'Avaiable' else l.return_date end 'Avaiable' " +
                    "from tbl_book b left join tbl_author a on b.id_author = a.id " +
                    "left join tbl_category c on (b.id_category_1 = c.id " +
                    "OR b.id_category_2 = c.id OR b.id_category_3 = c.id) " +
                    "left join tbl_loan l on l.book_id = b.id group by 1,2,4";

                MySqlDataAdapter adp = new MySqlDataAdapter(sql, cn);
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    GridView2.DataSource = dt;
                    GridView2.DataBind();
                }
            }
        }

        protected void searchEventMethod(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            using (MySqlConnection cn = new MySqlConnection(connString))
            {
                sql = "select * from (select b.title, concat(a.name, ' ', a.surname) as author, " +
                    " group_concat(distinct c.category separator ', ') as category, " +
                    "case when l.id is null then 'Avaiable' else l.return_date end 'Avaiable' " +
                    "from tbl_book b left join tbl_author a on b.id_author = a.id " +
                    "left join tbl_category c on (b.id_category_1 = c.id " +
                    "OR b.id_category_2 = c.id OR b.id_category_3 = c.id) " +
                    "left join tbl_loan l on l.book_id = b.id group by 1,2,4) as T " +
                    "where t.title like '%" + searchTextBox.Text + "%' or t.author like '%" + searchTextBox.Text
                    + "%' or t.category like '%" + searchTextBox.Text  + "%'";

                MySqlDataAdapter adp = new MySqlDataAdapter(sql, cn);
                adp.Fill(dt2);

                if (dt2.Rows.Count > 0)
                {
                    GridView2.DataSource = dt2;
                    GridView2.DataBind();
                }
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            BindData();
        }
    }
}