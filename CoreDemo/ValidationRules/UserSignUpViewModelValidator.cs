using CoreDemo.Models;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using System.Text.RegularExpressions;

namespace CoreDemo.ValidationRules
{
    public class UserSignUpViewModelValidator : AbstractValidator<UserSignUpViewModel>
    {
        public UserSignUpViewModelValidator(IStringLocalizer<UserSignUpViewModel> mainLocalizer,IStringLocalizer<BaseViewModel> baseLocalizer)
        {

            RuleFor(x => x.NameSurname)
                .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["NameSurname"]])
                .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty", mainLocalizer["NameSurname"]])
                .MinimumLength(5).WithMessage(baseLocalizer["PropertyMinimumLength", mainLocalizer["NameSurname"], 5])
                .MaximumLength(100).WithMessage(baseLocalizer["PropertyMaximumLength", mainLocalizer["NameSurname"], 100])
                ;

            RuleFor(x => x.Email)
                .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["Email"]])
                .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty", mainLocalizer["Email"]])
                .EmailAddress().WithMessage(mainLocalizer["EmailCannotBeInvalid"])
                .MinimumLength(5).WithMessage(baseLocalizer["PropertyMinimumLength", mainLocalizer["Email"], 5])
                .MaximumLength(253).WithMessage(baseLocalizer["PropertyMaximumLength", mainLocalizer["Email"], 253])
                ;

            RuleFor(x => x.Username)
                .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["Username"]])
                .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty", mainLocalizer["Username"]])
                .MinimumLength(5).WithMessage(baseLocalizer["PropertyMinimumLength", mainLocalizer["Username"],5])
                .MaximumLength(30).WithMessage(baseLocalizer["PropertyMaximumLength", mainLocalizer["Username"],30])
                ;

            RuleFor(x => x.Password)
                .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["Password"]])
                .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty", mainLocalizer["Password"]])
                .MinimumLength(8).WithMessage(baseLocalizer["PropertyMinimumLength", mainLocalizer["Password"],8])
                .MaximumLength(30).WithMessage(baseLocalizer["PropertyMaximumLength", mainLocalizer["Password"],30])
                .Must(PasswordAtLeastLowerCaseLetter).WithMessage(mainLocalizer["PasswordAtLeastLowerCaseLetter"])
                .Must(PasswordAtLeastNumber).WithMessage(mainLocalizer["PasswordAtLeastNumber"])
                .Must(PasswordAtLeastUpperCaseLetter).WithMessage(mainLocalizer["PasswordAtLeastUpperCaseLetter"])
                .Must(PasswordAtLeastSpecialCaseCharacter).WithMessage(mainLocalizer["PasswordAtLeastSpecialCaseCharacter"])
                ;

            RuleFor(x => x.ConfirmPassword)
                .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["ConfirmPassword"]])
                .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty", mainLocalizer["ConfirmPassword"]])
                .Equal(x=>x.Password).WithMessage(baseLocalizer["ConfirmPasswordIsNotEqualToPassword"])
                ;

            RuleFor(x => x.IsPoliciesAccepted)
                .Equal(x => true).WithMessage(mainLocalizer["IsPoliciesAccepted"]);

            RuleFor(x => x.ProfileImage)
                .NotNull().WithMessage(baseLocalizer["PropertyCannotBeNull", mainLocalizer["ProfileImage"]])
                .NotEmpty().WithMessage(baseLocalizer["PropertyCannotBeEmpty", mainLocalizer["ProfileImage"]])
            ;

            RuleFor(x => x.ProfileImage).Must(FileSizeCheck)
            .WithMessage(mainLocalizer["FileSizeTooLarge"]).When(x => x.ProfileImage != null);

            RuleFor(x=>x.ProfileImage).Must(x => x.ContentType.Equals("image/jpeg") || x.Equals("image/jpg") || x.Equals("image/png"))
                .WithMessage(mainLocalizer["InvalidFormatPicture"]).When(x=>x.ProfileImage != null);

        }

        public bool FileSizeCheck(IFormFile image)
        {
            return image.Length < 100000;
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
