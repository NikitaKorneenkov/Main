using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckFarm.Interface;

namespace DuckFarm.Move
{
    public class CanNotSwim : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("Я не умею плавать!");
        }
    }
}
