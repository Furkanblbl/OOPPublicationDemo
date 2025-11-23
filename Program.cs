using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPublicationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book(
                "The Art of Programming",
                "TechPress",
                2021,
                850,
                "John Doe"
            );

            Magazine magazine = new Magazine(
                "Science Monthly",
                "Future Media",
                2023,
                42
            );

            Console.WriteLine("----- Book Info -----");
            book.PrintInfo();

            Console.WriteLine("\n----- Magazine Info -----");
            magazine.PrintInfo();

            Console.ReadLine();

        }
    }
}
