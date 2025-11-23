using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPublicationDemo
{
    internal class Book : Publication
    {
        public int PageCount { get; set; }
        public string Author { get; set; }

        public Book(string title, string publisher, int publishYear,
            int pageCount, string author) : base(title, publisher, publishYear)
        {
            PageCount = pageCount;
            Author = author;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Page Count: {PageCount}");
        }

    }
}
