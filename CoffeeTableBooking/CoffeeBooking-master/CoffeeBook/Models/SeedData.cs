using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CoffeeBooking.Models
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


                if (context.Restaurant.Any())
                {
                    return;
                }
                context.Restaurant.AddRange(
                    new Restaurant { Name = "Rohs Street Café", OpeningTime = "11AM", ClosingTime = "11PM", Country = "USA", City = "cincinnati", Latitude = "39.1338998", Longitude = "-84.534427", PriceRange = "$", Tables = null },
 new Restaurant { Name = "Starbucks", OpeningTime = "11AM", ClosingTime = "10.30PM", Country = "USA", City = "cincinnati", Latitude = "39.1338662", Longitude = "-84.5297309", PriceRange = "$$", Tables = null },
 new Restaurant { Name = "Highland Coffee House", OpeningTime = "5PM", ClosingTime = "2.30AM", Country = "USA", City = "cincinnati", Latitude = "39.129013", Longitude = "-84.5339751", PriceRange = "$", Tables = null },
 new Restaurant { Name = "Sitwell's Act II", OpeningTime = "9AM", ClosingTime = "11PM", Country = "USA", City = "cincinnati", Latitude = "39.1397256", Longitude = "-84.5336562", PriceRange = "$$", Tables = null },
 new Restaurant { Name = "Collective Espresso", OpeningTime = "7AM", ClosingTime = "7PM", Country = "USA", City = "cincinnati", Latitude = "39.1499013", Longitude = "-84.5584504", PriceRange = "$", Tables = null },
 new Restaurant { Name = "Deeper Roots Coffee", OpeningTime = "8AM", ClosingTime = "8PM", Country = "USA", City = "cincinnati", Latitude = "39.1279471", Longitude = "-84.5444636", PriceRange = "$$", Tables = null },
 new Restaurant { Name = "Bruegger's Bagels", OpeningTime = "6AM", ClosingTime = "8PM", Country = "USA", City = "cincinnati", Latitude = "39.1386071", Longitude = "-84.5337426", PriceRange = "$", Tables = null },
 new Restaurant { Name = "Sidewinder", OpeningTime = "6.30AM", ClosingTime = "8PM", Country = "USA", City = "cincinnati", Latitude = "39.1508125", Longitude = "-84.5584504", PriceRange = "$$", Tables = null },
 new Restaurant { Name = "The 86 Uptown", OpeningTime = "7AM", ClosingTime = "8PM", Country = "USA", City = "cincinnati", Latitude = "39.1336267", Longitude = "-84.5375379", PriceRange = "$", Tables = null },
 new Restaurant { Name = "Coffee Emporium", OpeningTime = "6AM", ClosingTime = "8PM", Country = "USA", City = "cincinnati", Latitude = "39.1357464", Longitude = "-84.5501036", PriceRange = "$$", Tables = null }
                   
                          );

                context.Table.AddRange(
                
                new Table { TableNumber=1,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 1, AssignRestaurent = null },
 new Table { TableNumber=2,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 1, AssignRestaurent = null },
 new Table { TableNumber=3,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 1, AssignRestaurent = null },
 new Table { TableNumber=4,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 1, AssignRestaurent = null },
 new Table { TableNumber=5,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 1, AssignRestaurent = null },
 new Table { TableNumber=1,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 2, AssignRestaurent = null },
 new Table { TableNumber=2,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 2, AssignRestaurent = null },
 new Table { TableNumber=3,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 2, AssignRestaurent = null },
 new Table { TableNumber=4,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 2, AssignRestaurent = null },
 new Table { TableNumber=5,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 2, AssignRestaurent = null },
 new Table { TableNumber=1,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 3, AssignRestaurent = null },
 new Table { TableNumber=2,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 3, AssignRestaurent = null },
 new Table { TableNumber=3,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 3, AssignRestaurent = null },
 new Table { TableNumber=4,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 3, AssignRestaurent = null },
 new Table { TableNumber=5,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 3, AssignRestaurent = null },
 new Table { TableNumber=1,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 4, AssignRestaurent = null },
 new Table { TableNumber=2,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 4, AssignRestaurent = null },
 new Table { TableNumber=3,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 4, AssignRestaurent = null },
 new Table { TableNumber=4,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 4, AssignRestaurent = null },
 new Table { TableNumber=5,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 4, AssignRestaurent = null },
 new Table { TableNumber=1,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 5, AssignRestaurent = null },
 new Table { TableNumber=2,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 5, AssignRestaurent = null },
 new Table { TableNumber=3,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 5, AssignRestaurent = null },
 new Table { TableNumber=4,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 5, AssignRestaurent = null },
 new Table { TableNumber=5,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 5, AssignRestaurent = null },
 new Table { TableNumber=1,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 6, AssignRestaurent = null },
 new Table { TableNumber=2,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 6, AssignRestaurent = null },
 new Table { TableNumber=3,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 6, AssignRestaurent = null },
 new Table { TableNumber=4,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 6, AssignRestaurent = null },
 new Table { TableNumber=5,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 6, AssignRestaurent = null },
 new Table { TableNumber=1,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 7, AssignRestaurent = null },
 new Table { TableNumber=2,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 7, AssignRestaurent = null },
 new Table { TableNumber=3,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 7, AssignRestaurent = null },
 new Table { TableNumber=4,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 7, AssignRestaurent = null },
 new Table { TableNumber=5,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 7, AssignRestaurent = null },
 new Table { TableNumber=1,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 8, AssignRestaurent = null },
 new Table { TableNumber=2,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 8, AssignRestaurent = null },
 new Table { TableNumber=3,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 8, AssignRestaurent = null },
 new Table { TableNumber=4,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 8, AssignRestaurent = null },
 new Table { TableNumber=5,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 8, AssignRestaurent = null },
 new Table { TableNumber=1,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 9, AssignRestaurent = null },
 new Table { TableNumber=2,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 9, AssignRestaurent = null },
 new Table { TableNumber=3,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 9, AssignRestaurent = null },
 new Table { TableNumber=4,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 9, AssignRestaurent = null },
 new Table { TableNumber=5,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 9, AssignRestaurent = null },
 new Table { TableNumber=1,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 10, AssignRestaurent = null },
 new Table { TableNumber=2,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 10, AssignRestaurent = null },
 new Table { TableNumber=3,TableType = "Table for two", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 10, AssignRestaurent = null },
 new Table { TableNumber=4,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 10, AssignRestaurent = null },
 new Table { TableNumber=5,TableType = "Table for Four", TimeofBooking = null, DateofBooking = null, assignedto = null, AssignRestaurentId = 10, AssignRestaurent = null }
 
                
                  );
                context.SaveChanges();
            }
        }
    }
}