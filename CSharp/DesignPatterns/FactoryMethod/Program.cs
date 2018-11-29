using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieFactory factory = new MovieFactory();

            IMovie actionMovie = factory.NewMovie("ACTION");
            actionMovie.MakeMovie();

            Console.ReadKey();
        }
    }
}
