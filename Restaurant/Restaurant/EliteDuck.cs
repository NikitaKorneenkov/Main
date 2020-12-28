using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class EliteDuck
    {
        List<MenuItem> menuItems;
        public EliteDuck()
        {
            menuItems = new List<MenuItem>();

            addItem("Утка по-пекински", "молодая утка, херес, соль, имбирь(тертый)", 25.99);
            addItem("Утиная грудка", "утка, орегано, яблочный уксус, соевый соус", 49.99);
            addItem("Котлеты из утки", "утка, репчатый лук, чеснок, молоко", 19.99);
            addItem("Утка, фаршированная гречкой", "утка, гречка, вода, чеснок", 99.99);
        }
        public void addItem(string name, string description, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, price);
            menuItems.Add(menuItem);
        }
        public IIterator createIterator()
        {
            return new eliteIterator(menuItems);
        }
    }
}
