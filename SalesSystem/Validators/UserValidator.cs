using FluentValidation;
using SalesSystem.Helpers;
using SalesSystem.Models;

namespace SalesSystem.Validators
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {

            RuleFor(p => p.Email).EmailAddress().NotEmpty();
            RuleFor(p => p.username).NotEmpty();
            RuleFor(p => p.username).Must(p=> new UserViewModelDataFill().CheckForUserNameAcvilability(p)).NotEmpty();
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Lastname).NotEmpty();
            RuleFor(p => p.ContactNo).NotEmpty();
            RuleFor(p => p.UserType).NotEmpty().NotEqual("--Select Option--");

     


        }
    }
}
