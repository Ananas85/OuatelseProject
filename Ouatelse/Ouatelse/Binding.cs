using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse
{
    /// <summary>
    /// Classe permettant d'associer un contrôle Windows Forms avec une propriété d'une entité
    /// </summary>
    public class Binding
    {
        private List<Bind> Binds = new List<Bind>();

        /// <summary>
        /// Lie un contrôle à une propriété 
        /// </summary>
        /// <param name="o1">Contrôle Windows Forms</param>
        /// <param name="p1">Nom de la propriété liée du contrôle</param>
        /// <param name="o2">L'Entité</param>
        /// <param name="p2">Nom de la propriété liée de l'entité</param>
        public void Bind(object o1, string p1, object o2, string p2)
        {
            Binds.Add(new Bind(o1, p1, o2, p2));
        }

        /// <summary>
        /// Définit les valeurs des contrôles selon l'entité
        /// </summary>
        public void Populate()
        {
            foreach (Bind b in Binds)
            {
                object val = b.destPropInfo.GetValue(b.o2, null);
                if (b.p1 == "Text")
                {
                    string strVal = (val == null) ? "" : val.ToString();
                    b.srcPropInfo.SetValue(b.o1, strVal, null);
                }
                else
                    b.srcPropInfo.SetValue(b.o1, val, null);
            }
        }

        /// <summary>
        /// Définit les attributs de l'entité selon les contrôles
        /// </summary>
        public void Hydrate()
        {
            foreach (Bind b in Binds)
            {
                object val = b.srcPropInfo.GetValue(b.o1, null);
                b.destPropInfo.SetValue(b.o2, val, null);
            }
        }
    }
}
