using System;
using System.Collections.Generic;

namespace library_system
{
    // class Book {
    //     public string Title {get; set;}

    //     public string Author {get; set;}

    //     public int ISBN {get; set;}

    // }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Book WarAndPeace = new Book("War and Peace", "Leo Tolstoy"){
                ISBN = 12345
            };

            Book AnnaKarenina = new Book("Anna Karenina", "Leo Tolstoy"){
                ISBN = 12346
            };

            Console.WriteLine($"{WarAndPeace.Title} by {WarAndPeace.Author}");

            List<Book> LibraryInventory = new List<Book>(){
                WarAndPeace,
                AnnaKarenina,
                new Book("The Glass Castle", "Jeanette Walls"){
                    ISBN = 32421
                }
            };

            LibraryInventory.ForEach(book => Console.WriteLine(book.Title));

            Patron steve = new Patron(){
                LastName = "Brownlee"
            };

            steve.FirstName = "Steeeeeve";

            steve.CheckOutBook(WarAndPeace);
            Console.WriteLine();

            Librarian Sarah = new Librarian(){
                FirstName = "Sarah",
                LastName = "Brooks"
            };
        }
    }
}
