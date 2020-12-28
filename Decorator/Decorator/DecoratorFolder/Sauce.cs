using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DecoratorFolder
{
    public class Sauce : Dish
    {
        Dish dish;

        public Sauce(Dish dish)
        {
            this.dish = dish;
        }

        public override string GetDescription()
        {
            return dish.GetDescription() + ", with sauce";
        }

        public override double cost()
        {
            return 1.99 + dish.cost();
        }
    }
}
