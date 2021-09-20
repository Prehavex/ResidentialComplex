using DAL.DataContext;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        RCContext db;
        public BaseRepository(RCContext context)
        {
            db = context;
        }
        public void Add(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }
        public List<T> GetAllItems()
        {
            return db.Set<T>().ToList();
        }
        public T GetItem(Guid Id)
        {
            return db.Set<T>().Find(Id);
        }
        public void Remove(Guid Id)
        {
            db.Set<T>().Remove(db.Set<T>().Find(Id));
            db.SaveChanges();
        }
        public void Update(T item)
        {
            db.Set<T>().Update(item);
            db.SaveChanges();
        }

        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposed = true;
            }
        }
    }
}
