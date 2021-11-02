
using System.Collections.Generic;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentListByBlogIdViewComponent : ViewComponent
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentListByBlogIdViewComponent(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke(int id)
        {
            List<ReadCommentViewModel> commentViewModels = new List<ReadCommentViewModel>();

            commentViewModels = _mapper.Map(_commentService.GetAllWithDetails(x => x.BlogId == id), commentViewModels);

            return View(commentViewModels);
        }
    }
}
