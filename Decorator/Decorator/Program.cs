using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.DecoratorFolder;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dish dish = new Chicken();
            Console.WriteLine(dish.GetDescription() + " $" + dish.cost());

            Dish dish2 = new Duck();
            dish2 = new Sauce(dish2);

            Console.WriteLine(dish2.GetDescription() + " $" + dish2.cost());

            Dish dish3 = new Turkey();
            dish3 = new Sauce(dish3);
            dish3 = new Pepper(dish3);

            Console.WriteLine(dish3.GetDescription() + " $" + dish3.cost());

            Console.ReadLine();
        }
    }
}
