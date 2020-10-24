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

            userViewModel.lstUserTypes = (dataRetrieve).GetRoles();
            userViewModel.lstUserTypes.Insert(0, "--Select Option--");

        }


        public bool CheckForUserNameAcvilability(string userName)
        {


            return (dataRetrieve).CheckUserNameAvilability(userName);

        }
    }
}
