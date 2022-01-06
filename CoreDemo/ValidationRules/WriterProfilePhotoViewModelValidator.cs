using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Models;
using FluentValidation;

namespace CoreDemo.ValidationRules
{
    public class WriterProfilePhotoViewModelValidator:AbstractValidator<WriterProfilePhotoViewModel>
    {
        public WriterProfilePhotoViewModelValidator()
        {
            RuleFor(x => x.ProfilePhoto).NotNull().WithMessage("Lütfen resim yükleyin");
        }
    }
}
