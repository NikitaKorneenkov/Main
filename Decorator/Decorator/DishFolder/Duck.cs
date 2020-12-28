using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Duck : Dish
    {
        public override string GetDescription()
        {
            return "Duck"; 
        }

        public override double cost()
        {
            return 9.99;
        }
    }
}
