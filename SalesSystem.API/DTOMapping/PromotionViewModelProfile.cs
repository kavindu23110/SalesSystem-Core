using AutoMapper;
using SalesSystem.API.Models;
using SalesSystem.BLL.DTO;

namespace SalesSystem.DTOMapping
{
    public class PromotionViewModelProfile : Profile
    {
        public PromotionViewModelProfile()
        {
            CreateMap<PromotionViewModel, DTO_Promotion>().ReverseMap();
        }
    }
}
