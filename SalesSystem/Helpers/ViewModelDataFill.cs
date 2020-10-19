using AutoMapper;
using SalesSystem.BLL.DataRetrivalOperations;
using SalesSystem.BLL.Interfaces;
using SalesSystem.Interfaces;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Helpers
{
    public class ViewModelDataFill:IDataFill
    {
        private readonly IDataRetrival dataRetrieve;
        private readonly IMapper _mapper;

        public ViewModelDataFill(IDataRetrival dataRetrival)
        {
            dataRetrieve = dataRetrival;
    
        }
       public void FillUserViewModel(ref UserViewModel userViewModel)
        {
           userViewModel.lstUserTypes =((User_RoledataRetrival)dataRetrieve).GetRoles();
       
        }
    }
}
