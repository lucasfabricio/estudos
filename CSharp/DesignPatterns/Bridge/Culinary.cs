using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Culinary : IChannel
    {
        public string Channel()
        {
            return "Sintonizado no Canal de culinaria";
        }

        public string Status()
        {
            return "Você está assistindo - Cake Boss";
        }
    }
}
