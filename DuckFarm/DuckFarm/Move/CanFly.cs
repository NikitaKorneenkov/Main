using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckFarm.Interface;

namespace DuckFarm.Move
{
    public class CanFly:IFly
    {
        public void Fly()
        {
            Console.WriteLine("Я умею летать!");
        }
    }
}
