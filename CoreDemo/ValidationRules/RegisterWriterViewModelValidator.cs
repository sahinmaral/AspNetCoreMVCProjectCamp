using CoreDemo.Models;

using FluentValidation;

namespace CoreDemo.ValidationRules
{
    public class RegisterWriterViewModelValidator : AbstractValidator<RegisterWriterViewModel>
    {
        public RegisterWriterViewModelValidator()
        {
            RuleFor(x => x.WriterMail).NotNull().WithMessage("Mail boş bırakılamaz");


            RuleFor(x => x.WriterPassword).NotNull().WithMessage("Şifre boş bırakılamaz")
                .Equal(x => x.WriterPasswordRepeat).WithMessage("Şifre ve şifre tekrarı aynı olmalıdır")
                .Matches("[A-Z]").WithMessage("Şifrenizde en az bir büyük harf olmalıdır")
                    .Matches("[a-z]").WithMessage("Şifrenizde en az bir küçük harf olmalıdır")
                    .Matches(@"\d").WithMessage("Şifrenizde en az bir rakam olmalıdır");


            RuleFor(x => x.WriterPasswordRepeat).NotNull().WithMessage("Şifre tekrarı boş bırakılamaz");
            RuleFor(x => x.WriterMail).NotNull().WithMessage("Email boş bırakılamaz");
            RuleFor(x => x.WriterUsername).NotNull().WithMessage("Kullanıcı adı boş bırakılamaz");
            RuleFor(x => x.WriterImage).NotNull().WithMessage("Resim yüklenmesi gerekir");



        }


    }
}
