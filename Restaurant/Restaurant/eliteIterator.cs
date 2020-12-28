using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class eliteIterator : IIterator
    {
        List<MenuItem>_items;
        int _position = 0;

        public eliteIterator(List <MenuItem> items)
        {
            this._items = items;
        }

        public MenuItem next()
        {
            MenuItem menuItem = _items[_position];
            _position++;
            return menuItem;
        }

        public bool hasNext()
        {
            if (_position >= _items.Count || _items[_position] == null)
                return false;
            else
                return true;
        }
    }
}
