using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    interface IManager<T>
    {
        T[] All();
        T[] Filter(string filter);

        int Count(string filter = "");
        T Find(object id);

    }
}
