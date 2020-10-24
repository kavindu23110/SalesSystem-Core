using AutoMapper;
using SalesSystem.BLL.DTO;
using SalesSystem.Models;

namespace SalesSystem.DTOMapping
{
    public class UserViewModelProfile : Profile
    {
        public UserViewModelProfile()
        {
            CreateMap<UserViewModel, DTO_User>().ReverseMap();
        }
    }
}
