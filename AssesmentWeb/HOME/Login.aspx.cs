using BusinessLayer.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewLayer.Login;

namespace AssesmentWeb.HOME
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            loginViewModel.RTO_No = Convert.ToString(txtRTONo.Text);
           
            loginViewModel.Password = Convert.ToString(txtPassword.Text);
            LoginOperation loginOperation = new LoginOperation();
           int verify = loginOperation.RTOLogin(loginViewModel);
            if(verify==1)
            {   //sessions used
                Session["RTONO"] = txtRTONo.Text;
                Response.Redirect("HOME/home.aspx");
            }
            else
            {
                lblLoginSucess.Text = " INVALID RTO NO/PASSWORD  ";
            }
           
        }

        protected void BtnForgetPassword_Click(object sender, EventArgs e)
        {

        }

        protected void TextRTONo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}