using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class Store : BaseModel
    {
        public string Address { get; set; }
        public City City { get; set; }
    }
}
