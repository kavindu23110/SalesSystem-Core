using FluentValidation;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Validators
{
    public class Promotionvalidator: AbstractValidator<PromotionViewModel>
    {
        public Promotionvalidator()
        {

            RuleFor(p => p.DealerName).NotEmpty();
            RuleFor(p => p.description).NotEmpty();
            RuleFor(p => p.DiscountPercentage).GreaterThan(0);
            RuleFor(p => p.EndDate).GreaterThan(p=>p.StartDate);
            RuleFor(p => p.StartDate).GreaterThanOrEqualTo(DateTime.Today);
            RuleFor(p => p.Promotion).NotEmpty().NotEqual("select");

        }
    }
}
