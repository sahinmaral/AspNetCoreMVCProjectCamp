using CoreDemo.Models;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace CoreDemo.ValidationRules
{
    public class UserSignInViewModelValidator : AbstractValidator<UserSignInViewModel>
    {
        public UserSignInViewModelValidator(IStringLocalizer<UserSignInViewModel> mainLocalizer,IStringLocalizer<BaseViewModel> baseLocalizer)
        {
            // Username

            RuleFor(x => x.Username)
                .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["Username"]])
                .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty", mainLocalizer["Username"]])
                .MinimumLength(5).WithMessage(baseLocalizer["PropertyMinimumLength", mainLocalizer["Username"],5])
                .MaximumLength(30).WithMessage(baseLocalizer["PropertyMaximumLength", mainLocalizer["Username"],30])
                ;

            // Password

            RuleFor(x => x.Password)
                .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["Password"]])
                .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty", mainLocalizer["Password"]])
                .MinimumLength(8).WithMessage(baseLocalizer["PropertyMinimumLength", mainLocalizer["Password"],8])
                .MaximumLength(30).WithMessage(baseLocalizer["PropertyMaximumLength", mainLocalizer["Password"],30])
                ;


        }

    }
}
