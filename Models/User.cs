using System.Collections.Generic;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public List<Movie> Movies { get; set; }
    }
}