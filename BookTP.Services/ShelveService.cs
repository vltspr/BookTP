using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task AddEntity(Shelve entity)
        {
            await _context.Shelves.AddAsync(entity);
        }

        public async Task<List<Shelve>> GetAll()
        {
            return await _context.Shelves.ToListAsync();
        }

        public async Task<Shelve> GetById(Guid id)
        {
            return await _context.Shelves.Where(s => s.Id == id).SingleOrDefaultAsync();
        }
    }
}
