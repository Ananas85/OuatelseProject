using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms.VisualStyles;
using Ouatelse.Models;

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
            this.connection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            this.connection.Open();
            InitDatabase();
        }
        public bool Execute(string query, Dictionary<string, object> parameters = null)
        {
            if (parameters == null)
                parameters = new Dictionary<string, object>();

            SQLiteCommand cmd = this.connection.CreateCommand();
            runningQuery = query;
            cmd.CommandText = runningQuery;
            foreach (string paramName in parameters.Keys)
                cmd.Parameters.AddWithValue("@" + paramName, parameters[paramName]);
            cmd.ExecuteNonQuery();
            if (isLoggingEnabled) queryLog.Add(query);
            return true;
        }

        public DataSet GetDataSet(string query, Dictionary<string, object> parameters = null)
        {
            if (parameters == null)
                parameters = new Dictionary<string, object>();

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

        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            if (parameters == null)
                parameters = new Dictionary<string, object>();

            SQLiteCommand cmd = this.connection.CreateCommand();
            runningQuery = query;
            cmd.CommandText = runningQuery;
            foreach (string paramName in parameters.Keys)
                cmd.Parameters.AddWithValue("@" + paramName, parameters[paramName]);
            if (isLoggingEnabled) queryLog.Add(query);
            return cmd.ExecuteScalar();
        }

        public void Dispose()
        {
            System.IO.File.Delete("MyDatabase.sqlite");
            this.connection.Close();
        }

        private void InitDatabase()
        {
            SQLiteCommand cmd = this.connection.CreateCommand();
            //Setup the Pragma
            runningQuery = " PRAGMA foreign_keys = false;";
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init Table City
            runningQuery = City.CreationQuery();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init Table Country
            runningQuery = Country.CreationQuery();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init Table Customer
            runningQuery = Customer.CreationQuery();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init Table Employee
            runningQuery = Employee.CreationQuery();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init Table Gender
            runningQuery = Gender.CreationQuery();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init Table Holiday
            runningQuery = Holiday.CreationQuery();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init Table Invoice
            runningQuery = Invoice.CreationQuery();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init Table InvoiceProduct
            runningQuery = InvoiceProduct.CreationQuery();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init Table Payment;
            runningQuery = Payment.CreationQuery();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init Table Product
            runningQuery = Product.CreationQuery();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init Table Role
            runningQuery = Role.CreationQuery();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init Table Stock
            runningQuery = Stock.CreationQuery();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init Table Store
            runningQuery = Store.CreationQuery();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init the Index City
            runningQuery = City.CreationIndex();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init the Index Customer
            runningQuery = Customer.CreationIndex();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init the index Employee
            runningQuery = Employee.CreationIndex();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init the index Holiday
            runningQuery = Holiday.CreationIndex();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init the index Invoice
            runningQuery = Invoice.CreationIndex();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init the index InvoiceProduct
            runningQuery = InvoiceProduct.CreationIndex();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init the index role
            runningQuery = Role.CreationIndex();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init the index stock
            runningQuery = Stock.CreationIndex();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Init the index store
            runningQuery = Store.CreationIndex();
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();

            //Close the pragama
            runningQuery = " PRAGMA foreign_keys = true;";
            cmd.CommandText = runningQuery;
            cmd.ExecuteNonQuery();
        }

    }
}