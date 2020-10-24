using AutoMapper;
using SalesSystem.BLL.DTO;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.DTOMapping
{
    public class PromotionViewModelProfile:Profile
    {
        public PromotionViewModelProfile()
        {
            CreateMap<PromotionViewModel, DTO_Promotion>().ReverseMap();
        }
    }
}
