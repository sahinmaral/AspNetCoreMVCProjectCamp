using CoreDemo.Models;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace CoreDemo.ValidationRules
{
    public class CreateMessageViewModelValidator:AbstractValidator<CreateMessageViewModel>
    {
        public CreateMessageViewModelValidator(IStringLocalizer<BaseViewModel> baseLocalizer,IStringLocalizer<CreateMessageViewModel> mainLocalizer)
        {
            // Subject

            RuleFor(x => x.Subject)
                .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty",mainLocalizer["Subject"]])
                .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["Subject"]])
                .MinimumLength(3).WithMessage(baseLocalizer["PropertyMinimumLength", mainLocalizer["Subject"], 10])
                .MaximumLength(80).WithMessage(baseLocalizer["PropertyMaximumLength", mainLocalizer["Subject"], 80])
                ;

            // Detail

            RuleFor(x => x.Detail).NotNull().WithMessage(mainLocalizer["ProperyCannotBeNull", mainLocalizer["Detail"]]);
            RuleFor(x => x.Detail).NotEmpty().WithMessage(mainLocalizer["ProperyCannotBeEmpty", mainLocalizer["Detail"]]);
            RuleFor(x => x.Detail).MinimumLength(3).WithMessage(mainLocalizer["PropertyMinimumLength", mainLocalizer["Detail"], 3]);
            RuleFor(x => x.Detail).MaximumLength(10000).WithMessage(mainLocalizer["PropertyMaximumLength", mainLocalizer["Detail"], 10000]);
        }
    }
}
