using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Waitress
    {
        DuckForAll duckForAll;
        EliteDuck eliteDuck;

        public Waitress(DuckForAll duckForAll, EliteDuck eliteDuck)
        {
            this.duckForAll = duckForAll;
            this.eliteDuck = eliteDuck;
        }

        public void printMenu()
        {
            IIterator forAllIterator = duckForAll.createIterator();
            IIterator eliteIterator = eliteDuck.createIterator();
            Console.WriteLine("Меню\n");
            Console.WriteLine("Для всех\n");
            printMenu(forAllIterator);
            Console.WriteLine("\nДля элитных посетителей\n");
            printMenu(eliteIterator);

        }
        private void printMenu(IIterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuItem menuItem = iterator.next();
                Console.Write(menuItem.getName() + ", ");
                Console.Write(menuItem.getPrice() + "----");
                Console.WriteLine(menuItem.getDescription() + "");
            }
        }
    }
}
