using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        //variable list

        private string Title;
        private string Author;
        private string ISBN;

        public string title
        {
            get { return Title; }
            set { Title = value; }
        }
        public string author
        {
            get { return Author; }
            set { Author = value; }
        }
        public string isbn
        {
            get { return ISBN; }
            set { isbn = value; }
        }

        public void DisplayInfo() //display info 
        {

            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();

        }


        //Book Constructor 
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {

            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;

        }


    }
}
