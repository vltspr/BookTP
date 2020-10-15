using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookTP.Services.Abstractions
{
    public interface IServiceBase
    {
        Task<List<object>> GetAll();
        Task<object> GetById(Guid id);
        Task AddEntity(object entity);
    }
}
