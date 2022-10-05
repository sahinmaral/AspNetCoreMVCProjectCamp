using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class EfAboutDal:EfEntityRepositoryBase<About,Context> , IAboutDal
    {
        
    }
}