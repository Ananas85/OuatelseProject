using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Ouatelse
{
    public class Database : IDisposable
    {
        
        private static Database _instance = null;
        private string runningQuery = "";

        public static Database Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Database();
                return _instance;
            }
        }

        private MySqlConnection connection = null;

        private Database()
        {
            this.connection = new MySqlConnection("SERVER=" + DatabaseCredentials.Host + ";DATABASE=" + DatabaseCredentials.DatabaseName + ";UID=" + DatabaseCredentials.Username + ";PASSWORD=" + DatabaseCredentials.Password + ";PORT=" + DatabaseCredentials.Port);

            this.connection.Open();
        }

        public void Execute(string query, Dictionary<string, object> parameters = null)
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
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Utils.Error("Impossible d'éxécuter une requête \"" + runningQuery + "\" sur la base");
            }
        }

        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
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
                return cmd.ExecuteScalar();
            }
            catch
            {
                Utils.Error("Impossible d'éxécuter une requête \"" + runningQuery + "\" sur la base");
            }
            return null;
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
                Utils.Error("Impossible d'éxécuter une requête \"" + runningQuery + "\" sur la base");
            }
            return null;
        }

        public void Dispose()
        {
            this.connection.Close();
        }
    }
}
