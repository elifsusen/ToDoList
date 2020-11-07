using MvcToDoList.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcToDoList.DataAccess.Concrete.EntityFramework
{
    public class EfGenericRepository<T> : IRepository<T> where T:class
    {
        public void Create(T entity)
        {
            using (ToTheListContext db= new ToTheListContext())
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (ToTheListContext db = new ToTheListContext())
            {
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (ToTheListContext db = new ToTheListContext())
            {
               return db.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (ToTheListContext db = new ToTheListContext())
            {
                return db.Set<T>().Find(id);
               
            }
        }

        public void Update(T entity)
        {
            using (ToTheListContext db = new ToTheListContext())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
