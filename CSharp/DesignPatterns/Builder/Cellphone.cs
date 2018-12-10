using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Cellphone
    {
        public Cellphone(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public string Display { get; set; }

        public string Battery { get; set; }

        public string System { get; set; }

        public string Camera { get; set; }
    }
}
