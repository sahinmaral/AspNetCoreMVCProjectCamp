using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Models;
using FluentValidation;

namespace CoreDemo.ValidationRules
{
    public class WriterPasswordViewModelValidator:AbstractValidator<WriterPasswordViewModel>
    {
        public WriterPasswordViewModelValidator()
        {
            RuleFor(x => x.OldPassword).NotEmpty().WithMessage("Lütfen eski şifrenizi giriniz");
            
            RuleFor(x => x.NewPassword)
                .NotEmpty().WithMessage("Şifreniz boş bırakılamaz")
                .MinimumLength(8).WithMessage("Şifreniz minimum 8 karakterli olmalıdır")
                .Matches("[A-Z]").WithMessage("Şifrenizde en az bir tane büyük harf olmalıdır")
                .Matches("[a-z]").WithMessage("Şifrenizde en az bir tane küçük harf olmalıdır")
                .Matches("[0-9]").WithMessage("Şifrenizde en az bir tane sayı olmalıdır")
                .Matches("[^a-zA-Z0-9]").WithMessage("Şifrenizde en az bir tane özel karakter olmalıdır");

            RuleFor(x => x.NewPasswordRepeat).Equal(x => x.NewPassword)
                .WithMessage("Tekrardan girdiğiniz şifre , yeni şifrenizle eşleşmiyor.");

            RuleFor(x => x.OldPassword).NotEqual(x => x.NewPassword).WithMessage("Eski ve yeni şifre aynı olamaz");
        }

        
    }
}
