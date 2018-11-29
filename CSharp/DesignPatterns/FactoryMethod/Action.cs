using System;

namespace FactoryMethod
{
    public class Action : IMovie
    {
        private const string Value = "Filme de ação produzido!";

        public void MakeMovie()
        {
            Console.WriteLine(Value);
        }
    }
}
