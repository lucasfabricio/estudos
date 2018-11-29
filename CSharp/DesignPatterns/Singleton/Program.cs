using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton msg1 = Singleton.GetInstance;
            msg1.ShowMessage("Hey!");

            Singleton msg2 = Singleton.GetInstance;
            msg2.ShowMessage("Ho!");

            Singleton msg3 = Singleton.GetInstance;
            msg3.ShowMessage("Let's go!");

            Console.ReadKey();
        }
    }
}
