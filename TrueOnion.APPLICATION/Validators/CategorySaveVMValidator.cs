using FluentValidation;
using TrueOnion.APPLICATION.ViewModels.Category;

namespace TrueOnion.APPLICATION.Validators
{
    public class CategorySaveVMValidator : AbstractValidator<CategorySaveVM>
    {
        public CategorySaveVMValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("{PropertyName} is required")
                .NotEmpty()
                .WithMessage("{PropertyName} is required");
        }
    }
}
