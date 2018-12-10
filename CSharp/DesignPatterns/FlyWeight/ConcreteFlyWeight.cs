using System;

namespace FlyWeight
{
    public class ConcreteFlyWeight : FlyWeight
    {
        public ConcreteFlyWeight()
        {
        }

        public override void Operation(int ext)
        {
            Console.WriteLine($"ConcreteFlyWeight: {ext}");
        }
    }
}