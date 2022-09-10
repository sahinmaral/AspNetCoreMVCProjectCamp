using CoreDemo.Controllers;
using CoreDemo.Models;
using FluentValidation;

using Microsoft.Extensions.Localization;

namespace CoreDemo.ValidationRules
{
    public class CreateNewsLetterViewModelValidator:AbstractValidator<CreateNewsLetterViewModel>
    {
        public CreateNewsLetterViewModelValidator(IStringLocalizer<NewsLetterController> localizer)
        {
            var stringLocalizer = localizer;

            RuleFor(x=>x.Email)
                .NotNull().WithMessage(stringLocalizer["EmailCannotBeNull"])
                .EmailAddress().WithMessage(stringLocalizer["EmailCannotBeInvalid"])
                
                ;
        }
    }
}
