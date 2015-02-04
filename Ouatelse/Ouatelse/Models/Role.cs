using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class Role : BaseModel
    {
        public string Name { get; set; }
        public Role ParentRole { get; set; }

    }
}
