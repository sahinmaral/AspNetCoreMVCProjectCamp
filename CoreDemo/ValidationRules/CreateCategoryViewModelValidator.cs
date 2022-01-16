using CoreDemo.Models;
using FluentValidation;

namespace CoreDemo.ValidationRules
{
    public class CreateCategoryViewModelValidator:AbstractValidator<CreateCategoryViewModel>
    {
        public CreateCategoryViewModelValidator()
        {
            RuleFor(x => x.CategoryName)
                .NotNull().WithMessage("Başlık yazmanız gerekir")
                .MinimumLength(3).WithMessage("Başlık en az 3 karakterden oluşmalıdır")
                .MaximumLength(50).WithMessage("Başlık en fazla 500 karakterden oluşmalıdır");
            
            RuleFor(x => x.CategoryDescription)
                .NotNull().WithMessage("İçerik yazmanız gerekir")
                .MinimumLength(3).WithMessage("İçerik en az 10 karakterden oluşmalıdır")
                .MaximumLength(500).WithMessage("İçerik en fazla 500 karakterden oluşmalıdır");

            
            
        }
    }
}