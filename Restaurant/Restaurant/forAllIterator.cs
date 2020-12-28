using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class forAllIterator : IIterator
    {
        MenuItem[] items;
        int position = 0;

        public forAllIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public MenuItem next()
        {
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }

        public bool hasNext()
        {
            if (position >= items.Length || items[position] == null)
                return false;
            else
                return true;
        }
    }
}
