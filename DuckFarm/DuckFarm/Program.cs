using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckFarm.Ducks;

namespace DuckFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck exp1 = new Duck();
            Console.WriteLine("Я живая утка:\n");
            exp1.Fly();
            exp1.Swim();
            exp1.Quack();
            WoodenDuck exp2 = new WoodenDuck();
            Console.WriteLine("\nЯ деревянная утка:\n");
            exp2.Fly();
            exp2.Swim();
            exp2.Quack();
            RubberDuck exp3 = new RubberDuck();
            Console.WriteLine("\nЯ резиновая утка:\n");
            exp3.Fly();
            exp3.Swim();
            exp3.Quack();
            Console.ReadLine();
        }
    }
}
