using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModels;

namespace Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<Hotel> GetByConditionAsync(Guid Id);
        void Create(T Entity);
        void Update(T Entity);
        void Delete(Guid Id);
    }
}