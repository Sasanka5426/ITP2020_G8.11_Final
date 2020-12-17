using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITP2020_G8._11
{
    public partial class aboutUsCustomer : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM abtUs WHERE id='2';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                Label6.Text = dt.Rows[0]["ds"].ToString();
                Label3.Text = dt.Rows[0]["vision"].ToString();
                Label1.Text = dt.Rows[0]["mision"].ToString();
                Label2.Text = dt.Rows[0]["cs"].ToString();
                Label4.Text = dt.Rows[0]["qs"].ToString();
                Label5.Text = dt.Rows[0]["ln"].ToString();



            }
        }
    }
}