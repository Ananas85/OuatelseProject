using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Ouatelse
{
    public class TestDatabase : AbstactDatabase, IDatabase 
    {
        /// <summary>
        /// instance static propriétaire de la classe pour le pattern Singleton
        /// </summary>
        private static TestDatabase _instance = null;

        /// <summary>
        /// Permet de gérer la connection SQLite
        /// </summary>
        private SQLiteConnection connection = null;

        /// <summary>
        /// Methode indispensable pour le pattern singleton Database.Instance.function
        /// </summary>
        public static TestDatabase Instance
        {
            get { return _instance ?? (_instance = new TestDatabase()); }
        }

        /// <summary>
        /// Constructeur privé qui permet de se créer la base
        /// </summary>
        private TestDatabase()
        {
            SQLiteConnection.CreateFile("MyDatabase.sqlite");
            this.isLoggingEnabled = true;
            if (!Utils.CheckServer()) return;
            this.connection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            this.connection.Open();
        }
        public bool Execute(string query, Dictionary<string, object> parameters = null)
        {
            if (!Utils.CheckServer())
            {
                return false;
            }
            if (parameters == null)
                parameters = new Dictionary<string, object>();
            try
            {
                SQLiteCommand cmd = this.connection.CreateCommand();
                runningQuery = query;
                cmd.CommandText = runningQuery;
                foreach (string paramName in parameters.Keys)
                    cmd.Parameters.AddWithValue("@" + paramName, parameters[paramName]);
                cmd.ExecuteNonQuery();
                if (isLoggingEnabled) queryLog.Add(query);
                return true;
            }
            catch
            {
                if (Utils.CheckServer())
                    Utils.Error("Impossible d'exécuter une requête \"" + runningQuery + "\" sur la base");
                return false;
            }
        }

        public DataSet GetDataSet(string query, Dictionary<string, object> parameters = null)
        {
            if (parameters == null)
                parameters = new Dictionary<string, object>();
            try
            {
                SQLiteCommand cmd = this.connection.CreateCommand();
                runningQuery = query;
                cmd.CommandText = runningQuery;
                foreach (string paramName in parameters.Keys)
                    cmd.Parameters.AddWithValue("@" + paramName, parameters[paramName]);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                if (isLoggingEnabled) queryLog.Add(query);
                return ds;
            }
            catch
            {
                if (Utils.CheckServer())
                    Utils.Error("Impossible d'exécuter une requête \"" + runningQuery + "\" sur la base");
                return null;
            }
        }

        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            if (!Utils.CheckServer())
            {
                return false;
            }

            if (parameters == null)
                parameters = new Dictionary<string, object>();

            try
            {
                SQLiteCommand cmd = this.connection.CreateCommand();
                runningQuery = query;
                cmd.CommandText = runningQuery;
                foreach (string paramName in parameters.Keys)
                    cmd.Parameters.AddWithValue("@" + paramName, parameters[paramName]);
                if (isLoggingEnabled) queryLog.Add(query);
                return cmd.ExecuteScalar();
            }
            catch
            {
                if (Utils.CheckServer())
                    Utils.Error("Impossible d'exécuter une requête \"" + runningQuery + "\" sur la base");
                return false;
            }
        }

        public void Dispose()
        {
            System.IO.File.Delete("MyDatabase.sqlite");
            this.connection.Close();
        }

    }
}