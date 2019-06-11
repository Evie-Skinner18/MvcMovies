using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace MvcMovies.Models
{
    public class FilmGenreViewModel
    {
        public List<Film> Films { get; set; }

        // HTML select element so users can select an item
        public SelectList Genres { get; set; }

        // for the genre the user has selected
        public string FilmGenre { get; set; }
        public string SearchString { get; set; }
    }
}