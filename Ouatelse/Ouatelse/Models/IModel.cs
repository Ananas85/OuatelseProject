using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    interface IModel
    {
        string ManagerName { get; }
        void Hydrate(object[] data);
    }
}
