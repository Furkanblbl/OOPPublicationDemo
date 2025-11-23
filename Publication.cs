using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOPPublicationDemo
{
    internal class Publication
    {
        public string Title {  get; set; }
        public string Publisher {  get; set; }
        public int PublicationYear { get; set; }
        public Publication(string title, string publisher, int publicationYear) 
        {
            Title = title;
            Publisher = publisher;
            PublicationYear = publicationYear;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Publish Year: {PublicationYear}");
        }


    }
}
