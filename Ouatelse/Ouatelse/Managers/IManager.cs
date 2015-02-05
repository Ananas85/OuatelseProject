using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Interface qui permet de gérer nos managers en iutilisant les types Génériques
    /// </summary>
    /// <typeparam name="T">Le type dy manager</typeparam>
    interface IManager<T>
    {
        T[] All();
        T[] Filter(string filter);

        int Count(string filter = "");
        T Find(object id);

    }
}
