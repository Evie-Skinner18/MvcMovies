using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovies.Models
{
    public static class SeedData
    {
        public static void Initialise(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMoviesContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMoviesContext>>()))
            {
                // context.Film is a Db Set which is like a list. This asks "are there any films in the Db set?"
                if (context.Film.Any())
                {
                    return;   // if the .Any returns true, we don't need to do anything as DB has been seeded
                }

                // if there are no films, we need to put some films in the Db Set
                context.Film.AddRange(
                    new Film
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "",
                        Review = "",
                        Price = 7.99M
                    },

                    new Film
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "",
                        Review = "",
                        Price = 8.99M
                    },

                    new Film
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "",
                        Review = "",
                        Price = 9.99M
                    },

                    new Film
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "",
                        Review = "",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();

            }
        }
    }
}