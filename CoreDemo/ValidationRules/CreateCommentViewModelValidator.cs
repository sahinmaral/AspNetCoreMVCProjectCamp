using CoreDemo.Models;
using FluentValidation;

namespace CoreDemo.ValidationRules
{
    public class CreateCommentViewModelValidator:AbstractValidator<CreateCommentViewModel>
    {
        public CreateCommentViewModelValidator()
        {
            RuleFor(x => x.CommentAbout)
                .NotNull().WithMessage("Yorum yazılması gerekir")
                .MinimumLength(5).WithMessage("Yorumunuz en az 5 karakterden oluşması gerekir")
                .MaximumLength(200).WithMessage("Yorumunuz en fazla 200 karakterden oluşması gerekir");
        }
    }
}