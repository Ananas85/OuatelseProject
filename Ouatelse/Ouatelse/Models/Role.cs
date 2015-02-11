using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class Role : BaseModel, IModel
    {
        public string Name { get; set; }
        public Role ParentRole { get; set; }


        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.Name = cursor.Read().ToString();
            string parent = cursor.Read().ToString();
            if (!String.IsNullOrEmpty(parent))
                this.ParentRole = RoleManager.Instance.Find(parent);            
        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string>();
            res.Add("libelle_role", Name);
            res.Add("parent_role_id", ParentRole.Id.ToString());
            return res;
        }
    }
}
