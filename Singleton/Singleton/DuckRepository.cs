using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class DuckRepository
    {
        public Dictionary<string, int> Storage;

        private DuckRepository()
        {
            init();
        }

        private void init()
        {
            Storage = new Dictionary<string, int>();
            Console.WriteLine("Единственный экземпляр склада создан...");
        }

        public void Add(string duckType)
        {
            if (Storage.ContainsKey(duckType))
            {
                Storage[duckType]++;
            }
            else
            {
                Storage.Add(duckType, 1);
            }
        }

        private static DuckRepository _item;

        public static DuckRepository Get()
        {
            if (_item == null)
            {
                _item = new DuckRepository();
            }
            return _item;
        }
    }
}
