using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookTP.Models;

namespace BookTP.Services.Abstractions
{
    public interface IServiceBase<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task AddEntity(T entity);
    }
}
