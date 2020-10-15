using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookTP.Models;

namespace BookTP.Services.Abstractions
{
    interface IServiceBase
    {
        Task<List<Shelve>> GetAll();
        Task<Shelve> GetById(Guid id);
        Task AddEntity(object entity);
    }
}
