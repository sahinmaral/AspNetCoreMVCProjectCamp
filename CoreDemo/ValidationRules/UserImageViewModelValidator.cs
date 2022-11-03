using CoreDemo.Models;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;

namespace CoreDemo.ValidationRules
{
    public class UserImageViewModelValidator : AbstractValidator<UserImageViewModel>
    {
        public UserImageViewModelValidator(IStringLocalizer<UserImageViewModel> baseLocalizer,IStringLocalizer<BaseViewModel> mainLocalizer)
        {

            //ProfileImage

            RuleFor(x => x.ProfileImage)
                .NotNull().WithMessage(mainLocalizer["PropertyCannotBeNull", baseLocalizer["ProfileImage"]])
                .NotEmpty().WithMessage(mainLocalizer["PropertyCannotBeEmpty", baseLocalizer["ProfileImage"]])
            ;

            RuleFor(x => x.ProfileImage).Must(FileSizeCheck)
            .WithMessage(baseLocalizer["FileSizeTooLarge"]).When(x => x.ProfileImage != null);

            RuleFor(x => x.ProfileImage).Must(FileExtensionCheck)
                .WithMessage(baseLocalizer["InvalidFormatPicture"]).When(x => x.ProfileImage != null);
        }


        public bool FileSizeCheck(IFormFile image)
        {
            return image.Length < 100000;
        }

        public bool FileExtensionCheck(IFormFile image)
        {
            string[] extensions = { "image/png", "image/jpg", "image/jpeg" };
            foreach (var extension in extensions)
            {
                if (extension == image.ContentType) return true;
            }

            return false;
        }
    }
}
