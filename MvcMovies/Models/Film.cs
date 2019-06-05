using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovies.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Review { get; set; }
        public decimal Price { get; set; }
    }
}