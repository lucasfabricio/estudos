using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SportingCarFactory : CarFactory
    {
        public override Engine InstallEngine()
        {
            return new V8();
        }

        public override Color Paint()
        {
            return new Metallic();
        }
    }
}
