using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class SeedData
    {
        //This class automatically adds data to the database
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDBContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //These are all the current books in the database. The BookID field is automatically generated
            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        AuthorMiddle ="",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Class = "Fiction",
                        Cat = "Classic",
                        Price = "$9.95"
                    },
                    new Book
                    {
                        Title = "Team Rivals",
                        AuthorFirst = "Doris",
                        AuthorLast = "Goodwin",
                        AuthorMiddle = "Kearns",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Class = "Non-fiction",
                        Cat = "Biography",
                        Price = "$14.58"
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Shroeder",
                        AuthorMiddle = "",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Class = "Non-fiction",
                        Cat = "Biography",
                        Price = "$21.54"
                    },


                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorLast = "White",
                        AuthorMiddle = "C",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Class = "Non-fiction",
                        Cat = "Biography",
                        Price = "$11.61"
                    },


                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Lauren",
                        AuthorLast = "Hildenbrand",
                        AuthorMiddle = "",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Class = "Non-fiction",
                        Cat = "Historical",
                        Price = "$13.33"
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        AuthorMiddle = "",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Class = "Fiction",
                        Cat = "Historical Fiction",
                        Price = "$15.95"
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        AuthorMiddle = "",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Class = "Non-fiction",
                        Cat = "Self-Help",
                        Price = "$14.99"
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        AuthorMiddle = "",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Class = "Non-fiction",
                        Cat = "Self-Help",
                        Price = "$21.66"
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        AuthorMiddle = "",
                        Publisher = "Portfolio",
                        ISBN = "978-15919847984",
                        Class = "Non-fiction",
                        Cat = "Business",
                        Price = "$29.16"
                    },
                    new Book
                    {
                        Title = "Sycamore Way",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        AuthorMiddle = "",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Class = "Fiction",
                        Cat = "Thrillers",
                        Price = "$15.03"
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
