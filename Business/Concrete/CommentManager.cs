using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CommentManager:ICommentService
    {
        private readonly ICommentService _commentService;
        
        public CommentManager(ICommentService commentService)
        {
            _commentService = commentService;
        }
        
        public List<Comment> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            return _commentService.GetAll(filter);
        }

        public Comment Get(Expression<Func<Comment, bool>> filter = null)
        {
            return _commentService.Get(filter);
        }

        public void Add(Comment entity)
        {
            _commentService.Add(entity);
        }

        public void Delete(Comment entity)
        {
            _commentService.Delete(entity);
        }

        public void Update(Comment entity)
        {
            _commentService.Update(entity);
        }
    }
}