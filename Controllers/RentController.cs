using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace lokvideoapi.Controllers
{
    [Route("api/[controller]")]
    public class RentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get api/rent
        [HttpPost]
        public Movie Post()
        {
            Movie movie = new Movie
            {
                Stars = 5,
                Review = "haha"
            };

            _context.Movies.Add(movie);
            _context.SaveChanges();

            return movie;
        }

        // GET api/rent/5
        [HttpGet("{id}")]
        public Movie GetMovieById(int id)
        {
            return _context.Movies.FirstOrDefault(
                x => x.Id == id
            );
        }

        // // POST api/values
        // [HttpPost]
        // public void Post([FromBody]string value)
        // {
        // }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
