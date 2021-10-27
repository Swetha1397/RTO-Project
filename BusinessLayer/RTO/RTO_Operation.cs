using DataLayer.RTO;
using DataModel_Layer.RTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer.RTO;

namespace BusinessLayer.RTO
{
    public class RTO_Operation
    {
        public void SaveRTODetails(RTOViewModel rtoViewModel)
        {
            RTODataModel rtoDataModel = new RTODataModel();

            rtoDataModel.RTONo = rtoViewModel.RTONo;
            rtoDataModel.RTOName = rtoViewModel.RTOName;
            rtoDataModel.StateNo = rtoViewModel.StateNo;
            rtoDataModel.DistrictNo = rtoViewModel.DistrictNo;
            rtoDataModel.CityNo = rtoViewModel.CityNo;
            RTODataOperation rtoDataOperation = new RTODataOperation();
            rtoDataOperation.SaveRTO(rtoDataModel);

        }
    }
}