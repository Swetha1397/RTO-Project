using DataLayer.Login;
using DataModel_Layer.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer.Login;

namespace BusinessLayer.Login
{
    public class LoginOperation
    {
        public int RTOLogin(LoginViewModel loginViewModel)
        {
            LoginDataModel loginDataModel = new LoginDataModel();
            loginDataModel.RTO_No = loginViewModel.RTO_No;
            loginDataModel.Password = loginViewModel.Password;


            LoginDataOperation loginDataOperation = new LoginDataOperation();
            int verify = loginDataOperation.LoginRTO(loginDataModel);
            return verify;
        }
    }
}

