using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Video : LibraryItem
    {
        public string Director { get; set; }

        public string Title { get; set; }

        public int Duration { get; set; }

        public Video(string director, string title, int duration, int copies)
        {
            this.Director = director;
            this.Title = title;
            this.Duration = duration;
            this.Copies = copies;
        }

        public override void Show()
        {
            Console.WriteLine("\nVideo ----");
            Console.Write($" Diretor: {Director}");
            Console.Write($" Titulo: {Title}");
            Console.Write($" Duracao: {Duration}");
            Console.Write($" Copias: {Copies}");
        }
    }
}
