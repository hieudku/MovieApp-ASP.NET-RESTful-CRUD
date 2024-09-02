using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using System;
using System.Linq;

namespace MovieApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieAppContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<MovieAppContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }
                context.Movies.AddRange(
                    new Movies
                    {
                        Title = "Movie 1",
                        ReleaseDate = DateTime.Parse("2000-5-17"),
                        Genre = "Action",
                        Price = 17.99M
                    },
                    new Movies
                    {
                        Title = "Movie 2",
                        ReleaseDate = DateTime.Parse("2020-8-2"),
                        Genre = "Thriller",
                        Price = 13.99M
                    },
                    new Movies
                    {
                        Title = "Movie 3",
                        ReleaseDate = DateTime.Parse("2015-11-19"),
                        Genre = "Comedy",
                        Price = 15.99M
                    },
                    new Movies
                    {
                        Title = "Movie 4",
                        ReleaseDate = DateTime.Parse("2021-2-18"),
                        Genre = "Thriller",
                        Price = 19.99M
                    }
                    );
                context.SaveChanges();
            }
                
            
        }

    }
}
