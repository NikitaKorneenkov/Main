using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckFarm.Interface;
using DuckFarm.Move;

namespace DuckFarm.Ducks
{
    class WoodenDuck : BaseDuck
    {
        public WoodenDuck() : base(new CanNotFly(), new CanSwim(), new CanNotQuack())
        { }
    }
}
