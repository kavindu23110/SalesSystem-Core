using FluentValidation;
using SalesSystem.Models;
using System;

namespace SalesSystem.Validators
{
    public class Promotionvalidator : AbstractValidator<PromotionViewModel>
    {
        public Promotionvalidator()
        {

            RuleFor(p => p.DealerName).NotEmpty().NotEqual("--Select Option--");
            RuleFor(p => p.description).NotEmpty();
            RuleFor(p => p.DiscountPercentage).GreaterThan(0);
            RuleFor(p => p.EndDate).GreaterThan(p => p.StartDate);
            RuleFor(p => p.StartDate).GreaterThanOrEqualTo(DateTime.Today);
            RuleFor(p => p.Promotion).NotEmpty().NotEqual("--Select Option--");

        }
    }
}
