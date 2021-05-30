using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library 
    {
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            Zip = zip;
        }
        public override string ToString()
        {

            //return base.ToString();
            return string.Format("Library:\n" +
                "Books: {0}\n" +
                "LibraryName: {1}\n" +
                "StreetAddress: {2}\n" +
                "City: {3}\n" +
                "Zip: {4}\n",
                Books, LibraryName, StreetAddress, City, Zip);
        }
    }
}
