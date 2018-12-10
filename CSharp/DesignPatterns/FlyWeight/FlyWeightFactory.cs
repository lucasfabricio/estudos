using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class FlyWeightFactory
    {
        private Hashtable fw = new Hashtable();

        public FlyWeightFactory()
        {
            fw.Add("X", new ConcreteFlyWeight());
            fw.Add("Y", new ConcreteFlyWeight());
            fw.Add("Z", new ConcreteFlyWeight());
        }

        public FlyWeight GetFlyWeight(string key)
        {
            return (FlyWeight)fw[key];
        }
    }
}
