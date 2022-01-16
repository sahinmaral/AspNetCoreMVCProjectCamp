using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Models;
using FluentValidation;

namespace CoreDemo.ValidationRules
{
    public class ReadWriterViewModelValidator:AbstractValidator<ReadWriterViewModel>
    {
        public ReadWriterViewModelValidator()
        {
            RuleFor(x => x.UserViewModel.UserFirstName).NotEmpty().WithMessage("Ad boş bırakılamaz");
            RuleFor(x => x.UserViewModel.UserLastName).NotEmpty().WithMessage("Soyad boş bırakılamaz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında boş bırakılamaz");

            RuleFor(x => x.WriterAbout).MinimumLength(10).WithMessage("Hakkında , en az 10 karakter olmalıdır");
            RuleFor(x => x.WriterAbout).MaximumLength(120).WithMessage("Hakkında , en fazla 120 karakter olmalıdır");

            RuleFor(x => x.UserViewModel.UserFirstName).MinimumLength(2).WithMessage("Ad , en az 2 karakter olmalıdır");
            RuleFor(x => x.UserViewModel.UserLastName).MaximumLength(20).WithMessage("Ad , en fazla 20 karakter olmalıdır");

            RuleFor(x => x.UserViewModel.UserLastName).MinimumLength(2).WithMessage("Soyad , en az 2 karakter olmalıdır");
            RuleFor(x => x.UserViewModel.UserFirstName).MaximumLength(30).WithMessage("Soyad , en fazla 30 karakter olmalıdır");
        }
    }
}
