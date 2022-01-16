using CoreDemo.Models;

using FluentValidation;

namespace CoreDemo.ValidationRules
{
    public class LoginUserViewModelValidator : AbstractValidator<LoginUserViewModel>
    {
        public LoginUserViewModelValidator()
        {
            RuleFor(x => x.Username).NotNull().WithMessage("Kullanıcı adınızı giriniz. ");
            RuleFor(x => x.Password).NotNull().WithMessage("Şifrenizi giriniz.");
        }


    }
}
