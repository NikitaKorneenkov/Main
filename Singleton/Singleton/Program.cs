using System;
using System.Collections.Generic;
using DuckFarm.Ducks;


namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckRepository duckstorage = DuckRepository.Get();
            for (int i = 0; i < 4; i++)
            {
                Duck duck = new Duck();
                duckstorage.Add(duck.name);
            }

            for (int i = 0; i < 7; i++)
            {
                WoodenDuck woodenduck = new WoodenDuck();
                duckstorage.Add(woodenduck.name);
            }

            for (int i = 0; i < 10; i++)
            {
                RubberDuck rubberduck = new RubberDuck();
                duckstorage.Add(rubberduck.name);
            }

            Console.WriteLine("На складе имеется:");
            foreach (KeyValuePair<string, int> keyValue in duckstorage.Storage)
            {
                Console.WriteLine(keyValue.Key + ": " + keyValue.Value + " штук");
            }

            Console.ReadLine();
        }
    }
}
