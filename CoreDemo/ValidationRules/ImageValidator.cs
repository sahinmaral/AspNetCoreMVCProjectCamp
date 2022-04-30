using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace CoreDemo.ValidationRules
{
    public class ImageValidator : AbstractValidator<IFormFile>
    {
        public ImageValidator()
        {

            RuleFor(x => x.Length).NotNull().LessThanOrEqualTo(204000)
                .WithMessage("File size is larger than allowed");

            RuleFor(x => x.ContentType).NotNull().Must(x => x.Equals("image/jpeg") || x.Equals("image/jpg") || x.Equals("image/png"))
                .WithMessage("File type is larger than allowed");
        }
    }
}
