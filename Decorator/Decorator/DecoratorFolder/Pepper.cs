using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DecoratorFolder
{
    public class Pepper : Dish
    {
        Dish dish;

        public Pepper(Dish dish)
        {
            this.dish = dish;
        }

        public override string GetDescription()
        {
            return dish.GetDescription() + ", with pepper";
        }

        public override double cost()
        {
            return 0.99 + dish.cost();
        }
    }
}
