using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Class_Constructor
{
    public class Book
    {
        private string title;
        private string author;

        // Default constructor
        public Book()
        {
            title = "Unknown";
            author = "Unknown";
        }

        // Custom constructor with two parameters
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        // Overloaded constructor with one parameter
        public Book(string title)
        {
            this.title = title;
            author = "Unknown";
        }

        // Properties for Title and Author
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
    } // class

} // namespace
