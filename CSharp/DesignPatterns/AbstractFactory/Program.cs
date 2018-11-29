using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Car regularCar = ExecuteAbstractFactory.MountCar("regular");
            Car sportingCar = ExecuteAbstractFactory.MountCar("sporting");

            Console.ReadKey();
        }
    }
}
