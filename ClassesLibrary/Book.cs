using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
   public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        public Book(string title, string author, int nuberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = nuberOfPages;
        }
        public Book()
        {
            
        }
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Book:\n" +
                "Title: {0}\n" +
                "Author: {1}\n" +
                "NumberOfPages: {2}",
                Title, Author, NumberOfPages);
        }

    }//class
}//namespace
