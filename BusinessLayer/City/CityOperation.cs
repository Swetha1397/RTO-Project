using DataLayer.City;
using DataModel_Layer.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer.City;

namespace BusinessLayer.City
{
    public class CityOperation
    {
        public void SaveCityDetails(CityViewModel cityViewModel)
        {
            CityDataModel cityDataModel = new CityDataModel();
            cityDataModel.CityNo = cityViewModel.CityNo;
            cityDataModel.CityName = cityViewModel.CityName;
            cityDataModel.StateNo = cityViewModel.StateNo;
            cityDataModel.DistrictNo = cityViewModel.DistrictNo;
            CityDataOperation cityDataOperation = new CityDataOperation();
            cityDataOperation.SaveCity(cityDataModel);
        }
    }
}