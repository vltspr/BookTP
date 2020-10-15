using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookTP.Models;
using Microsoft.EntityFrameworkCore;

namespace BookTP.Services
{
    public class ShelveService : IShelveService
    {
        private readonly BookDbContext _context;

        public ShelveService(
            BookDbContext context)
        {
            _context = context;
        }

        public Task AddEntity(Shelve entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Shelve>> GetAll()
        {
            return await _context.Shelves.ToListAsync();
        }

        public Task<Shelve> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
