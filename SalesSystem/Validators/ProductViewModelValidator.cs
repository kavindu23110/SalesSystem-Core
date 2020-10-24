using FluentValidation;
using SalesSystem.Models;

namespace SalesSystem.Validators
{
    public class ProductViewModelValidator : AbstractValidator<ProductViewModel>
    {
        public ProductViewModelValidator()
        {
            RuleFor(p => p.BrandName).NotEmpty().NotEqual("--Select Option--");
            RuleFor(p => p.Cost).NotEmpty().GreaterThan(0);
            RuleFor(p => p.Details).NotEmpty();
            RuleFor(p => p.ModelName).NotEmpty();
            RuleFor(p => p.ProductCategory).NotEmpty().NotEqual("--Select Option--");
            RuleFor(p => p.ProductType).NotEmpty().NotEqual("--Select Option--");
            RuleFor(p => p.ProfitMargin).NotEmpty();
            RuleFor(p => p.SupplierName).NotEmpty().NotEqual("--Select Option--");
            RuleFor(p => p.warrenty).NotEmpty();
        }

    }
}
