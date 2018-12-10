using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //BRIDGE
    public class SmartTV
    {
        public IChannel CurrrentChannel { get; set; }

        public void ShowChannel()
        {
            if (CurrrentChannel != null)
                Console.WriteLine(CurrrentChannel.Channel());
            else
                Console.WriteLine("Sintonize o canal");
        }

        public void ShowStatus()
        {
            if (CurrrentChannel != null)
                Console.WriteLine(CurrrentChannel.Status());
            else
                Console.WriteLine("Sintonize o canal para assistir algo");
        }
    }
}
