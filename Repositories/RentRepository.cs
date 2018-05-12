using System;
using System.Linq;
using lokvideoapi;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories
{
    public class RentRepository
    {
        private WebAPIDataContext _WebAPIDataContext;
        
        public RentRepository(WebAPIDataContext WebAPIDataContext)
        {
            _WebAPIDataContext = WebAPIDataContext;
        }

        public Movie GetMovieById(int id)
        {
            return _WebAPIDataContext.Movies.FirstOrDefault(
                x => x.Id == id
            );
        }
    }
}