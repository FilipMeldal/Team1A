using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;


namespace ModelPersistence.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T t);
        List<T> GetAll();
        T GetById();
        void Update(T t);
        void Remove(T t);
    }
}
