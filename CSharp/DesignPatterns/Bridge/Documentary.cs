using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Documentary : IChannel
    {
        public string Channel()
        {
            return "Sintonizado no Canal de documentário";
        }

        public string Status()
        {
            return "Você está assistindo - O Universo";
        }
    }
}
