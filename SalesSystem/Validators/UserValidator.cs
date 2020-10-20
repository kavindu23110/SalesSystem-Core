using FluentValidation;
using SalesSystem.Models;

namespace SalesSystem.Validators
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {

            RuleFor(p => p.Email).EmailAddress().NotEmpty();
            RuleFor(p => p.username).NotEmpty();
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Lastname).NotEmpty();
            RuleFor(p => p.ContactNo).NotEmpty();
            RuleFor(p => p.UserType).NotEmpty().NotEqual("select");
      
        }
    }
}
