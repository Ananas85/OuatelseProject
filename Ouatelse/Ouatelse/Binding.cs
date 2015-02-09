using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse
{
    public class Binding
    {
        private List<Bind> Binds = new List<Bind>();
        public void Bind(Bind b)
        {
            Binds.Add(b);
        }

        public void Populate()
        {
            foreach (Bind b in Binds)
            {
                object val = b.destPropInfo.GetValue(b.o2, null);
                b.srcPropInfo.SetValue(b.o1, val, null);
            }
        }

        public void Hydrate()
        {
            foreach (Bind b in Binds)
            {
                object val = b.srcPropInfo.GetValue(b.o1, null);
                b.destPropInfo.SetValue(b.o2, val, null);
            }
        }
    }
}
