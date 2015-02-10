using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ouatelse.Managers;

namespace Ouatelse.Models
{
    public class ManyCollection<EntityT>
    {
        private List<EntityT> items = new List<EntityT>();
        private string column;
        private object id;
        private IManager<EntityT> manager;

        public ManyCollection(IManager<EntityT> manager, string column, string property, object id)
        {
            this.column = column;
            this.id = id;
            this.manager = manager;
            Reload();
        }

        public void Reload()
        {
            items.Clear();
            items.AddRange(manager.Filter(String.Format(" WHERE {0} = '{1}'", column, id)));
        }

        public void Add(EntityT entity)
        {
            /*Type t = typeof(entity);
            t.GetProperty(property).SetValue(entity, Int32.Parse(this.id.ToString()));
            manager.Save(entity);
            items.Add(entity);*/
        }
    }
}
