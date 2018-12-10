using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }

        public IEmployee Clone()
        {
            return this.MemberwiseClone() as IEmployee;
        }
    }
}
