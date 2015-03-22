using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse
{
    public interface IDatabase : IDisposable
    {
        bool Execute(string query, Dictionary<string, object> parameters = null);
        DataSet GetDataSet(string query, Dictionary<string, object> parameters = null);
        object ExecuteScalar(string query, Dictionary<string, object> parameters = null);
        
        /// <summary>
        /// Libère les ressources ( ici ferme la connexion ) 
        /// </summary>
        new void Dispose();
    }
}
