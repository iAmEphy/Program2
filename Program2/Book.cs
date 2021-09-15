using System;

namespace Program2
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;
        //Constructor
        public Book(string name, string author, int pages)
        {
            this.title = name;
            this.author = author;
            this.pages = pages;
            Console.WriteLine("Book created: " + name);
        }



    }
}

