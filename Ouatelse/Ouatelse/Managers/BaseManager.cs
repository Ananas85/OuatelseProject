using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    public abstract class BaseManager<T> : IManager<T>
    {
        Database db = Database.Instance;
        protected string tableName = "";

        public T[] All()
        {
            DataSet ds =  db.GetDataSet("SELECT * FROM " + tableName);
            List<T> res = new List<T>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                T entity = (T)Activator.CreateInstance(typeof(T));
                ((IModel)entity).Hydrate(row.ItemArray);
                res.Add(entity);
            }
            return res.ToArray();
        }

        public T[] Filter(string filter)
        {
            DataSet ds = db.GetDataSet("SELECT * FROM " + tableName + " " + filter);
            return new T[] { };
        }

        public int Count(string filter = "")
        {
            return (int)db.ExecuteScalar("SELECT count(*) FROM " + tableName + " " + filter);
        }

        public T Find(object id)
        {
            DataSet ds = db.GetDataSet("SELECT * FROM " + tableName + " WHERE id=" + id.ToString());
            DataRowCollection rows = ds.Tables[0].Rows;
            if (rows.Count == 0)
                return default(T);
            DataRow row = rows[0];
            T entity = (T)Activator.CreateInstance(typeof(T));
            ((IModel)entity).Hydrate(row.ItemArray);
            return entity;
        }
    }
}
