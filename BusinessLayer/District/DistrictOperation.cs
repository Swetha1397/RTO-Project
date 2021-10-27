using DataLayer.District;
using DataModel_Layer.District;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using ViewLayer.District;

namespace BusinessLayer.District
{
    public class DistrictOperation
    {
        public void SaveDistrictDetails(DistrictViewModel districtViewModel)
        {
            DistrictDataModel districtDataModel = new DistrictDataModel();
            districtDataModel.DistrictNo = districtViewModel.DistrictNo;
            districtDataModel.DistrictName = districtViewModel.DistrictName;
            districtDataModel.StateNo = districtViewModel.StateNo;
            DistrictDataOperation districtDataOperation = new DistrictDataOperation();
            districtDataOperation.SaveDistrict(districtDataModel);

        }

      
    }
}
