using System;
using System.Threading.Tasks;
using BookTP.Models;
using BookTP.Services.Abstractions;

namespace BookTP.Services
{
    public interface IShelveService : IServiceBase<Shelve>
    {
        Task<Shelve> GetByBookId(Guid id);
    }
}
