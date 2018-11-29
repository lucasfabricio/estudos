using System;

namespace FactoryMethod
{
    class Commedy : IMovie
    {
        public void MakeMovie()
        {
            Console.WriteLine("Filme de comédia produzido!");
        }
    }
}
