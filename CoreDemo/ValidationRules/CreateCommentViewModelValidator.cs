using CoreDemo.Models;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace CoreDemo.ValidationRules
{
    public class CreateCommentViewModelValidator:AbstractValidator<CreateCommentViewModel>
    {
        public CreateCommentViewModelValidator(IStringLocalizer<BaseViewModel> baseLocalizer,IStringLocalizer<CreateCommentViewModel> mainLocalizer)
        {
            RuleFor(x => x.Detail)
                .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty", mainLocalizer["Detail"]])
                .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["Detail"]])
                .MinimumLength(3).WithMessage(baseLocalizer["PropertyMinimumLength", mainLocalizer["Detail"], 3])
                .MaximumLength(200).WithMessage(baseLocalizer["PropertyMaximumLength", mainLocalizer["Detail"], 200])
                ;
        }
    }
}
