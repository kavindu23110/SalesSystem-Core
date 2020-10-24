using AutoMapper;
using SalesSystem.BLL.DataRetrivalOperations;
using SalesSystem.BLL.Interfaces;
using SalesSystem.Interfaces;
using SalesSystem.Models;

namespace SalesSystem.Helpers
{
    //Class For Fill data to ViewModels
    public class UserViewModelDataFill : IDataFill
    {
        private readonly IDataRetrival dataRetrieve;


        public UserViewModelDataFill(IDataRetrival dataRetrival)
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
        public void FillProductViewModel(ref ProductViewModel ProductViewModel)
        {
            //Service provided By DI Container  
            //A singleton Service

            ProductViewModel.lstSupplierName = ((ProductdataRetrival)dataRetrieve).GetSuppliers();
            ProductViewModel.lstBrandIdName = ((ProductdataRetrival)dataRetrieve).GetBrands();
            ProductViewModel.lstProductCategory= ((ProductdataRetrival)dataRetrieve).GetProductCategory();
          //  ProductViewModel.lstProductCategory= ((ProductdataRetrival)dataRetrieve).GetProductType();
            //   ProductViewModel.lstparts = ((ProductdataRetrival)dataRetrieve).GetParts();

        }

        public bool CheckForUserNameAcvilability(string userName)
        {
            //Service provided By DI Container  
            //A singleton Service
          return ((User_RoledataRetrival)dataRetrieve).CheckUserNameAvilability(userName);

        }
    }
}
