using CoreDemo.Controllers;
using CoreDemo.Models;

using FluentValidation;

using Microsoft.Extensions.Localization;

using System.Text.RegularExpressions;

namespace CoreDemo.ValidationRules
{
    public class UserSignUpViewModelValidator : AbstractValidator<UserSignUpViewModel>
    {
        public UserSignUpViewModelValidator(IStringLocalizer<RegisterController> localizer)
        {
            var stringLocalizer = localizer;

            RuleFor(x => x.Username)
                .NotNull().WithMessage(stringLocalizer["UsernameCannotBeNull"])
                .NotEmpty().WithMessage(stringLocalizer["UsernameCannotBeEmpty"])
                .MinimumLength(5).WithMessage(stringLocalizer["UsernameMinimumLength"])
                .MaximumLength(30).WithMessage(stringLocalizer["UsernameMaximumLength"])
                ;

            RuleFor(x => x.Password)
                .NotNull().WithMessage(stringLocalizer["PasswordCannotBeNull"])
                .NotEmpty().WithMessage(stringLocalizer["PasswordCannotBeEmpty"])
                .MinimumLength(8).WithMessage(stringLocalizer["PasswordMinimumLength"])
                .MaximumLength(30).WithMessage(stringLocalizer["PasswordMaximumLength"])
                .Must(PasswordAtLeastLowerCaseLetter).WithMessage(stringLocalizer["PasswordAtLeastLowerCaseLetter"])
                .Must(PasswordAtLeastNumber).WithMessage(stringLocalizer["PasswordAtLeastNumber"])
                .Must(PasswordAtLeastUpperCaseLetter).WithMessage(stringLocalizer["PasswordAtLeastUpperCaseLetter"])
                .Must(PasswordAtLeastSpecialCaseCharacter).WithMessage(stringLocalizer["PasswordAtLeastSpecialCaseCharacter"])
                ;

            RuleFor(x => x.ConfirmPassword)
                .NotNull().WithMessage(stringLocalizer["ConfirmPasswordCannotBeNull"])
                .NotEmpty().WithMessage(stringLocalizer["ConfirmPasswordCannotBeEmpty"])
                .Equal(x=>x.Password).WithMessage(stringLocalizer["ConfirmPasswordIsNotEqualToPassword"])
                ;

            RuleFor(x => x.IsPoliciesAccepted)
                .Equal(x => true).WithMessage(stringLocalizer["IsPoliciesAccepted"]);


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
