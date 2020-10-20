using AutoMapper;
using SalesSystem.BLL.DTO;
using SalesSystem.Models;


namespace SalesSystem.DTOMapping
{
    public class ProductViewModelProfile:Profile
    {
        public ProductViewModelProfile()
        {
            CreateMap<ProductViewModel, DTO_Product>().ReverseMap();
        }
    }
}
