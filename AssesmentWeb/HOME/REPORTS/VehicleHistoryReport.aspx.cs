using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewLayer.Report;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.IO;

namespace AssesmentWeb.REPORTS
{
    public partial class VehicleHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFetch_Click(object sender, EventArgs e)
        {
            Vehicle_History vehicleHistory = new Vehicle_History();
            vehicleHistory.RegistrationNo = Convert.ToString(txtRegNo.Text);
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("HistoryReport", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@RegistrationNo", SqlDbType.VarChar);
            param1.Value = vehicleHistory.RegistrationNo;
            command.Parameters.Add(param1);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataReader sdr = command.ExecuteReader();

            if (sdr.Read())
            {
                lblRegNo.Visible = false;
                txtRegNo.Visible = false;
                lblDisplay.Visible = false;
                lblReg.Visible = true;
                lblDisplayReg.Visible = true;
                lblDisplayReg.Text = txtRegNo.Text;
                GridView1.Visible = true;
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
            else
            {
                lblRegNo.Visible = false;
                txtRegNo.Visible = false;
                lblReg.Visible = true;
                lblDisplayReg.Visible = true;
                lblDisplayReg.Text = txtRegNo.Text;
                lblDisplay.Visible = true;
                lblDisplay.Text = "No Records Found";

            }
            sqlConnection.Close();

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            lblRegNo.Visible = true;
            txtRegNo.Visible = true;
            lblReg.Visible = false;
            lblDisplayReg.Visible = false;
            GridView1.Visible = false;
            lblDisplay.Visible = false;
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            RTOnav.Visible = false;
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=VehicleHistoryReport.pdf");
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
    }
}