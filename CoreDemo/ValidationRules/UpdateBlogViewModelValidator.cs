using CoreDemo.Models;
using FluentValidation;

namespace CoreDemo.ValidationRules
{
    public class UpdateBlogViewModelValidator : AbstractValidator<UpdateBlogViewModel>
    {
        public UpdateBlogViewModelValidator()
        {

            RuleFor(x => x.BlogMainImage).SetValidator(new ImageValidator());
            RuleFor(x => x.BlogThumbnailImage).SetValidator(new ImageValidator());

            RuleFor(x => x.BlogTitle).MinimumLength(3).WithMessage("3");
        }
    }
}
