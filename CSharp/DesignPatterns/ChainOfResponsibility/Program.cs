using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandlerA();
            Handler h2 = new ConcreteHandlerB();
            Handler h3 = new ConcreteHandlerC();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] requests = { 1, 5, 7, 19, 40, 23, 2, 10, 0 };

            foreach (var request in requests)
            {
                h1.HandleRequest(request);
            }

            Console.ReadKey();
        }
    }
}
