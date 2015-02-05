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

        /// <summary>
        /// Récupère toutes les entitées présentes dans la table
        /// </summary>
        /// <returns>Un talbeau d'objets</returns>
        public T[] All()
        {
            // On récupère le DataSet
            DataSet ds =  db.GetDataSet("SELECT * FROM " + tableName);
            List<T> res = new List<T>();

            // On parcourt les lignes de résultat
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                // On crée une instance de T
                T entity = (T)Activator.CreateInstance(typeof(T));
                // On l'hydrate avec le données
                ((IModel)entity).Hydrate(row.ItemArray);
                ((IModel)entity).MakeExistant();
                // On l'ajoute dans la liste résultat
                res.Add(entity);
            }

            return res.ToArray();
        }

        /// <summary>
        /// Permet de récupérer certaines entités selon un filtre SQL.
        /// </summary>
        /// <param name="filter">Filtre SQL, par ex . "WHERE id = 10".</param>
        /// <returns>Un Tableau d'objets</returns>
        public T[] Filter(string filter)
        {
            DataSet ds = db.GetDataSet("SELECT * FROM " + tableName + " " + filter);
            List<T> res = new List<T>();

            // On parcourt les lignes de résultat
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                // On crée une instance de T
                T entity = (T)Activator.CreateInstance(typeof(T));
                // On l'hydrate avec le données
                ((IModel)entity).Hydrate(row.ItemArray);
                ((IModel)entity).MakeExistant();
                // On l'ajoute dans la liste résultat
                res.Add(entity);
            }

            return res.ToArray();
        }

        /// <summary>
        /// Permet de récupérer la première entité selon un filtre SQL.
        /// </summary>
        /// <param name="filter">Filtre SQL, par ex . "WHERE id = 10".</param>
        /// <returns>Le premier objet trouvé dans la table</returns>
        public T First(string filter)
        {
            DataSet ds = db.GetDataSet("SELECT * FROM " + tableName + " " + filter);
            DataRowCollection rows = ds.Tables[0].Rows; // On récupère les lignes

            if (rows.Count == 0)        // Si il n'y a pas de résultats...
                return default(T);      // On retourne un objet vide
            // On récupère la première ligne
            DataRow row = rows[0];

            // On crée une instance de T
            T entity = (T)Activator.CreateInstance(typeof(T));
            // On l'hydrate avec le données
            ((IModel)entity).Hydrate(row.ItemArray);
            ((IModel)entity).MakeExistant();

            return entity;
        }

        /// <summary>
        /// Retourne le nombre d'entité dans la table, selon un fitre SQL si nécessaire
        /// </summary>
        /// <param name="filter">Filtre SQL, par ex . "WHERE id = 10".</param>
        /// <returns></returns>
        public int Count(string filter = "")
        {
            object resp = db.ExecuteScalar("SELECT count(*) FROM " + tableName + " " + filter);
            return Int32.Parse(resp.ToString());
        }

        public T Find(object id)
        {
            DataSet ds = db.GetDataSet("SELECT * FROM " + tableName + " WHERE id=" + id.ToString());
            DataRowCollection rows = ds.Tables[0].Rows;

            if (rows.Count == 0)        // Si il n'y a pas de résultats...
                return default(T);      // On retourne un objet vide
            // On récupère la première ligne
            DataRow row = rows[0];

            // On crée une instance de T
            T entity = (T)Activator.CreateInstance(typeof(T));
            // On l'hydrate avec le données
            ((IModel)entity).Hydrate(row.ItemArray);
            ((IModel)entity).MakeExistant();

            return entity;
        }
    }
}
