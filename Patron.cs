using System;
using System.Collections.Generic;

namespace library_system
{
    public class Patron : Person {
        private List<Book> _CheckedOutBooks {get; set;} = new List<Book>();

        public void CheckOutBook(Book bookToCheckOut){
            if(_CheckedOutBooks.Count < 10){
                _CheckedOutBooks.Add(bookToCheckOut);
            } else{
                Console.WriteLine("You have too many books checked out!");
            }
        }
    }

}