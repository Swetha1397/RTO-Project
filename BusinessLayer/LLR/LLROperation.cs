using DataLayer.LLR;
using DataModel_Layer.LLR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer.LLR;

namespace BusinessLayer.LLR
{
    public class LLROperation
    {
        public void SaveLLR(LLRViewModel lLRViewModel)
        {
            LLRDataModel lLRDataModel = new LLRDataModel();

            lLRDataModel.AadharNo = lLRViewModel.AadharNo;
            lLRDataModel.VehicleCategory = lLRViewModel.VehicleCategory;
            lLRDataModel.LLRNo = lLRViewModel.LLRNo;
            
            LLRDataOperation llrdataOperation = new LLRDataOperation();
            llrdataOperation.SaveLLRDetails(lLRDataModel);


        }
        public string GetRegNo(string rtoNo)
        {
            //NewVehicleRegistrationViewModel newVehicleRegistrationViewModel = new NewVehicleRegistrationViewModel();
            LLRDataModel lLRDataModel = new LLRDataModel();
            LLRDataOperation lLRDataOperation = new LLRDataOperation();
            string RegNo = lLRDataOperation.GenerateRegNo(rtoNo);
            return RegNo;
        }
    }
}
