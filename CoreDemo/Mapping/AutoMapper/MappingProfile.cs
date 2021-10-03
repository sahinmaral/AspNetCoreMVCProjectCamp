using AutoMapper;
using CoreDemo.Models;
using Entities.Concrete;

namespace CoreDemo.Mapping.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Blog, BlogViewModel>()
                .ForMember(obj => obj.BlogCreateDate, opt => opt.MapFrom(src => src.BlogCreateDate.ToShortDateString()))
                .ForMember(obj => obj.CategoryViewModel, opt => opt.MapFrom(src => src.Category))
                .ForMember(x => x.CommentViewModels, opt => opt.MapFrom(src => src.Comments));

            CreateMap<Category, CategoryViewModel>();
            CreateMap<Comment, CommentViewModel>();

            CreateMap<RegisterWriterViewModel, Writer>();
        }
    }
}