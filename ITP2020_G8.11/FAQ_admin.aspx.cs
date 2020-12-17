using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITP2020_G8._11
{
    public partial class FAQ_admin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)Session["role"]))
            {
                Response.Write("<script>alert('Error! You have to Login as Admin to access this section.');</script>");
                Response.Redirect("adminLogin.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")  //validate if text boxes are empty
            {
                Response.Write("<script>alert('Fill All the fields');</script>");
                return;
            }

            else if (checkIfFaqExists())
            {
                Response.Write("<script>alert('Faq with this Qid already exist. You cannot add another Faq with the same Faq Qid');</script>");
            }
            else
            {
                addNewFaq();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            getFaqByID();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkIfFaqExists())
            {
                updateFaq();
            }
            else
            {
                Response.Write("<script>alert('Faq does not exist');</script>");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfFaqExists())
            {
                deleteFaq();
            }
            else
            {
                Response.Write("<script>alert('Faq does not exist');</script>");
            }
        }

        //PDF
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=FAQ.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);
            GridView1.RenderControl(htmlTextWriter);
            StringReader stringReader = new StringReader(stringWriter.ToString());

            Document Doc = new Document(PageSize.A4, 10f, 10f, 40f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(Doc);
            PdfWriter.GetInstance(Doc, Response.OutputStream);

            Doc.Open();
            htmlparser.Parse(stringReader);
            Doc.Close();

            Response.Write(Doc);
            Response.End();
        }
        public override void VerifyRenderingInServerForm(Control control)   //form error for GridView1 below shows it as a solution
        {
            return;
        }





        //user defined functions

        void addNewFaq()    //for add button
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO admin_FAQ_tbl(Qid, Question, Answer) values(@Qid, @Question, @Answer)", con);

                cmd.Parameters.AddWithValue("@Qid", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Question", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Answer", TextBox3.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Faq added Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        bool checkIfFaqExists() //check whether it exists or not
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from admin_FAQ_tbl where Qid = '" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        void getFaqByID()   //for search button
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from admin_FAQ_tbl where Qid = '" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                    TextBox3.Text = dt.Rows[0][2].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Faq ID');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void updateFaq()    //for update button
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE admin_FAQ_tbl SET Question=@Question, Answer=@Answer WHERE Qid='" + TextBox1.Text.Trim() + "'", con);

                cmd.Parameters.AddWithValue("@Question", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Answer", TextBox3.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Faq Updated Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }

        void deleteFaq()    //for delete button
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from admin_FAQ_tbl WHERE Qid='" + TextBox1.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Faq Deleted Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }



        //clear textbox data when process is end
        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        
    }
}