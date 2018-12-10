using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }

        public string Title { get; set; }

        public Book(string author, string title, int copies)
        {
            this.Author = author;
            this.Title = title;
            this.Copies = copies;
        }

        public override void Show()
        {
            Console.WriteLine("\nLivro ----");
            Console.Write($" Autor: {Author}");
            Console.Write($" Titulo: {Title}");
            Console.Write($" Copias: {Copies}");
        }
    }
}
