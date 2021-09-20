using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        public T GetItem(Guid Id);
        public List<T> GetAllItems();
        public void Add(T item);
        public void Remove(Guid Id);
        public void Update(T item);
    }
}
