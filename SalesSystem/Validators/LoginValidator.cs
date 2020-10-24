using FluentValidation;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
