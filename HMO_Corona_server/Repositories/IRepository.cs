using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T objToCreate);
        void Update(T objToUpdate);
        void Delete(int id);
    }
}
