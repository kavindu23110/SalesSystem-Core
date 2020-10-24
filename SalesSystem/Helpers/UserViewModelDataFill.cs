using SalesSystem.BLL.DataRetrivalOperations;
using SalesSystem.Interfaces;
using SalesSystem.Models;

namespace SalesSystem.Helpers
{
    //Class For Fill data to ViewModels
    public class UserViewModelDataFill : IDataFill
    {
        private readonly User_RoledataRetrival dataRetrieve;




        public UserViewModelDataFill()
        {
            dataRetrieve = new User_RoledataRetrival();
        }

        //Fill the userviewModel Drop down
        public void FillUserViewModel(ref UserViewModel userViewModel)
        {
            //Service provided By DI Container  
            //A singleton Service
            userViewModel.lstUserTypes = ((User_RoledataRetrival)dataRetrieve).GetRoles();

        }


        public bool CheckForUserNameAcvilability(string userName)
        {
            //Service provided By DI Container  
            //A singleton Service
            return ((User_RoledataRetrival)dataRetrieve).CheckUserNameAvilability(userName);

        }
    }
}
