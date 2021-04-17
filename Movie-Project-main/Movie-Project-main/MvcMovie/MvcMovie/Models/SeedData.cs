using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;


namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movies.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movies.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        DirectedBy = "Rob Reiner",
                        DistributedBy = "Columbia Pictures",
                        RunningTime = "96 mins",
                        Language = "English"

                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        DirectedBy = "Ivan Reitman",
                        DistributedBy = "Columbia Pictures",
                        RunningTime = "105 mins",
                        Language = "English"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        DirectedBy = "Ivan Reitman",
                        DistributedBy = "Columbia Pictures",
                        RunningTime = "108 mins",
                        Language = "English"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        DirectedBy = "Howard Hawks",
                        DistributedBy = "Warner Bros",
                        RunningTime = "141 mins",
                        Language = "English and Spanish"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

