using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Dish
    {
      public string description = "Unknown dish";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
