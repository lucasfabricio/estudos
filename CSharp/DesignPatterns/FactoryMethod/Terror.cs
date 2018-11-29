using System;

namespace FactoryMethod
{
    public class Terror : IMovie
    {
        public void MakeMovie()
        {
            Console.WriteLine("Filme de terror produzido!");
        }
    }
}
