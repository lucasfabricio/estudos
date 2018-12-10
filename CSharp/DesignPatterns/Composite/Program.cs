using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("ROOT");
            root.Add(new Leaf("A"));
            root.Add(new Leaf("B"));

            Composite comp = new Composite("COMPOSITE X");
            comp.Add(new Leaf("XA"));
            comp.Add(new Leaf("XB"));

            root.Add(comp);
            root.Add(new Leaf("C"));

            Leaf leaf = new Leaf("D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Show(1);

            Console.ReadKey();
        }
    }
}
