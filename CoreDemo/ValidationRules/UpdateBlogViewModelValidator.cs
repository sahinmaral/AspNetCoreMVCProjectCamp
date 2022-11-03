using CoreDemo.Models;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;

namespace CoreDemo.ValidationRules
{
    public class UpdateBlogViewModelValidator : AbstractValidator<UpdateBlogViewModel>
    {
        public UpdateBlogViewModelValidator(IStringLocalizer<UpdateBlogViewModel> baseLocalizer, IStringLocalizer<BaseViewModel> mainLocalizer)
        {
            // MainImage
           
            RuleFor(x => x.MainImage).Must(FileSizeCheck)
            .WithMessage(baseLocalizer["FileSizeTooLarge"]).When(x => x.MainImage != null);

            RuleFor(x => x.MainImage).Must(FileExtensionCheck)
                .WithMessage(baseLocalizer["InvalidFormatPicture"]).When(x => x.MainImage != null);

            // ThumbnailImage

            RuleFor(x => x.ThumbnailImage).Must(FileSizeCheck)
            .WithMessage(baseLocalizer["FileSizeTooLarge"]).When(x => x.ThumbnailImage != null);

            RuleFor(x => x.ThumbnailImage).Must(FileExtensionCheck)
                .WithMessage(baseLocalizer["InvalidFormatPicture"]).When(x => x.ThumbnailImage != null);

            // Title

            RuleFor(x => x.Title).NotNull().WithMessage(mainLocalizer["ProperyCannotBeNull", mainLocalizer["Title"]]);
            RuleFor(x => x.Title).NotEmpty().WithMessage(mainLocalizer["ProperyCannotBeEmpty", mainLocalizer["Title"]]);
            RuleFor(x => x.Title).MinimumLength(3).WithMessage(mainLocalizer["PropertyMinimumLength", mainLocalizer["Title"], 3]);
            RuleFor(x => x.Title).MaximumLength(100).WithMessage(mainLocalizer["PropertyMaximumLength", mainLocalizer["Title"], 100]);

            // Content

            RuleFor(x=>x.Content).NotNull().WithMessage(mainLocalizer["ProperyCannotBeNull", mainLocalizer["Content"]]);
            RuleFor(x=>x.Content).NotEmpty().WithMessage(mainLocalizer["ProperyCannotBeEmpty", mainLocalizer["Content"]]);
            RuleFor(x => x.Content).MinimumLength(3).WithMessage(mainLocalizer["PropertyMinimumLength", mainLocalizer["Content"], 3]);
            RuleFor(x => x.Content).MaximumLength(10000).WithMessage(mainLocalizer["PropertyMaximumLength", mainLocalizer["Content"], 10000]);
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
