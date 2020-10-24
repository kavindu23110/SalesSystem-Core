using AutoMapper;
using SalesSystem.BLL.DTO;
using SalesSystem.Models;

namespace SalesSystem.API.DTOMapping
{
    public class LoginViewProfile : Profile
    {
        public LoginViewProfile()
        {
            CreateMap<LoginviewModel, DTO_User>().ReverseMap();
        }
}
}
