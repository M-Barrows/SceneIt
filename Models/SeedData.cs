using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace TVTracker.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                // GATTUSMP: SAMPLE OF A SEED FILE THAT FIRST LOOKS FOR A DATABASE WITH DATA
                //           IF NO DATA FOUND THEN DATA IS ADDED TO THE DATABASE
                // // Look for any movies.
                if (context.TVProgram.Any())
                {
                    return;   // DB has been seeded
                }

                context.TVProgram.AddRange(
                    new TVProgram
                    {
                        Title = "Stranger Things",
                        Season = 2,
                        Episode = 1
                    },

                    new TVProgram
                    {
                        Title = "Orange Is The New Black",
                        Season = 6,
                        Episode = 13
                    },

                    new TVProgram
                    {
                        Title = "Jane The Virgin",
                        Season = 5,
                        Episode = 1
                    },

                    new TVProgram
                    {
                        Title = "Saturday Night Live",
                        Season = 43,
                        Episode = 2
                    }
                );
                context.SaveChanges();
            }
        }
    }
}