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
            CreateMap<Blog, ReadBlogViewModel>()
                .ForMember(obj => obj.BlogCreateDate, opt => opt.MapFrom(src => src.BlogCreatedDate.ToString("dd-MMM-yyyy")))
                .ForMember(obj => obj.CategoryViewModel, opt => opt.MapFrom(src => src.Category))
                .ForMember(x => x.CommentViewModels, opt => opt.MapFrom(src => src.Comments))
                .ForMember(x => x.UserViewModel, opt => opt.MapFrom(src => src.User));

            CreateMap<Blog, UpdateBlogViewModel>()
                .ForMember(obj => obj.BlogCreateDate,
                    opt => opt.MapFrom(src => src.BlogCreatedDate.ToShortDateString()))
                .ForMember(obj => obj.CategoryViewModel, opt => opt.MapFrom(src => src.Category))
                .ForMember(x => x.CommentViewModels, opt => opt.MapFrom(src => src.Comments));

            CreateMap<UpdateBlogViewModel, Blog>();

            CreateMap<CreateBlogViewModel, Blog>();

            CreateMap<Category, ReadCategoryViewModel>();
            CreateMap<ReadCategoryViewModel, Category>();

            CreateMap<CreateCategoryViewModel, Category>();

            CreateMap<CreateNewsLetterViewModel, NewsLetter>()
                .ForMember(obj => obj.NewsLetterMail, opt => opt.MapFrom(src => src.Email));

            CreateMap<CreateCommentViewModel, Comment>();

            CreateMap<Comment, ReadCommentViewModel>()
                .ForMember(obj => obj.UserViewModel, opt => opt.MapFrom(src => src.User))
                .ForMember(obj => obj.BlogViewModel, opt => opt.MapFrom(src => src.Blog));

            CreateMap<Comment, UpdateCommentViewModel>()
                .ForMember(obj => obj.BlogTitle, opt => opt.MapFrom(src => src.Blog.BlogTitle))
                .ForMember(obj => obj.BlogId, opt => opt.MapFrom(src => src.Blog.BlogId));

            CreateMap<About, ReadAboutViewModel>();

            CreateMap<CreateContactViewModel, Contact>()
                .ForMember(obj => obj.ContactNameSurname , opt => opt.MapFrom(src=>src.ContactNameSurname));

            CreateMap<Message, ReadMessageViewModel>();

            CreateMap<CreateMessageViewModel, Message>();

            CreateMap<ReadUserViewModel, AppUser>();

            CreateMap<AppUser, ReadUserViewModel>()
                .ForMember(obj => obj.Username, opt => opt.MapFrom(src => src.UserName))
                .ForMember(obj => obj.UserId, opt => opt.MapFrom(src => src.Id));

            CreateMap<UserSignUpViewModel, AppUser>()
                .ForMember(obj => obj.NameSurname, opt => opt.MapFrom(src => src.NameSurname))
                .ForMember(obj => obj.Email, opt => opt.MapFrom(src => src.Mail))
                .ForMember(obj => obj.UserName, opt => opt.MapFrom(src => src.Username));
        }
    }
}