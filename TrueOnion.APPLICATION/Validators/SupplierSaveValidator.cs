using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Supplier;

namespace TrueOnion.APPLICATION.Validators
{
    public class SupplierSaveValidator : AbstractValidator<SupplierSaveVM>
    {
        public SupplierSaveValidator()
        {
            RuleFor(x => x.CompanyName)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is required");
            RuleFor(x=>x.Address)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is required");
        }
    }
}
