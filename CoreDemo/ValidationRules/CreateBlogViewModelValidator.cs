using CoreDemo.Models;
using FluentValidation;

namespace CoreDemo.ValidationRules
{
    public class CreateBlogViewModelValidator:AbstractValidator<CreateBlogViewModel>
    {
        public CreateBlogViewModelValidator()
        {
            RuleFor(x => x.BlogTitle)
                .NotNull().WithMessage("Başlık yazmanız gerekir")
                .MinimumLength(3).WithMessage("Başlık en az 3 karakterden oluşmalıdır")
                .MaximumLength(50).WithMessage("Başlık en fazla 50 karakterden oluşmalıdır");
            
            RuleFor(x => x.BlogContent)
                .NotNull().WithMessage("İçerik yazmanız gerekir")
                .MinimumLength(3).WithMessage("İçerik en az 3 karakterden oluşmalıdır")
                .MaximumLength(500).WithMessage("İçerik en fazla 500 karakterden oluşmalıdır");

            RuleFor(x => x.CategoryId)
                .NotEqual(0).WithMessage("Bir tane kategori seçmeniz gerekiyor")
                .GreaterThan(0).WithMessage("Kategori ID , 0'dan büyük olmalıdır");
            
            
        }
    }
}