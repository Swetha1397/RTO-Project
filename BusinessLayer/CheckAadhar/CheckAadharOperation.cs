using DataLayer.CheckAadhar;
using DataModel_Layer.CheckAadhar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer.CheckAadhar;

namespace BusinessLayer.CheckAadhar
{
    public class CheckAadharOperation
    {
        public int RTOCheckAadhar(CheckAadharViewModel checkAadharViewModel)
        {
            CheckAadharDataModel checkAadharDataModel = new CheckAadharDataModel();
            checkAadharDataModel.AadharNo = checkAadharViewModel.AadharNo;
            int Verify;
            CheckAadharDataOperation checkAadharDataOperation = new CheckAadharDataOperation();
            Verify = checkAadharDataOperation.CheckAadharRTO(checkAadharDataModel);
            return Verify;
        }
    }
}
