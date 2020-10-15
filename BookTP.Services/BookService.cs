using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookTP.Models;
using Microsoft.EntityFrameworkCore;

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

        public Task AddEntity(Book entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> GetAll()
        {
            return await _context.Books.ToListAsync();
        }

        public Task<Book> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
