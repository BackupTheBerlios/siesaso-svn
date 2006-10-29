using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Dotnetuc.NHibernate
{
    /// <summary>
    /// Klasse zum Abfangen und Auswerten von Events einer BindungSource
    /// </summary>
    public partial class BindingSourceInterceptor : Component
    {
        #region Logger

        /// <summary>
        /// Instanz des Named-Loggers. Der Namen des Loggers entspricht dem FullName der Klasse. Dadurch
        /// wird durch den Namespace die Logger-Hierarchie aufgebaut.
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        #region Erzeugen und Verwalten der EventHandler

        private AddingNewEventHandler bindingAddingNewEventHandler = null;
        private BindingCompleteEventHandler bindingBindingCompleteEventHandler = null;
        private EventHandler bindingCurrentChangedEventHandler = null;
        private EventHandler bindingCurrentItemChangedEventHandler = null;
        private BindingManagerDataErrorEventHandler bindingDataErrorEventHandler = null;
        private EventHandler bindingDataMemberChangedEventHandler = null;
        private EventHandler bindingDataSourceChangedEventHandler = null;
        private ListChangedEventHandler bindingListChangedEventHandler = null;
        private EventHandler bindingPositionChangedEventHandler = null;

        private void CreateEventHandler()
        {
            bindingAddingNewEventHandler = new AddingNewEventHandler(this.BindingSource_AddingNew);
            bindingBindingCompleteEventHandler = new BindingCompleteEventHandler(this.BindingSource_BindingComplete);
            bindingCurrentChangedEventHandler = new EventHandler(this.BindingSource_CurrentChanged);
            bindingCurrentItemChangedEventHandler = new EventHandler(this.BindingSource_CurrentItemChanged);
            bindingDataErrorEventHandler = new BindingManagerDataErrorEventHandler(this.BindingSource_DataError);
            bindingDataMemberChangedEventHandler = new EventHandler(this.BindingSource_DataMemberChanged);
            bindingDataSourceChangedEventHandler = new EventHandler(this.BindingSource_DataSourceChanged);
            bindingListChangedEventHandler = new ListChangedEventHandler(this.BindingSource_ListChanged);
            bindingPositionChangedEventHandler = new EventHandler(this.BindingSource_PositionChanged);
        }

        private void AddHandler()
        {
            if (bindingSource == null) return;

            this.bindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bindingAddingNewEventHandler);
            this.bindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.bindingBindingCompleteEventHandler);
            this.bindingSource.CurrentChanged += new System.EventHandler(this.bindingCurrentChangedEventHandler);
            this.bindingSource.CurrentItemChanged += new System.EventHandler(this.bindingCurrentItemChangedEventHandler);
            this.bindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.bindingDataErrorEventHandler);
            this.bindingSource.DataMemberChanged += new System.EventHandler(this.bindingDataMemberChangedEventHandler);
            this.bindingSource.DataSourceChanged += new System.EventHandler(this.bindingDataSourceChangedEventHandler);
            this.bindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingListChangedEventHandler);
            this.bindingSource.PositionChanged += new System.EventHandler(this.bindingPositionChangedEventHandler);
        }

        private void RemoveHandler()
        {
            if (bindingSource == null) return;

            this.bindingSource.AddingNew -= new System.ComponentModel.AddingNewEventHandler(this.bindingAddingNewEventHandler);
            this.bindingSource.BindingComplete -= new System.Windows.Forms.BindingCompleteEventHandler(this.bindingBindingCompleteEventHandler);
            this.bindingSource.CurrentChanged -= new System.EventHandler(this.bindingCurrentChangedEventHandler);
            this.bindingSource.CurrentItemChanged -= new System.EventHandler(this.bindingCurrentItemChangedEventHandler);
            this.bindingSource.DataError -= new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.bindingDataErrorEventHandler);
            this.bindingSource.DataMemberChanged -= new System.EventHandler(this.bindingDataMemberChangedEventHandler);
            this.bindingSource.DataSourceChanged -= new System.EventHandler(this.bindingDataSourceChangedEventHandler);
            this.bindingSource.ListChanged -= new System.ComponentModel.ListChangedEventHandler(this.bindingListChangedEventHandler);
            this.bindingSource.PositionChanged -= new System.EventHandler(this.bindingPositionChangedEventHandler);
        }

        #endregion

        #region Konstruktor

        public BindingSourceInterceptor()
        {
            InitializeComponent();
            CreateEventHandler();
        }

        public BindingSourceInterceptor(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            CreateEventHandler();
        }

        #endregion

        #region Property BindungSource

        private System.Windows.Forms.BindingSource bindingSource;

        public System.Windows.Forms.BindingSource BindingSource
        {
            get
            {
                return bindingSource;
            }
            set
            {
                if (bindingSource == value) return;

                // EventHandler entfernen
                RemoveHandler();

                // Instanz merken
                bindingSource = value;

                // ggf. EventHandler hinzufügen
                AddHandler();
            }
        }

        #endregion

        #region EventHandler der BindingSource

        private void BindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (log.IsDebugEnabled) log.Debug("BindingSource.AddingNew raised [" + ((BindingSource)sender).ToString() + "]");
        }

        private void BindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (log.IsDebugEnabled) log.Debug("BindingSource.BindingComplete raised [" + ((BindingSource)sender).ToString() + "]");
        }

        private void BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (log.IsDebugEnabled) log.Debug("BindingSource.CurrentChanged raised [" + ((BindingSource)sender).ToString() + "]");
        }

        private void BindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (log.IsDebugEnabled) log.Debug("BindingSource.CurrentItemChanged raised [" + ((BindingSource)sender).ToString() + "]");
        }

        private void BindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            if (log.IsDebugEnabled) log.Debug("BindingSource.DataError raised [" + ((BindingSource)sender).ToString() + "]");
        }

        private void BindingSource_DataMemberChanged(object sender, EventArgs e)
        {
            if (log.IsDebugEnabled) log.Debug("BindingSource.DataMemberChanged raised [" + ((BindingSource)sender).ToString() + "]");
        }

        private void BindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            if (log.IsDebugEnabled) log.Debug("BindingSource.DataSourceChanged raised [" + ((BindingSource)sender).ToString() + "]");
        }

        private void BindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (log.IsDebugEnabled) log.Debug("BindingSource.ListChanged raised [" + ((BindingSource)sender).ToString() + "]");
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (log.IsDebugEnabled) log.Debug("BindingSource.PositionChanged raised [" + ((BindingSource)sender).ToString() + "]");
        }

        #endregion
    }
}