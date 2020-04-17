using System;
using System.Threading;

namespace Singleton_Object_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass tester = new TestClass();
            tester.GenerateWriters();
            tester.GenerateWriters2();
            tester.SetMSG();
            tester.SetMSG2();


            Thread thread1 = new Thread(tester.WriteFromWriters);
            thread1.Start();

            Thread thread2 = new Thread(tester.WriteFromWriters2);
            thread2.Start();


        }
    }
}
