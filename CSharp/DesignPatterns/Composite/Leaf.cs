using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {

        }

        public override void Add(Component c)
        {
            Console.WriteLine("Não foi possível adicionar a folha");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Não foi possível remover a folha");
        }

        public override void Show(int d)
        {
            Console.WriteLine(new String('-', d) + name);
        }
    }
}
