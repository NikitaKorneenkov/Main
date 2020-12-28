﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckFarm.Interface;
using DuckFarm.Move;

namespace DuckFarm.Ducks
{
    class Duck:BaseDuck
    {
        public Duck() : base(new CanFly(), new CanSwim(), new CanQuack())
        { }

    }
}
