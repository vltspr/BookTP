﻿using System;
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

        public void AddEntity(Shelve entity)
        {
            _context.Shelves.Add(entity);
            _context.SaveChanges();
        }

        public async Task<List<Shelve>> GetAll()
        {
            return await _context.Shelves.ToListAsync();
        }

        public async Task<Shelve> GetByBookId(Guid id)
        {
            var book = _context.Books.Where(b => b.Id == id).SingleOrDefault();
            var shelve = await _context.Shelves.Where(s => s.Books.Contains(book)).SingleOrDefaultAsync();

            return shelve;
        }

        public async Task<Shelve> GetById(Guid id)
        {
            return await _context.Shelves.Where(s => s.Id == id).SingleOrDefaultAsync();
        }
    }
}
