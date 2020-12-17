using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITP2020_G8._11
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["role"] = "";
            try
            {
                //if(Session["role"].Equals(""))

                if(string.IsNullOrEmpty((string)Session["role"]))
                {
                    LinkButton1.Visible = false;  //admin home
                    LinkButton2.Visible = false;  //Logout
                    LinkButton3.Visible = true;  //Admin Login

                }
                else //if(Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = true;  //admin home
                    LinkButton2.Visible = true;  //Logout
                    LinkButton3.Visible = false;  //Admin Login
                }
            }
            catch(Exception ex)
            {

            }
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminLogin.aspx");
        }

        

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("adminHome.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["firstName"] = "";
            Session["role"] = "";

            LinkButton1.Visible = false;  //admin home
            LinkButton2.Visible = false;  //Logout
            LinkButton3.Visible = true;  //Admin Login

            Response.Redirect("MainHome.aspx");
        }
    }
}