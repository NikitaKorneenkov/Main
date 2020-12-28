using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class DuckForAll
    {
        static int Max_Items = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DuckForAll()
        {
            menuItems = new MenuItem[Max_Items];

            addItem("Утка тушеная", "утка, лук, соль, паприка, масло", 2.99);
            addItem("Утка запеченная", "утка, картофель, чеснок, черный перец", 5.99);
            addItem("Утка с яблоками", "утка, яблоки, соль, сок лимона, корица", 3.99);
            addItem("Утка с медом", "утка, мед, вода, соль, перец черный", 1.99);
        }
        public void addItem(string name, string description, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, price);
            if (numberOfItems >= Max_Items)
            {
                Console.WriteLine("Меню переполнено!");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }
        public IIterator createIterator()
        {
            return new forAllIterator(menuItems);
        }
    } 
}

