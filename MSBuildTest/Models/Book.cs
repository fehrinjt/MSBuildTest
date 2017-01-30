using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSBuildTest.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}