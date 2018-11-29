using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RegularCarFactory : CarFactory
    {
        public override Engine InstallEngine()
        {
            return new V6();
        }

        public override Color Paint()
        {
            return new Matte();
        }
    }
}
