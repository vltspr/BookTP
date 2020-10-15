using System.Collections.Generic;
using System.Threading.Tasks;
using BookTP.Models;
using BookTP.Services.Abstractions;

namespace BookTP.Services
{
    public interface IBookService : IServiceBase<Book>
    {
        Task<List<Book>> QueryBooks(string title, string author, int howManyToSave);
    }
}
