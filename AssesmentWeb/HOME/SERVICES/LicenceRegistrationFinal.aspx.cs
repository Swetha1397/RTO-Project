using BusinessLayer.Licence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ViewLayer.Licence;



namespace AssesmentWeb.HOME.SERVICES
{
    public partial class LicenceRegistationFinal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }



        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LicenceViewModel licenceViewModel = new LicenceViewModel();
            licenceViewModel.LLRNo = txtLLRNo.Text;
            int Verify = CheckLLR(licenceViewModel.LLRNo);
            LicenceOperation licenceOperation = new LicenceOperation();
            if (Verify == 1)
            {
                string rtoNo = Session["RTONO"].ToString();
                licenceViewModel.LicenseNo = licenceOperation.GetRegNo(rtoNo);
                int Status = licenceOperation.SaveLicence(licenceViewModel);
                if (Status == -2)
                {
                    MessageBox.Show("LLR expired");
                    //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('LLR expired')", true);
                    Response.Redirect("/HOME/Service");
                }
                else if (Status == -1)
                {
                    MessageBox.Show("Licence should be applied after 2 months of the LLR registration Date");
                    //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Licence should be applied after 2 months of the LLR registration Date')", true);
                    Response.Redirect("/HOME/Service");
                }
                else if (Status == 1)
                {
                    MessageBox.Show("Licence Registration No:" + licenceViewModel.LicenseNo);
                    //Response.Write("<script>alert('Licence Registration No:" + licenceViewModel.LicenseNo + " ')</script>");
                    Response.Redirect("/HOME/Service");
                }
                else if (Status == -3)
                {
                    MessageBox.Show("Licence already applied for this LLR number");
                    //Response.Write("<script>alert('Licence already applied for this LLR number')</script>");
                    Response.Redirect("/HOME/Service");
                }
                else
                {
                    MessageBox.Show(" ");
                    //Response.Write("");
                    Response.Redirect("/HOME/Service");
                }
            }
            else
            {
                MessageBox.Show("LLR Number not found");
                //Response.Write("<script>alert('LLR Number not found ')</script>");
                Response.Redirect("/HOME/Service");
            }
        }



        private int CheckLLR(string LLRNo)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("CheckLLR", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@LLRNo", SqlDbType.VarChar);
            parameter1.Value = LLRNo;
            command.Parameters.Add(parameter1);
            int Verify = 0;
            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                Verify = Convert.ToInt32(rdr["Verification"]);
            }



            rdr.Close();
            command.ExecuteNonQuery();
            sqlConnection.Close();
            return Verify;
        }
    }
}