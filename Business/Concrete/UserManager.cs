using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
        private readonly IUserDal _userDal;
        
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        
        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return _userDal.GetAll(filter);
        }

        public User Get(Expression<Func<User, bool>> filter = null)
        {
            return _userDal.Get(filter);
        }

        public void Add(User entity)
        {
            _userDal.Add(entity);
        }

        public void Delete(User entity)
        {
            _userDal.Delete(entity);
        }

        public void Update(User entity)
        {
            _userDal.Update(entity);
        }
    }
}