using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITP2020_G8._11
{
    public partial class LetUsCallYouAdminPdf : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Let_us_call_you", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    GridView5.DataSource = ds;
                    GridView5.DataBind();

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(GridView5.HeaderRow.Cells.Count);


            foreach (TableCell headerCell in GridView5.HeaderRow.Cells)

            {
                iTextSharp.text.Font font = new iTextSharp.text.Font();
                font.Color = new BaseColor(GridView5.HeaderStyle.ForeColor);

                PdfPCell pdfCell = new PdfPCell(new Phrase(headerCell.Text, font));
                pdfCell.BackgroundColor = new BaseColor(GridView5.HeaderStyle.BackColor);

                pdfTable.AddCell(pdfCell);

            }


            foreach (GridViewRow gridViewRow in GridView5.Rows)
            {
                foreach (TableCell tableCell in gridViewRow.Cells)
                {
                    iTextSharp.text.Font font = new iTextSharp.text.Font();
                    font.Color = new BaseColor(GridView5.RowStyle.ForeColor);

                    PdfPCell pdfCell = new PdfPCell(new Phrase(tableCell.Text));
                    pdfCell.BackgroundColor = new BaseColor(GridView5.RowStyle.BackColor);

                    pdfTable.AddCell(pdfCell);

                }
            }

            Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

            pdfDocument.Open();
            pdfDocument.Add(pdfTable);
            pdfDocument.Close();

            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Let Us Call You Report.pdf");
            Response.Write(pdfDocument);
            Response.Flush();
            Response.End();
        }
    }
}