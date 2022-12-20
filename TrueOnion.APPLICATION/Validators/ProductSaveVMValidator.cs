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

            RuleFor(x => x.Price)
                .InclusiveBetween(1, int.MaxValue)
                .WithMessage("{PropertyName} must be at least {From}");
            
            RuleFor(x => x.Stock)
                .InclusiveBetween(1, int.MaxValue)
                .WithMessage("{PropertyName} must be at least {From}");
        }
    }
}