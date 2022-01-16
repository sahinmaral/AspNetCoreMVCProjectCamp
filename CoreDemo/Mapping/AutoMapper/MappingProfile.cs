using AutoMapper;
using Core.Entities.Concrete;
using CoreDemo.Models;
using Entities.Concrete;

namespace CoreDemo.Mapping.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Blog, ReadBlogViewModel>()
                //.ForMember(obj => obj.BlogId, opt => opt.MapFrom(src => src.BlogId))
                .ForMember(obj => obj.BlogCreateDate, opt => opt.MapFrom(src => src.BlogCreatedDate.ToShortDateString()))
                .ForMember(obj => obj.CategoryViewModel, opt => opt.MapFrom(src => src.Category))
                .ForMember(obj => obj.WriterViewModel, opt => opt.MapFrom(src => src.Writer))
                .ForMember(x => x.CommentViewModels, opt => opt.MapFrom(src => src.Comments));

            CreateMap<Blog, UpdateBlogViewModel>()
                .ForMember(obj => obj.BlogCreateDate, opt => opt.MapFrom(src => src.BlogCreatedDate.ToShortDateString()))
                .ForMember(obj => obj.CategoryViewModel, opt => opt.MapFrom(src => src.Category))
                .ForMember(obj => obj.WriterViewModel, opt => opt.MapFrom(src => src.Writer))
                .ForMember(x => x.CommentViewModels, opt => opt.MapFrom(src => src.Comments));

            CreateMap<UpdateBlogViewModel, Blog>();

            CreateMap<CreateBlogViewModel, Blog>();

            CreateMap<Writer, ReadWriterViewModel>()
                .ForMember(obj => obj.UserViewModel, opt => opt.MapFrom(src => src.User))
                ;

            CreateMap<ReadWriterViewModel, Writer>();

            CreateMap<Comment, ReadCommentViewModel>()
                .ForMember(obj => obj.BlogId, opt => opt.MapFrom(src => src.Blog.BlogId))
                .ForMember(obj => obj.WriterViewModel, opt => opt.MapFrom(src => src.Writer))
                .ForPath(obj => obj.WriterViewModel.UserViewModel, opt =>
                {
                    opt.MapFrom(src => new User()
                    {
                        UserFirstName = src.Writer.User.UserFirstName,
                        UserLastName = src.Writer.User.UserLastName,
                        Username = src.Writer.User.Username,
                        UserId = src.Writer.User.UserId,
                    });
                });

            CreateMap<Category, ReadCategoryViewModel>();

            CreateMap<CreateCategoryViewModel, Category>();

            CreateMap<CreateNewsLetterViewModel, NewsLetter>();
            CreateMap<CreateCommentViewModel, Comment>();

            CreateMap<RegisterWriterViewModel, Writer>();

            CreateMap<About, ReadAboutViewModel>();

            CreateMap<User, ReadUserViewModel>()
                .ForMember(obj => obj.UserFirstName, opt => opt.MapFrom(src => src.UserFirstName))
                .ForMember(obj => obj.UserLastName, opt => opt.MapFrom(src => src.UserLastName))
                .ForMember(obj => obj.Username, opt => opt.MapFrom(src => src.Username))
                .ForMember(obj => obj.UserId, opt => opt.MapFrom(src => src.UserId));

            CreateMap<CreateContactViewModel, Contact>()
                .ForMember(obj => obj.ContactSurname , opt => opt.MapFrom(src=>src.ContactSurname.ToUpper()));

            CreateMap<Message, ReadMessageViewModel>();
        }
    }
}