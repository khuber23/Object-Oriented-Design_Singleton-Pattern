using System;
using System.Threading;

namespace SingletonPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LazySingleton ls = LazySingleton.GetInstance();

            EagerSingleton es = EagerSingleton.GetInstance();

            Console.WriteLine(ls.Name + ls.RandomNumber);

            Console.WriteLine(es.Name + es.RandomNumber);

            Console.WriteLine();

            ls = LazySingleton.GetInstance();

            es = EagerSingleton.GetInstance();

            Console.WriteLine(ls.Name + ls.RandomNumber);

            Console.WriteLine(es.Name + es.RandomNumber);

            Console.Read();
        }
    }
}