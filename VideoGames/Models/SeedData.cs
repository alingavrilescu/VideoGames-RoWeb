using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using VideoGames.Data;

namespace VideoGames.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VideoGamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VideoGamesContext>>()))
            {
                // Look for any movies.
                if (context.Games.Any())
                {
                    return;   // DB has been seeded
                }

                context.Games.AddRange(
                    new Games
                    {
                        Title = "Hunt Showdown",
                        ReleaseDate = DateTime.Parse("2018-2-22"),
                        Genre = "Action Horror",
                        Price = 39.99M
                    },

                    new Games
                    {
                        Title = "Witcher 3 Wild Hunt ",
                        ReleaseDate = DateTime.Parse("2015-5-18"),
                        Genre = "Action RPG",
                        Price = 29.99M
                    },

                    new Games
                    {
                        Title = "Red Dead Redemption II",
                        ReleaseDate = DateTime.Parse("2018-10-26"),
                        Genre = "Action RPG Western",
                        Price = 59.99M
                    },

                    new Games
                    {
                        Title = "God of War 2018",
                        ReleaseDate = DateTime.Parse("2018-1-14"),
                        Genre = "Action/Adventure H&S",
                        Price = 59.99M
                    },

                    new Games
                    {
                        Title = "Uncharted 4: A Thief's End",
                        ReleaseDate = DateTime.Parse("2016-1-28"),
                        Genre = "Action/Adventure",
                        Price = 59.99M
                    },

                    new Games
                    {
                        Title = "Ghost of Tsushima",
                        ReleaseDate = DateTime.Parse("2020-7-17"),
                        Genre = "Action/Adventure",
                        Price = 59.99M
                    },

                    new Games
                    {
                        Title = "Mafia II",
                        ReleaseDate = DateTime.Parse("2010-8-23"),
                        Genre = "Action RPG",
                        Price = 19.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}