using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ContactManager:IContactService
    {
        private readonly IContactDal _contactDal;
        
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        
        public List<Contact> GetAll(Expression<Func<Contact, bool>> filter = null)
        {
            return _contactDal.GetAll(filter);
        }

        public Contact Get(Expression<Func<Contact, bool>> filter = null)
        {
            return _contactDal.Get(filter);
        }

        public void Add(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void Delete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public void Update(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}