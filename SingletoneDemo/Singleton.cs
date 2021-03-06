using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletoneDemo
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object obj = new object();
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null) {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
