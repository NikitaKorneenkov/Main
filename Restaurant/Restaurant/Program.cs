using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            EliteDuck eliteDuck = new EliteDuck();
            

            DuckForAll duckForAll = new DuckForAll();
            Waitress waitress = new Waitress(duckForAll, eliteDuck);

            waitress.printMenu();
            

            Console.ReadLine();

        }
    }
}
