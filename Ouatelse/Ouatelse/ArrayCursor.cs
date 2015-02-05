using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse
{
    /// <summary>
    /// Classe générique qui permet de parcourir un liste d'objet
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ArrayCursor<T>
    {
        T[] items;
        public int Index { get; set; }

        public ArrayCursor(IEnumerable<T> items)
        {
            this.items = items.ToArray();
            this.Index = 0;
        }

        public T Read()
        {
            if (Index >= items.Length)
                return default(T);
            T res = items[Index];
            Next();
            return res;
        }

        public void Next()
        {
            Index++;
        }

        public void Reset()
        {
            Index = 0;
        }
    }
}
