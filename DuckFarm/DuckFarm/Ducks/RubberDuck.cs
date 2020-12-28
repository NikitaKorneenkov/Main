using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckFarm.Interface;
using DuckFarm.Move;

namespace DuckFarm.Ducks
{
    class RubberDuck:BaseDuck
    {
        public RubberDuck() : base(new CanNotFly(), new CanSwim(), new CanQuack())
        { }
    }
}
