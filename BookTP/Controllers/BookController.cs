using System.Collections.Generic;
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
    }
}
