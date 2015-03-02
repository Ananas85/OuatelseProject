using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Ouatelse.Models
{
    /// <summary>
    /// Classe de base pour les modèles
    /// </summary>
    public abstract class BaseModel
    {
        /// <summary>
        /// l'ID de notre modèle
        /// </summary>
        public int Id { get; set; }

        public string StringId
        {
            get { return Id.ToString(); }
            set { Id = Int32.Parse(value); }
        }

        protected bool exists = false;

        /// <summary>
        /// Permet de savoir si l'entité existe dans la table.
        /// </summary>
        public bool Exists
        {
            get
            {
                return this.exists;
            }
        }
        
        /// <summary>
        /// Permet de définir cette entité comme existante
        /// </summary>
        public void MakeExistant()
        {
            this.exists = true;
        }

    }
}
