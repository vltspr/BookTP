using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task AddEntity(Book entity)
        {
            await _context.Books.AddAsync(entity);
        }

        public async Task<List<Book>> GetAll()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetById(Guid id)
        {
            return await _context.Books.Where(s => s.Id == id).SingleOrDefaultAsync();
        }
    }
}
