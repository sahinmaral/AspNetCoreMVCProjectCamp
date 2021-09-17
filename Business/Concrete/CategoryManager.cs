using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryDal.GetAll(filter);
        }

        public Category Get(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryDal.Get(filter);
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}