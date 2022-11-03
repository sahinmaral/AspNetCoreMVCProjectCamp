using System.IO;
using AutoMapper;
using CoreDemo.Areas.Admin.Models;
using CoreDemo.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace CoreDemo.Mapping.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserLockoutViewModel>()
                .ForMember(obj => obj.UserViewModel, opt => opt.MapFrom(src => src))
                .ForMember(obj => obj.LockoutEnd, opt => opt.MapFrom(src => src.LockoutEnd))
                
                ;

            CreateMap<Blog, ReadBlogViewModel>()
                .ForMember(obj => obj.CommentViewModels, opt => opt.MapFrom(src => src.Comments))
                .ForMember(obj => obj.CategoryViewModel, opt => opt.MapFrom(src => src.Category))
                .ForMember(obj => obj.UserViewModel, opt => opt.MapFrom(src => src.User))
                .ForMember(obj => obj.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt.ToString("dd-MMM-yyyy")));

            CreateMap<Blog, UpdateBlogViewModel>()
                .ForMember(x => x.ThumbnailImage, opt => opt.Ignore())
                .ForMember(x => x.MainImage, opt => opt.Ignore())
                .ForMember(obj => obj.CreatedAt,
                    opt => opt.MapFrom(src => src.CreatedAt.ToString("dd-MMM-yyyy")))
                .ForMember(obj => obj.WriterViewModel,
                    opt => opt.MapFrom(src => src.User))
                .ForMember(obj => obj.CategoryViewModel,
                    opt => opt.MapFrom(src => src.Category))
                .ForMember(obj => obj.CommentViewModels,
                    opt => opt.MapFrom(src => src.Comments))
                ;

            CreateMap<UpdateBlogViewModel, Blog>();
            CreateMap<CreateBlogViewModel, Blog>();

            CreateMap<Contact, ReadContactViewModel>();
            CreateMap<Contact, RespondContactedUserViewModel>()
                .ForMember(obj => obj.SentAt,
                    opt => opt.MapFrom(src => src.CreatedAt));

            CreateMap<Category, ReadCategoryViewModel>();
            CreateMap<ReadCategoryViewModel, Category>();

            CreateMap<Category, UpdateCategoryViewModel>();
            CreateMap<UpdateCategoryViewModel, Category>();

            CreateMap<CreateCategoryViewModel, Category>();

            CreateMap<CreateNewsLetterViewModel, NewsLetter>();

            CreateMap<CreateCommentViewModel, Comment>();

            CreateMap<Comment, ReadCommentViewModel>()
                .ForMember(obj => obj.UserViewModel, opt => opt.MapFrom(src => src.User))
                .ForMember(obj => obj.BlogViewModel, opt => opt.MapFrom(src => src.Blog));

            CreateMap<Comment, UpdateCommentViewModel>()
                .ForMember(obj => obj.BlogTitle, opt => opt.MapFrom(src => src.Blog.Title))
                .ForMember(obj => obj.BlogId, opt => opt.MapFrom(src => src.Blog.Id));

            CreateMap<About, ReadAboutViewModel>();
            CreateMap<CreateAboutViewModel,About>();

            CreateMap<CreateContactViewModel, Contact>();

            CreateMap<Message, ReadMessageViewModel>();

            CreateMap<CreateMessageViewModel, Message>();

            CreateMap<ReadUserViewModel, User>();

            CreateMap<User, ReadUserViewModel>();

            CreateMap<UserSignUpViewModel, User>();

            CreateMap<Language, ReadLanguageViewModel>();

            CreateMap<Notification, ReadNotificationViewModel>();

            

        }
    }
}