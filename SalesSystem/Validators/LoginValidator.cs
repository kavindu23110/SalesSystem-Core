using FluentValidation;
using SalesSystem.Models;

namespace SalesSystem.Validators
{
    public class LoginValidator : AbstractValidator<LoginviewModel>
    {
        public LoginValidator()
        {
            RuleFor(p => p.username).NotEmpty();
            RuleFor(p => p.password).NotEmpty();
        }
    }
}
