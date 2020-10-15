﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BookTP.Models;
using BookTP.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookTP.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: /Book
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetAllBooks()
        {
            return await _bookService.GetAll();
        }

        // GET: /Book/title/author
        [HttpGet("query")]
        public async Task<ActionResult<IEnumerable<Book>>> QueryBooks(string title, string author = "", int howManyToSave = 0)
        {
            return await _bookService.QueryBooks(title, author, howManyToSave);
        }
    }
}
