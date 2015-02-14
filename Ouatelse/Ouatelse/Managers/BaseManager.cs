using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Classe abstraite permettant gérer quelques requêtes de bases en implémentant l'interface du manager
    /// </summary>
    /// <typeparam name="T">Le type de l'entité</typeparam>
    public abstract class BaseManager<T> : IManager<T>
    {
        #region Les attributs de la classe
        /// <summary>
        /// l'instance du pattern singleton
        /// </summary>
        Database db = Database.Instance;

        /// <summary>
        /// Le nom de la table dans la base de données
        /// </summary>
        protected string tableName = "";
        #endregion

        #region Récupération de toutes les entités présentes dans la table
        /// <summary>
        /// Récupère toutes les entitées présentes dans la table
        /// </summary>
        /// <returns>Un talbeau d'objets</returns>
        public T[] All()
        {
            // On récupère le DataSet
            DataSet ds =  db.GetDataSet("SELECT * FROM " + tableName);
            if (ds == null)
            {
                return default(T[]);
            }
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
        #endregion

        #region Récupération des entités de la table selon un filtre SQL
        /// <summary>
        /// Permet de récupérer certaines entités selon un filtre SQL.
        /// </summary>
        /// <param name="filter">Filtre SQL, par ex . "WHERE id = 10".</param>
        /// <returns>Un Tableau d'objets</returns>
        public T[] Filter(string filter)
        {
            DataSet ds = db.GetDataSet("SELECT * FROM " + tableName + " " + filter);
            if (ds == null)
            {
                return default(T[]);
            }
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
        #endregion

        #region Récupération de la première entité de la table selon un filtre SQL
        /// <summary>
        /// Permet de récupérer la première entité selon un filtre SQL.
        /// </summary>
        /// <param name="filter">Filtre SQL, par ex . "WHERE id = 10".</param>
        /// <returns>Le premier objet trouvé dans la table</returns>
        public T First(string filter)
        {
            DataSet ds = db.GetDataSet("SELECT * FROM " + tableName + " " + filter);
            if (ds == null)
            {
                return default(T);
            }
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
        #endregion

        #region Récupération du nombre d'entité de la table selon un filtre SQL
        /// <summary>
        /// Retourne le nombre d'entité dans la table, selon un fitre SQL si nécessaire
        /// </summary>
        /// <param name="filter">Filtre SQL, par ex . "WHERE id = 10".</param>
        /// <returns>Le nomre d'entité</returns>
        public int Count(string filter = "")
        {
            object resp = db.ExecuteScalar("SELECT count(*) FROM " + tableName + " " + filter);
            if ( (bool)resp == false || resp == null )
                return 0;
            return Int32.Parse(resp.ToString());
        }
        #endregion

        #region Récuprération d'une entité de la table selon son ID
        /// <summary>
        /// Retourne une entité selon un id
        /// </summary>
        /// <param name="id">l'ID de l'entité à récupérer</param>
        /// <returns>L'entité désirée</returns>
        public T Find(object id)
        {
            DataSet ds = db.GetDataSet("SELECT * FROM " + tableName + " WHERE id=" + id.ToString());
            if (ds == null)
            {
                return default(T);
            }
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
        #endregion

        #region Persiste une entité dans la base de données
        /// <summary>
        /// Persiste une entité dans la base
        /// </summary>
        /// <param name="model">Entité à persister</param>
        public bool Save(BaseModel model)
        {
            StringBuilder query = new StringBuilder();
            if (!model.Exists)
            {
                query.AppendFormat("INSERT INTO {0} (", tableName);
                query.Append(String.Join(", ", ((IModel)model).Fetch().Keys));
                query.Append(") VALUES('");
                query.Append(String.Join("', '", ((IModel)model).Fetch().Values));
                query.Append("')");
            }
            else
            {
                query.AppendFormat("UPDATE {0} SET", tableName);
                Dictionary<string, string> dict = ((IModel)model).Fetch();
                bool first = true;
                foreach (string key in dict.Keys)
                {
                    if (!first)
                        query.Append(",");
                    query.AppendFormat(" {0} = '{1}'", key, dict[key]);
                    first = false;
                }

                query.AppendFormat(" WHERE id={0}", model.Id);
            }
            return Database.Instance.Execute(query.ToString());

        }
        #endregion

        #region Suppression d'une entité dans la base de données
        /// <summary>
        /// Supprime une entité de la base
        /// </summary>
        /// <param name="model">Entité à supprimer</param>
        public bool Delete(BaseModel model)
        {
            if (!model.Exists)
            {
                Utils.Error("Impossible de supprimer cette entité, elle n'est pas persisté dans la base");
                return false;
            }
            string query = String.Format("DELETE FROM {0} WHERE id={1}", tableName, model.Id);
            return Database.Instance.Execute(query.ToString());
        }
        #endregion
    }
}
