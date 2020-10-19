using AutoMapper;
using SalesSystem.BLL.DataRetrivalOperations;
using SalesSystem.BLL.Interfaces;
using SalesSystem.Interfaces;
using SalesSystem.Models;

namespace SalesSystem.Helpers
{
    //Class For Fill data to ViewModels
    public class ViewModelDataFill : IDataFill
    {
        private readonly IDataRetrival dataRetrieve;
        private readonly IMapper _mapper;

        public ViewModelDataFill(IDataRetrival dataRetrival)
        {
            dataRetrieve = dataRetrival;

        }
        //Fill the userviewModel Drop down
        public void FillUserViewModel(ref UserViewModel userViewModel)
        {
            //Service provided By DI Container  
            //A singleton Service
            userViewModel.lstUserTypes = ((User_RoledataRetrival)dataRetrieve).GetRoles();

        }
    }
}
