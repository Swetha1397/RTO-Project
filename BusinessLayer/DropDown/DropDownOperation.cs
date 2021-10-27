using DataLayer.DropDown;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace BusinessLayer.DropDown
{
    public class DropDownOperation
    {
        public void StateDropDowninDistrict(DropDownList dropDownList)
        {
            //DropDownList dropDownList = new DropDownList();
            DropDownDataOperation dropDownDataOperation = new DropDownDataOperation();

            dropDownDataOperation.GetStateDropdowns(dropDownList);
            //return dropDownList;
        }

        public void DistrictDropDowninDistrict(DropDownList dropDownListDistrict , DropDownList dropDownListState)
        {
            //DropDownList dropDownList = new DropDownList();
            DropDownDataOperation dropDownDataOperation = new DropDownDataOperation();

            dropDownDataOperation.GetDistrictDropdowns(dropDownListDistrict,dropDownListState);
            //return dropDownList;
        }

        public void CityDropDowninDistrict(DropDownList dropDownListCity, DropDownList dropDownListDistrict)
        {
            //DropDownList dropDownList = new DropDownList();
            DropDownDataOperation dropDownDataOperation = new DropDownDataOperation();

            dropDownDataOperation.GetCityDropdowns(dropDownListCity, dropDownListDistrict);
            //return dropDownList;
        }

        public void RTODropDowninDistrict(DropDownList dropDownListRto, DropDownList dropDownListCity)
        {
            //DropDownList dropDownList = new DropDownList();
            DropDownDataOperation dropDownDataOperation = new DropDownDataOperation();

            dropDownDataOperation.GetRTODropdowns(dropDownListRto, dropDownListCity);
            //return dropDownList;
        }
        public void AreaDropDown(DropDownList dropDownListArea, string RTO)
        {
            //DropDownList dropDownList = new DropDownList();
            DropDownDataOperation dropDownDataOperation = new DropDownDataOperation();

            dropDownDataOperation.GetAreaDropdowns(dropDownListArea, RTO);
            //return dropDownList;
        }
    }
}
