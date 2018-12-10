using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTV smartTV = new SmartTV();
            Console.WriteLine("SELECIONE UM CANAL");
            Console.WriteLine(@"
                1 - FILMES
                2 - DOCUMENTARIOS
                3 - CULINARIA");

            var input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    smartTV.CurrrentChannel = new Movie();
                    break;
                case '2':
                    smartTV.CurrrentChannel = new Documentary();
                    break;
                case '3':
                    smartTV.CurrrentChannel = new Culinary();
                    break;
                default:
                    break;
            }

            Console.WriteLine();

            smartTV.ShowChannel();
            smartTV.ShowStatus();

            Console.ReadKey();
        }
    }
}
