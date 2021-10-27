using DataLayer.NewVehicleRegistration;
using DataModel_Layer.NewVehicleRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer.NewVehicleRegistration;

namespace BusinessLayer.NewVehicleRegistration
{
    public class NewVehicleRegistrationOperation
    {
        public void SaveVehicleRegistrationDetails(NewVehicleRegistrationViewModel newVehicleRegistrationViewModel)
        {
            NewVehicleRegistrationDataModel newVehicleRegistrationDataModel = new NewVehicleRegistrationDataModel();
            newVehicleRegistrationDataModel.AadharNo = newVehicleRegistrationViewModel.AadharNo;
            newVehicleRegistrationDataModel.RegNo = newVehicleRegistrationViewModel.RegNo;
            newVehicleRegistrationDataModel.ChasisNo = newVehicleRegistrationViewModel.ChasisNo;
            newVehicleRegistrationDataModel.EngineNo = newVehicleRegistrationViewModel.EngineNo;
            newVehicleRegistrationDataModel.VehicleName = newVehicleRegistrationViewModel.VehicleName;
            NewVehicleRegistrationDataOperation newVehicleRegistrationDataOperation = new NewVehicleRegistrationDataOperation();
            newVehicleRegistrationDataOperation.SaveVehicleRegistration(newVehicleRegistrationDataModel);
        }

        public string GetRegNo(string rtoNo)
        {
            //NewVehicleRegistrationViewModel newVehicleRegistrationViewModel = new NewVehicleRegistrationViewModel();
            NewVehicleRegistrationDataModel newVehicleRegistrationDataModel = new NewVehicleRegistrationDataModel();
            NewVehicleRegistrationDataOperation newVehicleRegistrationDataOperation = new NewVehicleRegistrationDataOperation();
            string RegNo = newVehicleRegistrationDataOperation.GenerateRegNo(rtoNo);
            return RegNo;
        }
    }
}
