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
    public partial class LetUsCallYouAdmin2 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)Session["role"]))
            {
                Response.Write("<script>alert('Error! You have to Login as Admin to access this section.');</script>");
                Response.Redirect("adminLogin.aspx");
            }

            GridView4.DataBind();
        }

        protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = GridView4.SelectedRow;

            Response.Redirect("ShowDetails.aspx?Detail_id=" + gr.Cells[0].Text + "&name=" + gr.Cells[1].Text + "&phoneNo=" + gr.Cells[2].Text + "&email=" + gr.Cells[3].Text + "&message=" + gr.Cells[4].Text);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            deteteDetails();
        }
        void deteteDetails()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from Let_us_call_you WHERE Detail_id='" + TextBox1.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Deleted Successfully');</script>");
                clearForm4();
                GridView4.DataBind();


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }
        void clearForm4()
        {
            TextBox1.Text = "";
        }
    }
    
}