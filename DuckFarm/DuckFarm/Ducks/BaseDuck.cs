using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckFarm.Interface;

namespace DuckFarm.Ducks
{
    public abstract class BaseDuck
    {
        readonly IFly _fly;
        readonly ISwim _swim;
        readonly IQuack _quack;
        protected BaseDuck(IFly fly, ISwim swim, IQuack quack)
        {
            _fly = fly;
            _swim = swim;
            _quack = quack;
        }
        public void Fly()
        {
            _fly.Fly();
        }
        public void Swim()
        {
            _swim.Swim();
        }
        public void Quack()
        {
            _quack.Quack();
        }
    }
}
