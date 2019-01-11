using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ClassSchedule.Models
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
                // if (context.Movie.Any())
                // {
                //     return;   // DB has been seeded
                // }

                // context.Movie.AddRange(
                //     new Movie
                //     {
                //         Title = "When Harry Met Sally",
                //         ReleaseDate = DateTime.Parse("1989-2-12"),
                //         Genre = "Romantic Comedy",
                //         Price = 7.99M
                //     },

                //     new Movie
                //     {
                //         Title = "Ghostbusters",
                //         ReleaseDate = DateTime.Parse("1984-3-13"),
                //         Genre = "Comedy",
                //         Price = 8.99M
                //     },

                //     new Movie
                //     {
                //         Title = "Ghostbusters 2",
                //         ReleaseDate = DateTime.Parse("1986-2-23"),
                //         Genre = "Comedy",
                //         Price = 9.99M
                //     },

                //     new Movie
                //     {
                //         Title = "Rio Bravo",
                //         ReleaseDate = DateTime.Parse("1959-4-15"),
                //         Genre = "Western",
                //         Price = 3.99M
                //     }
                // );


if (context.ClassScheduler.Any()) {
            return;
        }
        context.ClassScheduler.AddRange(
            new ClassScheduler { ClassCode = "BANA 6037", ClassName= "Data Visualization",Professor="Jeffery Shaffer",TotalEnrollment="100" },
            new ClassScheduler { ClassCode =  "IS 7012", ClassName= "WEB DEV W/.NET",Professor="Michael Gattuso",TotalEnrollment="98" },
            new ClassScheduler { ClassCode = "IS 7030", ClassName= "DATA MODELING",Professor="Andrew Harrison",TotalEnrollment="96" },
            new ClassScheduler { ClassCode = "ACCT 7000", ClassName= "FIN ACCT FOUNDATION",Professor="Molly Rogers",TotalEnrollment="50" }
        );
                context.SaveChanges();
            }
        }
    }
}