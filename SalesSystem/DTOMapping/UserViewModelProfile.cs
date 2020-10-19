using AutoMapper;
using SalesSystem.BLL.DTO;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.DTOMapping
{
    public class UserViewModelProfile:Profile
    {
        public UserViewModelProfile()
        {
            CreateMap<UserViewModel, DTO_User>().ReverseMap();
        }
    }
}
