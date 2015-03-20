using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse
{
    public class Bind
    {

        public object o1, o2;
        public string p1, p2;

        public PropertyInfo srcPropInfo;
        public PropertyInfo destPropInfo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="o1">L'objet forme du composant</param>
        /// <param name="p1">Le nom de la propriété du forme</param>
        /// <param name="o2">L'objet en cohérence avec le formulaire</param>
        /// <param name="p2">La propriété de l'objet lié</param>
        public Bind(object o1, string p1, object o2, string p2)
        {
            this.o1 = o1;
            this.o2 = o2;
            this.p1 = p1;
            this.p2 = p2;

            Type t1 = o1.GetType();
            Type t2 = o2.GetType();

            srcPropInfo = t1.GetProperty(p1);
            destPropInfo = t2.GetProperty(p2);
        }
    }
}
