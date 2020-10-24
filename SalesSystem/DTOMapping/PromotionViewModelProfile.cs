using AutoMapper;
using SalesSystem.BLL.DTO;
using SalesSystem.Models;

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
