using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using BookTP.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BookTP.Services
{
    public class BookService : IBookService
    {
        private readonly BookDbContext _context;
        private readonly HttpClient _httpClient;

        private static readonly string API_URL = "https://www.googleapis.com/books/v1/volumes";

        public BookService(
            BookDbContext context)
        {
            _context = context;
            _httpClient = new HttpClient();
        }

        public void AddEntity(Book entity)
        {
            _context.Books.Add(entity);
        }

        public async Task<List<Book>> GetAll()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetById(Guid id)
        {
            return await _context.Books.Where(s => s.Id == id).SingleOrDefaultAsync();
        }

        public async Task<List<Book>> QueryBooks(string title, string author, int howManyToSave)
        {
            List<Book> books = new List<Book>();
            HttpResponseMessage response = await _httpClient.GetAsync(BuildUri(title, author));
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                JObject jsonObject = JObject.Parse(jsonString);
                List<JToken> results = jsonObject["items"].Children().ToList();

                if (howManyToSave > 0)
                {
                    for (int i = 0; i < howManyToSave; i++)
                    {
                        var newBook = results[i]["volumeInfo"].ToObject<Book>();
                        newBook.Id = Guid.NewGuid();
                        books.Add(newBook);
                        AddEntity(newBook);
                    }
                }
                else
                {
                    foreach (var result in results)
                    {
                        var newBook = result["volumeInfo"].ToObject<Book>();
                        newBook.Id = Guid.NewGuid();
                        books.Add(newBook);
                        AddEntity(newBook);
                    }
                }
            }

            _context.SaveChanges();
            return books;
        }

        private string BuildUri(string title, string author)
        {
            UriBuilder builder = new UriBuilder(API_URL);
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["q"] = title;
            if (!string.IsNullOrEmpty(author))
            {
                query["inauthor"] = author;
            }
            builder.Query = query.ToString().Replace("inauthor=", "inauthor:");
            return builder.ToString();
        }
    }
}
