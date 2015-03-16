using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Ouatelse
{
    public abstract class AbstactDatabase 
    {
        /// <summary>
        /// La query que l'on veut utiliser
        /// </summary>
        protected string runningQuery = "";

       
        protected long? lastInsertId = null;

        public bool isLoggingEnabled { get; protected set; }

        protected List<string> queryLog = new List<string>();

        public long? LastInsertId
        {
            get { return lastInsertId; }
        }

        public string[] LoggedQueries
        {
            get { return queryLog.ToArray(); }
        }

    }
}