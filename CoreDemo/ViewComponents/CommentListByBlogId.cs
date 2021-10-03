
using System.Collections.Generic;
using AutoMapper;
using Business.Abstract;
using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentListByBlogId : ViewComponent
    {
        private ICommentService _commentService;
        private IMapper _mapper;

        public CommentListByBlogId(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke(int id)
        {
            List<CommentViewModel> commentViewModels = new List<CommentViewModel>();

            commentViewModels = _mapper.Map(_commentService.GetAll(x => x.BlogId == id), commentViewModels);

            return View(commentViewModels);
        }
    }
}
