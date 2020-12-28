using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckFarm.Interface;

namespace DuckFarm.Move
{
    public class CanNotFly:IFly
    {
        public void Fly()
        {
            Console.WriteLine("Я не умею летать!");
        }
    }
}
