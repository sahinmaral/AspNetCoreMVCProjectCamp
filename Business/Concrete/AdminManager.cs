using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AdminManager:IAdminService
    {
        private readonly IAdminDal _adminDal;
        
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        
        public List<Admin> GetAll(Expression<Func<Admin, bool>> filter = null)
        {
            return _adminDal.GetAll(filter);
        }

        public Admin Get(Expression<Func<Admin, bool>> filter = null)
        {
            return _adminDal.Get(filter);
        }

        public void Add(Admin entity)
        {
            _adminDal.Add(entity);
        }

        public void Delete(Admin entity)
        {
            _adminDal.Delete(entity);
        }

        public void Update(Admin entity)
        {
            _adminDal.Update(entity);
        }
    }
}