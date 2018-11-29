using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class CarFactory
    {
        public abstract Color Paint();
        public abstract Engine InstallEngine();
    }
}
