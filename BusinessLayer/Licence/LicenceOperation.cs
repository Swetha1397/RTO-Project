using DataLayer.Licence;
using DataModel_Layer.Licence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer.Licence;



namespace BusinessLayer.Licence
{
    public class LicenceOperation
    {
        public int SaveLicence(LicenceViewModel licenceViewModel)
        {
            LicenceDataModel licenceDataModel = new LicenceDataModel();
            licenceDataModel.LLRNo = licenceViewModel.LLRNo;
            licenceDataModel.LicenseNo = licenceViewModel.LicenseNo;
            LicenceDataOperation licenceDataOperation = new LicenceDataOperation();
            int Status = licenceDataOperation.SaveLicenceDetails(licenceDataModel);
            return Status;



        }



        public string GetRegNo(string rtoNo)
        {

            LicenceDataModel licenceDataModel = new LicenceDataModel();
            LicenceDataOperation licenceDataOperation = new LicenceDataOperation();
            string RegNo = licenceDataOperation.GenerateLicenceRegNo(rtoNo);
            return RegNo;
        }
    }
}