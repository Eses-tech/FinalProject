using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{


    // *************CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ*************

    //generic constraint
    // class : referans tip olabilir demektir..
    //IEntity : IEntity olabilir ya da IEntity implement eden bir nesne olabilir.
    //new() : new'lenebilir olamalı..
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
