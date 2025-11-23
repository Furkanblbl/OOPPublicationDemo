using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPublicationDemo
{
    internal class Magazine : Publication
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, string publisher, int publishYear, int issueNumber) : base(title, publisher, publishYear)
        {
            IssueNumber = issueNumber;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Issue Number: {IssueNumber}");
        }
    }
}
