using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookTP.Services
{
    public class BookService : IBookService
    {
        private readonly BookDbContext _context;

        public BookService(
            BookDbContext context)
        {
            _context = context;
        }
        public Task AddEntity(object entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<object>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<object> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
