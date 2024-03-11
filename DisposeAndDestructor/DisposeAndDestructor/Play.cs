using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeAndDestructor.ClassPlay
{
    internal class Play
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }
        public int yearOfIssue { get; set; }

        private static int Count = 0;

        public Play() { Count++; }
        public Play(string name, string authorName, string genre, int yearOfIssue)
        {
            Count++;
            Name = name;
            AuthorName = authorName;
            Genre = genre;
            this.yearOfIssue = yearOfIssue;
        }

        public void Print()
        {
            Console.WriteLine($"Count: {Count}\nName: {Name}\nAuthor Name: {AuthorName}\nGenre {Genre}\nYear Of Issue: {yearOfIssue}");
        }

        ~Play()
        {
            Console.WriteLine($"Play {Count} was delete");
            Count--;
        }
    }
}
