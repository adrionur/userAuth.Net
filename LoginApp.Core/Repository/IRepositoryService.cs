﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Core.Repository
{
    public interface IRepositoryService<T> where T: class
    {
        IEnumerable<T>Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");

        T GetById(object id);

        void Insert(T entity);

        void Delete(object id);

        void Delete(T entityToDelete);

        void Update(T entityToUpdate);

        //void Save<T>(T Entity);
    }
}
