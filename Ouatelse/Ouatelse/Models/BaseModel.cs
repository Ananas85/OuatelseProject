using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Ouatelse.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        protected bool exists = false;

        /// <summary>
        /// Permet de savoir si l'entité existe dans la table.
        /// </summary>
        public bool Exists
        {
            get
            {
                return Exists;
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
