using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public interface IModel
    {
        /// <summary>
        /// Permet de remplir les champs de l'entité depuis un tableau de données récupérées de la base.
        /// </summary>
        /// <param name="data">Tableau d'objets représentant les champs de l'entité</param>
        void Hydrate(object[] data);

        /// <summary>
        /// Permet de dire que l'entité est présente en base
        /// </summary>
        void MakeExistant();

        /// <summary>
        /// Permet d'établir les relations entre les champs de la base et les propriétés de l'entité
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> Fetch();
        
    }
}
