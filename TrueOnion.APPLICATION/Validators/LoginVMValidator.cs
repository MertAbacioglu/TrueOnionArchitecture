using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.AppUser;

namespace TrueOnion.APPLICATION.Validators
{
    public class LoginVMValidator : AbstractValidator<AppUserLoginVM>
    {
        public LoginVMValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} is required");
                                 
            RuleFor(x => x.Password).NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} is required");

        }
    }
}
