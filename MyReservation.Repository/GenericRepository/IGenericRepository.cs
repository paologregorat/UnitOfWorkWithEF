﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyReservation.Repository
{
    public interface IGenericRepository<TEntity, TKey> where TEntity : class
    {
        TEntity GetById(TKey id);
        
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");

        void Delete(TKey id);

        void Delete(TEntity entityToDelete);
        
        void Insert(TEntity entity);
        
        void Update(TEntity entityToUpdate);
    }
}
