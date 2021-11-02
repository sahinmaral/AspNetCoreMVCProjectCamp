using AutoMapper;
using CoreDemo.Models;
using Entities.Concrete;

namespace CoreDemo.Mapping.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Blog, ReadBlogViewModel>()
                .ForMember(obj => obj.BlogCreateDate, opt => opt.MapFrom(src => src.BlogCreatedDate.ToShortDateString()))
                .ForMember(obj => obj.CategoryViewModel, opt => opt.MapFrom(src => src.Category))
                .ForMember(obj => obj.WriterViewModel, opt => opt.MapFrom(src => src.Writer))
                .ForMember(x => x.CommentViewModels, opt => opt.MapFrom(src => src.Comments));

            CreateMap<CreateBlogViewModel, Blog>();
            
            CreateMap<Comment, ReadCommentViewModel>()
                .ForMember(obj => obj.WriterViewModel, opt => opt.MapFrom(src => src.Writer));

            CreateMap<Category, ReadCategoryViewModel>();
            CreateMap<Writer, ReadWriterViewModel>();

            CreateMap<CreateNewsLetterViewModel, NewsLetter>();
            CreateMap<CreateCommentViewModel, Comment>();

            CreateMap<RegisterWriterViewModel, Writer>();

            CreateMap<About, ReadAboutViewModel>();

            CreateMap<CreateContactViewModel, Contact>()
                .ForMember(obj => obj.ContactSurname , opt => opt.MapFrom(src=>src.ContactSurname.ToUpper()));

        }
    }
}