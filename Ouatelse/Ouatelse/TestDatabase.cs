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
            this.isLoggingEnabled = true;
            this.connection = new SQLiteConnection("Data Source=:memory:");
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
            this.connection.Close();
        }

        #region Pour générer la base de données de tests avec des données
        private void InitDatabase()
        {
            SQLiteCommand cmd = this.connection.CreateCommand();
            //Setup the Pragma
            cmd.CommandText = " PRAGMA foreign_keys = false;";
            cmd.ExecuteNonQuery();

            //Init Table City
            cmd.CommandText = City.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Country
            cmd.CommandText = Country.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Customer
            cmd.CommandText = Customer.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Employee
            cmd.CommandText = Employee.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Gender
            cmd.CommandText = Gender.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Holiday
            cmd.CommandText = Holiday.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Invoice
            cmd.CommandText = Invoice.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table InvoiceProduct
            cmd.CommandText = InvoiceProduct.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Payment;
            cmd.CommandText = Payment.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Product
            cmd.CommandText = Product.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Role
            cmd.CommandText = Role.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Stock
            cmd.CommandText = Stock.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Store
            cmd.CommandText = Store.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init the Index City
            cmd.CommandText = City.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the Index Customer
            cmd.CommandText = Customer.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index Employee
            cmd.CommandText = Employee.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index Holiday
            cmd.CommandText = Holiday.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index Invoice
            cmd.CommandText = Invoice.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index InvoiceProduct
            cmd.CommandText = InvoiceProduct.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index role
            cmd.CommandText = Role.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index stock
            cmd.CommandText = Stock.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index store
            cmd.CommandText = Store.CreationIndex();
            cmd.ExecuteNonQuery();

            //Fill Fixtures
            cmd.CommandText = Country.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = City.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = Store.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = Payment.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = Gender.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = Role.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = Customer.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = Employee.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = Product.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = Invoice.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = InvoiceProduct.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = Holiday.Fixtures();
            cmd.ExecuteNonQuery();

            //Close the pragma
            cmd.CommandText = " PRAGMA foreign_keys = true;";
            cmd.ExecuteNonQuery();
        }
        #endregion

    }
}