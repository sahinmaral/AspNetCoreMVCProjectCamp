﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfAboutDal:EfEntityRepositoryBase<About,Context> , IAboutDal
    {
        
    }
}