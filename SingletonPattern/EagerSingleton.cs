using System;

namespace SingletonPattern
{
    public class EagerSingleton
    {
        private string name;

        private int randomNumber;

        private static EagerSingleton instance = new EagerSingleton("Eager Singleton Instance 1:", new Random(2).Next(2000));

        private EagerSingleton(string name, int randomNumber)
        {
            this.randomNumber = randomNumber;
            this.name = name;
        }

        public static EagerSingleton GetInstance()
        {
            return instance;
        }

        public string Name => this.name;

        public int RandomNumber => this.randomNumber;
    }
}