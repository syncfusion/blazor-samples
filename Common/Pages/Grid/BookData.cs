#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace blazor_bookdatasource
{

    public sealed class Book
    {
        public string BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public string PublishDate { get; set; }

        public int AvailableCopies { get; set; }

        public string Location { get; set; }

        public string Status { get; set; }
    }

    public static class BookData
    {
        public static List<Book> GetAllRecords()
        {
            var books = new List<Book>();

            string[] titles = new[]
            {
                "The Morning Chronicles", "Whispers in the Dark", "Beyond the Horizon", "The Silent Garden",
                "Dreams and Reality", "Journey Through Time", "The Hidden Path", "Echoes of Yesterday",
                "The Last Lighthouse", "Broken Promises", "The Golden Key", "Shadows of Truth",
                "The Winter Palace", "Lost in Translation", "The Crimson River", "Secrets of the Deep",
                "The Forgotten City", "Rising from Ashes", "The Midnight Bell", "Voices in the Wind",
                "The Crystal Tower", "Beneath the Stars", "The Velvet Cage", "Through the Looking Glass",
                "The Ancient Scroll", "Hearts Collide", "The Emerald Stone", "Dance of Shadows",
                "The Silver Compass", "Unlocking Destiny", "The Obsidian Mirror", "Tales of Wonder",
                "The Sapphire Key", "Mountains of Tomorrow", "The Marble Halls", "Whispered Secrets",
                "The Crimson Crown", "Journeys End", "The Thunder Road", "Sunset Over Paradise",
                "The Ruby Heart", "Dawn of a New Era", "The Iron Gates", "Melody of Life",
                "The Copper Coin", "Reflections of the Soul", "The Pearl Bridge", "Echoes of Tomorrow",
                "The Bronze Bell", "Stories Untold", "The Diamond Path", "Wings of Freedom"
            };

            string[] authors = new[]
            {
                "James Mitchell", "Sarah Anderson", "Michael Chen", "Emma Richardson",
                "David Thompson", "Lisa Martinez", "Robert Williams", "Jennifer Lopez",
                "Christopher Brown", "Maria Garcia", "Daniel Taylor", "Amanda White",
                "Andrew Johnson", "Rachel Green", "Kevin Davis", "Nicole Bell",
                "Joseph Harris", "Victoria Black", "Matthew Young", "Lauren Scott",
                "Mark Wilson", "Jessica Turner", "Steven Moore", "Sophia Parker",
                "Patrick Jackson", "Olivia Martin", "Ryan Anderson", "Isabella Rodriguez",
                "Brian Lee", "Charlotte Thomas", "Eric Campbell", "Abigail Lewis",
                "Jason Hall", "Mia Walker", "Jacob Allen", "Ava Kings",
                "Justin Hernandez", "Emily Clark", "Brandon Wright", "Harper Lopez",
                "Samuel Hill", "Evelyn Green", "Alexander Scott", "Ella Adams",
                "Gabriel Nelson", "Scarlett Baker", "Noah Carter", "Grace Nelson",
                "Ethan Rivera", "Chloe Mitchell", "Logan Roberts", "Zoey Phillips"
            };

            string[] categories = new[]
            {
                "Fiction", "Non-Fiction", "Science", "History", "Biography",
                "Mystery", "Romance", "Technology", "Education"
            };

            string[] statuses = new[] { "Available", "Borrowed", "Reserved", "Damaged" };

            string[] locations = GenerateShelfLocations();

            for (int i = 1; i <= 300; i++)
            {
                string bookId = $"BOOK{i:D3}";
                string title = $"{titles[(i - 1) % titles.Length]} - Vol {(i / titles.Length) + 1}";
                string author = authors[(i - 1) % authors.Length];
                string category = categories[(i - 1) % categories.Length];
                string publishDate = GeneratePublishDate(i);
                int availableCopies = (i % 10) + 1;
                string location = locations[(i - 1) % locations.Length];
                string status = statuses[(i - 1) % statuses.Length];

                books.Add(new Book
                {
                    BookId = bookId,
                    Title = title,
                    Author = author,
                    Category = category,
                    PublishDate = publishDate,
                    AvailableCopies = availableCopies,
                    Location = location,
                    Status = status
                });
            }

            return books;
        }

        private static string GeneratePublishDate(int index)
        {
            int year = 1980 + (index % 45);
            int month = (index % 12) + 1;
            int day = (index % 28) + 1;

            return new DateTime(year, month, day).ToString("yyyy-MM-dd");
        }

        private static string[] GenerateShelfLocations()
        {
            var locations = new List<string>();
            string[] sections = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            for (int floor = 1; floor <= 5; floor++)
            {
                foreach (var section in sections)
                {
                    for (int shelf = 1; shelf <= 10; shelf++)
                    {
                        locations.Add($"Floor {floor}, Section {section}, Shelf {shelf}");
                    }
                }
            }

            return locations.ToArray();
        }
    }
}