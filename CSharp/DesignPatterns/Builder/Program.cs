using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Manufacturer man = new Manufacturer();

            ICellphone cellphoneBuilder = null;

            cellphoneBuilder = new AndroidBuilder();
            man.Constructor(cellphoneBuilder);
            Console.WriteLine($"Novo celular construído: {cellphoneBuilder.Cellphone.Name}");

            Console.ReadKey();
        }
    }
}
