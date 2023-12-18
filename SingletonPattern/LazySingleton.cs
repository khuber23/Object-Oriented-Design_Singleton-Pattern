using System;

namespace SingletonPattern
{
    public class LazySingleton
    {
        private string name;

        private int randomNumber;

        private static LazySingleton instance;

        private LazySingleton(string name, int randomNumber)
        {
            this.randomNumber = randomNumber;
            this.name = name;
        }

        public static LazySingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new LazySingleton("Lazy Singleton 1:", new Random(1).Next(2000));
            }
            return instance;
        }

        public string Name => this.name;

        public int RandomNumber => this.randomNumber;
    }
}