using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;

        private Singleton()
        {
        }

        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();

                return _instance;
            }
        }

        public void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
