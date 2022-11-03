using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LanguageManager : ILanguageService
    {

        private readonly ILanguageDal _languageDal;

        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }
        public List<Language> GetAll(Expression<Func<Language, bool>> filter = null)
        {
            return _languageDal.GetAll(filter);
        }


        public Language Get(Expression<Func<Language, bool>> filter = null)
        {
            return _languageDal.Get(filter);
        }

        public void Add(Language entity)
        {
            _languageDal.Add(entity);
        }

        public void Delete(Language entity)
        {
            _languageDal.Delete(entity);
        }

        public void Update(Language entity)
        {
            _languageDal.Update(entity);
        }
    }
}
