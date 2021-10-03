using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CommentManager:ICommentService
    {
        private readonly ICommentDal _commentDal;
        
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        
        public List<Comment> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            return _commentDal.GetAll(filter);
        }

        public Comment Get(Expression<Func<Comment, bool>> filter = null)
        {
            return _commentDal.Get(filter);
        }

        public void Add(Comment entity)
        {
            _commentDal.Add(entity);
        }

        public void Delete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }

        public List<Comment> GetAllWithDetails(Expression<Func<Comment, bool>> filter = null)
        {
            return _commentDal.GetAllWithDetails(filter);
        }
    }
}