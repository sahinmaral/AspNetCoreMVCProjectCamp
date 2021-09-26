using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ContactManager:IContactService
    {
        private readonly IContactService _contactService;
        
        public ContactManager(IContactService contactService)
        {
            _contactService = contactService;
        }
        
        public List<Contact> GetAll(Expression<Func<Contact, bool>> filter = null)
        {
            return _contactService.GetAll(filter);
        }

        public Contact Get(Expression<Func<Contact, bool>> filter = null)
        {
            return _contactService.Get(filter);
        }

        public void Add(Contact entity)
        {
            _contactService.Add(entity);
        }

        public void Delete(Contact entity)
        {
            _contactService.Delete(entity);
        }

        public void Update(Contact entity)
        {
            _contactService.Update(entity);
        }
    }
}