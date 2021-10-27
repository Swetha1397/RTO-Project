using DataLayer.Area;
using DataModel_Layer.Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer.Area;

namespace BusinessLayer.Area
{
    public class AreaOperation
    {
        public void SaveAreaDetails(AreaViewModel areaViewModel)
        {
            AreaDataModel areaDataModel = new AreaDataModel();
            areaDataModel.AreaNo = areaViewModel.AreaNo;
            areaDataModel.AreaName = areaViewModel.AreaName;
            areaDataModel.RTONo = areaViewModel.RTONo;
            areaDataModel.CityNo = areaViewModel.CityNo;
            areaDataModel.StateNo = areaViewModel.StateNo;
            areaDataModel.DistrictNo = areaViewModel.DistrictNo;
            AreaDataOperation areaDataOperation = new AreaDataOperation();
            areaDataOperation.SaveArea(areaDataModel);
        }
    }
}
