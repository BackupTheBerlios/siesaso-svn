using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Cfg;

namespace Softwarekueche.Siesaso.Hibernate.Internal
{
    public class Session : IDisposable
    {

        #region Member Variablen

        private ISession _session = null;

        private String _database = "";

        #endregion

        #region Konstruktor


        public Session(String database)
            : base()
        {
            _database = database;

            InitSession();
        }

        /// <summary>
        /// Initialisieren der Session mit den Datenbanknamen.
        /// </summary>
        private void InitSession()
        {
            // KO-Kriterien zum Initialisieren ausschliessen
            if (!System.IO.File.Exists(_database)) throw new System.IO.FileNotFoundException("Datenbank existiert nicht");

            // Session initialisieren (Configuration, SessionFactory, Session)
            Configuration cfg = new NHibernate.Cfg.Configuration();
            cfg.Configure();
            // ConnectionString parsen und %dbname% ersetzen
            String connectionString = cfg.GetProperty("hibernate.connection.connection_string");
            connectionString = connectionString.Replace("%dbname%", _database);
            cfg.SetProperty("hibernate.connection.connection_string", connectionString);
            cfg.AddAssembly(System.Reflection.Assembly.GetExecutingAssembly());

            ISessionFactory factory = cfg.BuildSessionFactory();

            _session = factory.OpenSession();
            _session.FlushMode = FlushMode.Commit;
        }

        #endregion

        #region Session

        public ISession Get
        {
            get { return _session; }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            _session.Close();
            _session.Dispose();
        }

        #endregion

        #region Singleton

        private static Session instance = null;

        private static String instanceDatabase = "";

        /// <summary>
        /// Singleton-Pattern für den Zugriff auf genau eine Instanz der Session.
        /// </summary>
        public static Session Instance
        {
            get
            {
                if (instance == null) instance = new Session(instanceDatabase);
                return instance;
            }
        }

        public static String InstanceDatabase
        {
            get { return instanceDatabase; }
            set { instanceDatabase = value; }
        }

        #endregion

    }
}
