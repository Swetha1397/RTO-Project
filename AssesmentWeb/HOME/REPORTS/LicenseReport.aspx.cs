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
    public partial class LicenseReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFetch_Click(object sender, EventArgs e)
        {
            License_Report licenseReport = new License_Report();
            licenseReport.VehicleCategory = Convert.ToString(ddlCategory.SelectedItem.Value);
            licenseReport.LicenseStatus = Convert.ToString(ddlStatus.SelectedItem.Value);
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("LicenseReport", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@VehicleCategory", SqlDbType.VarChar);
            param1.Value = licenseReport.VehicleCategory;
            command.Parameters.Add(param1);
            SqlParameter param2 = new SqlParameter("@LicenseStatus", SqlDbType.VarChar);
            param2.Value = licenseReport.LicenseStatus;
            command.Parameters.Add(param2);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataReader sdr = command.ExecuteReader();

            if (sdr.Read())
            {
                lblVehicleCategory.Visible = false;
                lblVehicleStatus.Visible = false;
                ddlCategory.Visible = false;
                ddlStatus.Visible = false;
                lblCategory.Visible = true;
                lblDisplayCategory.Visible = true;
                lblDisplayCategory.Text = ddlCategory.SelectedItem.Value;
                lblStatus.Visible = true;
                lblDisplayStatus.Visible = true;
                lblDisplayStatus.Text = ddlStatus.SelectedItem.Value;
                GridView1.Visible = true;
                GridView1.DataSource = dt;
                GridView1.DataBind();
                
            }
            else
            {
                lblVehicleCategory.Visible = false;
                lblVehicleStatus.Visible = false;
                ddlCategory.Visible = false;
                ddlStatus.Visible = false;
                lblCategory.Visible = true;
                lblStatus.Visible = true;
                lblDisplayCategory.Visible = true;
                lblDisplayCategory.Text = ddlCategory.SelectedItem.Value;
                lblDisplayStatus.Visible = true;
                lblDisplayStatus.Text = ddlStatus.SelectedItem.Value;
                lblDisplay.Visible = true;
                lblDisplay.Text = "No Records Found";

            }
            sqlConnection.Close();
           
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            lblVehicleCategory.Visible = true;
            lblVehicleStatus.Visible = true;
            ddlCategory.Visible = true;
            ddlStatus.Visible = true;
            lblCategory.Visible = false;
            lblDisplayCategory.Visible = false;
            lblStatus.Visible = false;
            lblDisplayStatus.Visible = false;
            GridView1.Visible = false;
            lblDisplay.Visible = false;
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            RTOnav.Visible = false;
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=LicenseReport.pdf");
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
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HOME/Reports.aspx");
        }
    }
}