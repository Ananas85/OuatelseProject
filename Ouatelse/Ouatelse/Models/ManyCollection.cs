using System;
using System.Collections.Generic;
using System.Linq;
using Ouatelse.Managers;

namespace Ouatelse.Models
{
    /// <summary>
    /// Représente une relation de type OneToMany
    /// 
    /// L'"entité source" est le modèle depuis lequel la relation est établie.
    /// </summary>
    /// <typeparam name="TModel">Modèle que l'on souhaite associer</typeparam>
    public class ManyCollection<TModel>
    {
        private readonly List<TModel> items = new List<TModel>();
        private readonly BaseModel sourceModel;
        private readonly string column;
        private readonly string property;
        private readonly IManager<TModel> manager;

        /// <summary>
        /// Représente une relation de type ManyToMany
        /// </summary>
        /// <param name="sourceModel">Entité source</param>
        /// <param name="manager">Manager du modèle associé TModel</param>
        /// <param name="column">Colonne de la BDD dans la table de l'entité source contenant l'id du modèle associé</param>
        /// <param name="property">Propriété de TModele référençant l'entité source</param>
        public ManyCollection(BaseModel sourceModel, IManager<TModel> manager, string column, string property)
        {
            this.sourceModel = sourceModel;
            this.column = column;
            this.property = property;
            this.manager = manager;
            Reload();
        }

        /// <summary>
        /// Recharge la liste d'objets depuis la base de données
        /// </summary>
        public void Reload()
        {
            items.Clear();
            items.AddRange(manager.Filter(String.Format(" WHERE {0} = '{1}'", column, sourceModel.Id)));
        }

        /// <summary>
        /// Ajoute entity dans la table associée
        /// </summary>
        /// <param name="entity">Entité à ajouter</param>
        public void Add(TModel entity)
        {
            Type t = typeof(TModel);                                // On récupère le type du modèle pour la Reflection
            t.GetProperty(property).SetValue(entity, sourceModel);  // On définit la propriété qui accède à notre entité source
            manager.Save(entity as BaseModel);                      // On persiste l'entité
            items.Add(entity);                                      // On l'ajoute localement dans la liste pour éviter un Reload depuis la BDD
        }

        /// <summary>
        /// Retourne les objets issus de la relation.
        /// </summary>
        public TModel[] Items
        {
            get { return items.ToArray(); }
        }

        public bool Delete(TModel entity)
        {
            BaseModel model = entity as BaseModel;
            if (model == null || !model.Exists)
                return false;

            return ((BaseManager<TModel>)manager).Delete(model);
        }

        public bool DeleteAll()
        {
            return Items.All(Delete);
        }
    }
}
