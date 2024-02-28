﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardValidator.Data
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetByID(object id);
        void Insert(TEntity entity);
    }
}
