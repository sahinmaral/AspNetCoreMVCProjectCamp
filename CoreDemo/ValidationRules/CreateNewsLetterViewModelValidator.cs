using CoreDemo.Models;
using FluentValidation;

using Microsoft.Extensions.Localization;

namespace CoreDemo.ValidationRules
{
    public class CreateNewsLetterViewModelValidator:AbstractValidator<CreateNewsLetterViewModel>
    {
        public CreateNewsLetterViewModelValidator(IStringLocalizer<BaseViewModel> baseLocalizer,IStringLocalizer<CreateNewsLetterViewModel> mainLocalizer)
        {

            RuleFor(x=>x.Email)
                .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["Email"]])
                .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty", mainLocalizer["Email"]])
                .EmailAddress().WithMessage(mainLocalizer["EmailCannotBeInvalid"])
                ;
        }
    }
}
