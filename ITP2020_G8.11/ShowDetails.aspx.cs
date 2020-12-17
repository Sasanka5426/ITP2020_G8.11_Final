using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITP2020_G8._11
{
    public partial class ShowDetails : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Request.QueryString["Detail_id"].ToString();
            TextBox2.Text = Request.QueryString["name"].ToString();
            TextBox3.Text = Request.QueryString["phoneNo"].ToString();
            TextBox4.Text = Request.QueryString["email"].ToString();
            TextBox5.Text = Request.QueryString["message"].ToString();
        }
    }
}