using DataLayer.CheckRegistration;
using DataModel_Layer.CheckRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer.CheckRegistration;

namespace BusinessLayer.CheckRegistration
{
    public class CheckRegistrationOperation
    {
        public int CheckRegistrationRTO(CheckRegistrationViewModel checkRegistrationViewModel)
        {
            CheckRegistrationDataModel checkRegistrationDataModel = new CheckRegistrationDataModel();
            checkRegistrationDataModel.RegistrationNo = checkRegistrationViewModel.RegistrationNo;
            CheckRegistrationDataOperation checkRegistrationDataOperation = new CheckRegistrationDataOperation();
            int Verify=checkRegistrationDataOperation.RTOCheckRegistration(checkRegistrationDataModel);
            return Verify;
        }

        public void UpdateHistory(string RegNo, long Aadhar)
        {
            CheckRegistrationDataOperation checkRegistrationDataOperation = new CheckRegistrationDataOperation();
            checkRegistrationDataOperation.UpdateHistory(RegNo, Aadhar);
        }
    }
}
