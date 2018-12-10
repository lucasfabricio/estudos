using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name)
            : base(name)
        {

        }

        public override void Add(Component c)
        {
            this.children.Add(c);
        }

        public override void Remove(Component c)
        {
            this.children.Remove(c);
        }

        public override void Show(int d)
        {
            Console.WriteLine(new String('-', d) + name);

            foreach (var item in this.children)
            {
                item.Show(d + 2);
            }
        }
    }
}
