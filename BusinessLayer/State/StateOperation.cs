using DataLayer.State;
using DataModel_Layer.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer.State;

namespace BusinessLayer.State
{
    public class StateOperation
    {
        public void SaveStateDetails(StateViewModel stateViewModel)
        {
            StateDataModel stateDataModel = new StateDataModel();
            stateDataModel.StateNo = stateViewModel.StateNo;
            stateDataModel.StateName = stateViewModel.StateName;
            StateDataOperation stateDataOperation = new StateDataOperation();
            stateDataOperation.SaveState(stateDataModel);

        }
    }
}
