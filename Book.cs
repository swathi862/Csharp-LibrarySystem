using System;

namespace library_system
{
    public class Book {

        public Book(string titleParam, string authorParam){
            Title = titleParam;
            Author = authorParam;
        }
        public string Title {get; set;}

        public string Author {get; set;}

        public int ISBN {get; set;}

    }

}