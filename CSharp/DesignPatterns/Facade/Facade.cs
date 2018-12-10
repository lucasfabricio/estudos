using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        private SubSystemA a;
        private SubSystemB b;
        private SubSystemC c;

        public Facade()
        {
            this.a = new SubSystemA();
            this.b = new SubSystemB();
            this.c = new SubSystemC();
        }

        public void MethodFA()
        {
            Console.WriteLine("\nMetodoFA() ------");
            this.b.MethodB();
            this.c.MethodC();
        }

        public void MethodFB()
        {
            Console.WriteLine("\nMetodoFB() ------");
            this.a.MethodA();
            this.c.MethodC();
        }
    }
}
