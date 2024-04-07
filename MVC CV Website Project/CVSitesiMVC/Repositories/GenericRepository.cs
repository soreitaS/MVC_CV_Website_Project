using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Web;
using CVSitesiMVC.Models.Entity;


namespace CVSitesiMVC.Repositories
{
    public class GenericRepository<T> where T : class,new()
    {
        CVSitesiMVCEntities db = new CVSitesiMVCEntities();

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }
        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        public T TGet(T id)
        {
            return db.Set<T>().Find(id);
        }
        public void TUpdate(T p)
        {
            db.SaveChanges();
        }
        public T Find(Expression<Func<T, bool>> where) 
        {
            return db.Set<T>().FirstOrDefault(where);
        }

    }
}