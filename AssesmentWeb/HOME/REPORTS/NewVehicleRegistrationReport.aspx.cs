using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.IO;
using ViewLayer.Report;

namespace AssesmentWeb.REPORTS
{
    public partial class NewVehicleRegistrationReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnFetch_Click(object sender, EventArgs e)
        {
            lblFrom.Visible = true;
            lblTo.Visible = true;
            lblFromDate.Visible = true;
            lblToDate.Visible = true;
            lblFrom.Text = txtFrom.Text;
            lblTo.Text = txtTo.Text;

            VehicleRegistrationReport vehicleRegistrationReport = new VehicleRegistrationReport();
            vehicleRegistrationReport.FromDate = Convert.ToDateTime(txtFrom.Text);
            vehicleRegistrationReport.ToDate = Convert.ToDateTime(txtTo.Text);
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            //string sqlQuery = "Select * from [dbo].[Vehicle_Registration] where RegistrationDate between '" + txtFrom.Text + "'and'" + txtTo.Text + "'";
            // SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("VehicleReport", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@FromDate", SqlDbType.Date);
            param1.Value = vehicleRegistrationReport.FromDate;
            command.Parameters.Add(param1);
            SqlParameter param2 = new SqlParameter("@ToDate", SqlDbType.Date);
            param2.Value = vehicleRegistrationReport.ToDate;
            command.Parameters.Add(param2);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataReader sdr = command.ExecuteReader();

            if (sdr.Read())
            {
                //Label1.Visible = false;
                lblFromTxt.Visible = false;
                lblToTxt.Visible = false;
                txtFrom.Visible = false;
                txtTo.Visible = false;
                GridView1.Visible = true;
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                lblDisplay.Visible = true;
                lblFromTxt.Visible = false;
                lblToTxt.Visible = false;
                txtFrom.Visible = false;
                txtTo.Visible = false;
                lblDisplay.Text = "No records Found";

            }
            sqlConnection.Close();
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            RTOnav.Visible = false;
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=VehicleRegistractionReport.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);                   
            this.Page.RenderControl(htw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlparse = new HTMLWorker(pdfdoc);
            PdfWriter.GetInstance(pdfdoc, Response.OutputStream);

            pdfdoc.Open();
            htmlparse.Parse(sr);
            pdfdoc.Close();
            Response.Write(pdfdoc);
            Response.End();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            lblFromTxt.Visible = true;
            lblToTxt.Visible = true;
            txtFrom.Visible = true;
            txtTo.Visible = true;
            lblFromDate.Visible = false;
            lblToDate.Visible = false;
            lblFrom.Visible = false;
            lblTo.Visible = false;
            lblDisplay.Visible = false;
            GridView1.Visible = false;
        }
    }
}