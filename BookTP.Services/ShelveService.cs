﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BookTP.Models;
using BookTP.Services.Abstractions;

namespace BookTP.Services
{
    public class ShelveService : IServiceBase
    {
        private readonly BookDbContext _context;

        public ShelveService(
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
