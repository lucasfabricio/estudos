using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("JRR Tolkien", "O Senhor dos anéis", 10);
            book.Show();

            var video = new Video("George Lucas", "Star Wars", 180, 20);
            video.Show();

            Console.WriteLine("\nEmprestando um video");

            var borrowed = new Borrowed(video);
            borrowed.BorrowItem("Lucas");
            borrowed.BorrowItem("Fabricio");

            borrowed.Show();

            borrowed.Return("Fabricio");
            borrowed.Return("Lucas");

            borrowed.Show();

            Console.ReadKey();
        }
    }
}
