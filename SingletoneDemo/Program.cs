using Logger;
using System;

namespace SingletoneDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Log.GetInstance.LogException("Test log");
        }
    }
}
