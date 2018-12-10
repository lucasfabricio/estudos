using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Movie : IChannel
    {
        public string Channel()
        {
            return "Sintonizado no Canal de filmes";
        }

        public string Status()
        {
            return "Você está assistindo - Os Simpsons";
        }
    }
}
