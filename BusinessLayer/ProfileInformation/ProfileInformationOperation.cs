using DataLayer.ProfileInformation;
using DataModel_Layer.ProfileInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer.ProfileInformation;

namespace BusinessLayer.ProfileInformation
{
    public class ProfileInformationOperation
    {
        public void RTOProfileInformation(ProfileInformationViewModel profileInformationViewModel)
        {
            ProfileInformationDataModel profileInformationDataModel = new ProfileInformationDataModel();
            profileInformationDataModel.FName = profileInformationViewModel.FName;
            profileInformationDataModel.LName = profileInformationViewModel.LName;
            profileInformationDataModel.DOB = profileInformationViewModel.DOB;
            profileInformationDataModel.AadharNo = profileInformationViewModel.AadharNo;
            profileInformationDataModel.Address = profileInformationViewModel.Address;
            profileInformationDataModel.StateNo = profileInformationViewModel.StateNo;
            profileInformationDataModel.DistrictNo = profileInformationViewModel.DistrictNo;
            profileInformationDataModel.CityNo = profileInformationViewModel.CityNo;
            profileInformationDataModel.AreaNo = profileInformationViewModel.AreaNo;

            ProfileInformationDataOperation profileInformationDataOperation = new ProfileInformationDataOperation();

            profileInformationDataOperation.SaveProfile(profileInformationDataModel);
        }
        public ProfileInformationViewModel GetAddressDetails(string RTO)
        {
            ProfileInformationViewModel profileInformationViewModel = new ProfileInformationViewModel();
            ProfileInformationDataModel profileInformationDataModel = new ProfileInformationDataModel();

            ProfileInformationDataOperation profileInformationDataOperation = new ProfileInformationDataOperation();
            profileInformationDataModel = profileInformationDataOperation.GetAddressDetails(RTO);
            profileInformationViewModel.State = profileInformationDataModel.State;
            profileInformationViewModel.District = profileInformationDataModel.District;
            profileInformationViewModel.City = profileInformationDataModel.City;
            profileInformationViewModel.StateNo = profileInformationDataModel.StateNo;
            profileInformationViewModel.DistrictNo = profileInformationDataModel.DistrictNo;
            profileInformationViewModel.CityNo = profileInformationDataModel.CityNo;
            //profileInformationViewModel.AreaNo = profileInformationDataModel.AreaNo;
            
            return profileInformationViewModel;
        }

        
    }
}
