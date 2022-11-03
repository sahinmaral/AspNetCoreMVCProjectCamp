using CoreDemo.Models;
using FluentValidation;
using Microsoft.Extensions.Localization;
using System.Text.RegularExpressions;

namespace CoreDemo.ValidationRules
{
    public class UserPasswordViewModelValidator:AbstractValidator<UserPasswordViewModel>
    {
        public UserPasswordViewModelValidator(IStringLocalizer<UserPasswordViewModel> mainLocalizer, IStringLocalizer<BaseViewModel> baseLocalizer)
        {
            // NewPassword

            RuleFor(x => x.NewPassword)
            .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["Password"]])
            .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty", mainLocalizer["Password"]])
            .MinimumLength(8).WithMessage(baseLocalizer["PropertyMinimumLength", mainLocalizer["Password"],8])
            .MaximumLength(30).WithMessage(baseLocalizer["PropertyMaximumLength", mainLocalizer["Password"],30])
            .Must(PasswordAtLeastLowerCaseLetter).WithMessage(mainLocalizer["PasswordAtLeastLowerCaseLetter"])
            .Must(PasswordAtLeastNumber).WithMessage(mainLocalizer["PasswordAtLeastNumber"])
            .Must(PasswordAtLeastUpperCaseLetter).WithMessage(mainLocalizer["PasswordAtLeastUpperCaseLetter"])
            .Must(PasswordAtLeastSpecialCaseCharacter).WithMessage(mainLocalizer["PasswordAtLeastSpecialCaseCharacter"])
            ;

            // ConfirmPassword

            RuleFor(x => x.ConfirmPassword)
                .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["ConfirmPassword"]])
                .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty", mainLocalizer["ConfirmPassword"]])
                .Equal(x => x.ConfirmPassword).WithMessage(mainLocalizer["ConfirmPasswordIsNotEqualToPassword"])
                ;

        }

        public bool PasswordAtLeastLowerCaseLetter(string password)
        {
            var hasLowerChar = new Regex(@"[a-z]+");
            return password != null && hasLowerChar.IsMatch(password);
        }

        public bool PasswordAtLeastNumber(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            return password != null && hasNumber.IsMatch(password);
        }

        public bool PasswordAtLeastUpperCaseLetter(string password)
        {
            var hasUpperChar = new Regex(@"[A-Z]+");
            return password != null && hasUpperChar.IsMatch(password);
        }

        public bool PasswordAtLeastSpecialCaseCharacter(string password)
        {
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            return password != null && hasSymbols.IsMatch(password);
        }
    }
}
