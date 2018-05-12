using System;
using lokvideoapi;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class RentRepository
    {
        private WebAPIDataContext _WebAPIDataContext;
        
        public RentRepository(WebAPIDataContext WebAPIDataContext)
        {
            _WebAPIDataContext = WebAPIDataContext;
        }
    }
}