using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Chicken : Dish
    {
        public override string GetDescription()
        {
            return "Chicken";
        }
        public override double cost()
        {
            return 7.99;
        }
    }
}
