
using System.Collections.Generic;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentListByBlogViewComponent : ViewComponent
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentListByBlogViewComponent(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke(int id)
        {
            List<ReadCommentViewModel> commentViewModels = new List<ReadCommentViewModel>();

            var comments = _commentService.GetAllWithDetails(x => x.BlogId == id);

            commentViewModels = _mapper.Map(comments, commentViewModels);

            return View(commentViewModels);
        }
    }
}
