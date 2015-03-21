using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms.VisualStyles;
using Ouatelse.Managers;
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
            cmd.CommandText = CityManager.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Country
            cmd.CommandText = CountryManager.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Customer
            cmd.CommandText = CustomerManager.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Employee
            cmd.CommandText = EmployeeManager.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Gender
            cmd.CommandText = GenderManager.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Holiday
            cmd.CommandText = HolidayManager.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Invoice
            cmd.CommandText = InvoiceManager.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table InvoiceProduct
            cmd.CommandText = InvoiceProductManager.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Payment;
            cmd.CommandText = PaymentManager.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Product
            cmd.CommandText = ProductManager.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Role
            cmd.CommandText = RoleManager.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Stock
            cmd.CommandText = StockManager.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init Table Store
            cmd.CommandText = StoreManager.CreationQuery();
            cmd.ExecuteNonQuery();

            //Init the Index City
            cmd.CommandText = CityManager.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the Index Customer
            cmd.CommandText = CustomerManager.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index Employee
            cmd.CommandText = EmployeeManager.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index Holiday
            cmd.CommandText = HolidayManager.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index Invoice
            cmd.CommandText = InvoiceManager.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index InvoiceProduct
            cmd.CommandText = InvoiceProductManager.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index role
            cmd.CommandText = RoleManager.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index stock
            cmd.CommandText = StockManager.CreationIndex();
            cmd.ExecuteNonQuery();

            //Init the index store
            cmd.CommandText = StoreManager.CreationIndex();
            cmd.ExecuteNonQuery();

            //Fill Fixtures
            cmd.CommandText = CountryManager.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = CityManager.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = StoreManager.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = PaymentManager.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = GenderManager.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = RoleManager.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = CustomerManager.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = EmployeeManager.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = ProductManager.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = InvoiceManager.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = InvoiceProductManager.Fixtures();
            cmd.ExecuteNonQuery();

            cmd.CommandText = HolidayManager.Fixtures();
            cmd.ExecuteNonQuery();

            //Close the pragma
            cmd.CommandText = " PRAGMA foreign_keys = true;";
            cmd.ExecuteNonQuery();
        }
        #endregion

    }
}