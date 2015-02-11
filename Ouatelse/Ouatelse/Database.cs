using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net.NetworkInformation;

namespace Ouatelse
{
    /// <summary>
    /// Classe Singleton permettant de gérer la base de données
    /// IDisposable permet de dire qu'il y a une méthode qui libère les ressources
    /// </summary>
    public class Database : IDisposable
    {
        /// <summary>
        /// instance static propriétaire de la classe pour le pattern Singleton
        /// </summary>
        private static Database _instance = null;

        /// <summary>
        /// La query que l'on veut utiliser
        /// </summary>
        private string runningQuery = "";

        /// <summary>
        /// Permet de gérer la connection MySQL
        /// </summary>
        private MySqlConnection connection = null;

        /// <summary>
        /// Methode indispensable pour le pattern singleton Database.Instance.function
        /// </summary>
        public static Database Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Database();
                return _instance;
            }
        }

        /// <summary>
        /// Constructeur privé qui permet de se connecter à la base de données grâce aux credentials.
        /// </summary>
        private Database()
        {
            this.connection = new MySqlConnection("SERVER=" + DatabaseCredentials.Host + ";DATABASE=" + DatabaseCredentials.DatabaseName + ";UID=" + DatabaseCredentials.Username + ";PASSWORD=" + DatabaseCredentials.Password + ";PORT=" + DatabaseCredentials.Port);

            this.connection.Open();
        }

        public bool Execute(string query, Dictionary<string, object> parameters = null)
        {
            if (!Utils.CheckServer())
            {
                Utils.Error("Impossible d'effectuer l'opération demandée. Aucune connexion Internet ou serveur hors service");
                return false;
            }
            if (parameters == null)
                parameters = new Dictionary<string, object>();
            try
            {
                MySqlCommand cmd = this.connection.CreateCommand();
                runningQuery = query;
                cmd.CommandText = runningQuery;
                foreach (string paramName in parameters.Keys)
                    cmd.Parameters.AddWithValue("@" + paramName, parameters[paramName]);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                if (!Utils.CheckServer())
                    Utils.Error("Impossible d'effectuer l'opération demandée. Aucune connexion Internet  ou serveur hors service");
                else
                    Utils.Error("Impossible d'éxécuter une requête \"" + runningQuery + "\" sur la base");
                return false;
            }
        }

        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            if (!Utils.CheckServer())
            {
                Utils.Error("Impossible d'effectuer l'opération demandée. Aucune connexion Internet  ou serveur hors service");
                return false;
            }
            if (parameters == null)
                parameters = new Dictionary<string, object>();
            try
            {
                MySqlCommand cmd = this.connection.CreateCommand();
                runningQuery = query;
                cmd.CommandText = runningQuery;
                foreach (string paramName in parameters.Keys)
                    cmd.Parameters.AddWithValue("@" + paramName, parameters[paramName]);
                return cmd.ExecuteScalar();
            }
            catch
            {
                if (!Utils.CheckServer())
                    Utils.Error("Impossible d'effectuer l'opération demandée. Aucune connexion Internet  ou serveur hors service");
                else
                    Utils.Error("Impossible d'éxécuter une requête \"" + runningQuery + "\" sur la base");
                return false;
            }
        }

        public DataSet GetDataSet(string query, Dictionary<string, object> parameters = null)
        {
            if (parameters == null)
                parameters = new Dictionary<string, object>();
            try
            {
                MySqlCommand cmd = this.connection.CreateCommand();
                runningQuery = query;
                cmd.CommandText = runningQuery;
                foreach (string paramName in parameters.Keys)
                    cmd.Parameters.AddWithValue("@" + paramName, parameters[paramName]);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
            catch
            {
                if (!Utils.CheckServer())
                    Utils.Error("Impossible d'effectuer l'opération demandée. Aucune connexion Internet  ou serveur hors service");
                else
                    Utils.Error("Impossible d'éxécuter une requête \"" + runningQuery + "\" sur la base");
                return null;
            }
        }

        /// <summary>
        /// Libère les ressources ( ici ferme la connexion ) 
        /// </summary>
        public void Dispose()
        {
            this.connection.Close();
        }
    }
}
