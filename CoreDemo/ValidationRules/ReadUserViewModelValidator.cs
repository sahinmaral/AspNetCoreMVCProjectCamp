using CoreDemo.Models;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace CoreDemo.ValidationRules
{
    public class ReadUserViewModelValidator:AbstractValidator<ReadUserViewModel>
    {
        public ReadUserViewModelValidator(IStringLocalizer<BaseViewModel> baseLocalizer,IStringLocalizer<ReadUserViewModel> mainLocalizer)
        {
            RuleFor(x => x.About)
                .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty",mainLocalizer["About"]])
                .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["About"]])
                .MinimumLength(10).WithMessage(baseLocalizer["PropertyMinimumLength", mainLocalizer["About"],10])
                .MaximumLength(200).WithMessage(baseLocalizer["PropertyMaximumLength", mainLocalizer["About"],200])
                ;
        }
    }
}
