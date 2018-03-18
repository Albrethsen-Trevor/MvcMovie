using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return; // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("10-10-2014"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("6-3-2011"),
                        Genre = "History",
                        Rating = "PG",
                        Price = 4.99M
                    },

                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("4-4-2014"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 14.99M
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("1-30-2002"),
                        Genre = "Romantic Comedy",
                        Rating = "PG",
                        Price = 0.99M
                    },

                    new Movie
                    {
                        Title = "Saints and Soldiers",
                        ReleaseDate = DateTime.Parse("9-11-2003"),
                        Genre = "Drama",
                        Rating = "PG-13",
                        Price = 19.99M
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2-20-2004"),
                        Genre = "Comedy Drama",
                        Rating = "PG",
                        Price = 29.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
