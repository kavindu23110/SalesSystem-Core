using FluentValidation;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Validators
{
    public class UserValidator:AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            RuleFor(p => p.Email).EmailAddress().NotEmpty();
            RuleFor(p => p.username).NotEmpty();
            RuleFor(p => p.Password).NotEmpty();
        }
    }
}
