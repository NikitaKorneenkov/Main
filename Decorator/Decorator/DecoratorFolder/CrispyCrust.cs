using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DecoratorFolder
{
    public class CrispyCrust : Dish
    {
        Dish dish;

        public CrispyCrust(Dish dish)
        {
            this.dish = dish;
        }

        public override string GetDescription()
        {
            return dish.GetDescription() + ", with crispyCrust";
        }

        public override double cost()
        {
            return .50 + dish.cost();
        }
    }
}
