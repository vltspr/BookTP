using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookTP.Models;
using BookTP.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookTP.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShelveController : ControllerBase
    {
        private readonly IShelveService _shelveService;

        public ShelveController(IShelveService shelveService)
        {
            _shelveService = shelveService;
        }

        // GET: /Shelve
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shelve>>> GetAllShelve()
        {
            return await _shelveService.GetAll();
        }

        // POST: /Shelve
        [HttpPost]
        public ActionResult CreateShelve(string name)
        {
            Shelve shelveToAdd = new Shelve() { Id = Guid.NewGuid(), Name = name };
            _shelveService.AddEntity(shelveToAdd);
            return Ok(shelveToAdd);
        }
    }
}
