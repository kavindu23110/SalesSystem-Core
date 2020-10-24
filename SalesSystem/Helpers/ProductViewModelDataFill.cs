using AutoMapper;
using SalesSystem.BLL.DataRetrivalOperations;
using SalesSystem.BLL.Interfaces;
using SalesSystem.Interfaces;
using SalesSystem.Models;
using System.Collections.Generic;

namespace SalesSystem.Helpers
{
    //Class For Fill data to ViewModels
    public class ProductViewModelDataFill : IDataFill
    {
        private readonly ProductdataRetrival dataRetrieve;
        private readonly IMapper _mapper;

        public ProductViewModelDataFill()
        {
            dataRetrieve=new ProductdataRetrival();
        }

      
        public void FillProductViewModel(ref ProductViewModel ProductViewModel)
        {
            //Service provided By DI Container  
            //A singleton Service

            ProductViewModel.lstSupplierName = (dataRetrieve).GetSuppliers();
            ProductViewModel.lstSupplierName.Insert(0, "--Select Option--");
            ProductViewModel.lstBrandIdName = (dataRetrieve).GetBrands() ;
            ProductViewModel.lstBrandIdName.Insert(0, "--Select Option--");
            ProductViewModel.lstProductCategory= (dataRetrieve).GetProductCategory();
            ProductViewModel.lstProductCategory.Insert(0, "--Select Option--");

       
       

        }

    }
}
