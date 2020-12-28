using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Turkey : Dish
    {
        public override string GetDescription()
        {
            return "Turkey";
        }

        public override double cost()
        {
            return 12.99;
        }
    }
}
