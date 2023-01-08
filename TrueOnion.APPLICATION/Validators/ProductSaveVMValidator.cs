using FluentValidation;
using TrueOnion.APPLICATION.ViewModels.Product;

namespace TrueOnion.APPLICATION.Validators
{
    public class ProductSaveVMValidator :AbstractValidator<ProductSaveVM>
    {
        public ProductSaveVMValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is required");

        }
    }
}