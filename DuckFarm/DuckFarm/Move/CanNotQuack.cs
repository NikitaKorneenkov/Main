using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckFarm.Interface;

namespace DuckFarm.Move
{
    public class CanNotQuack:IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Я не умею крякать!");
        }
    }
}
