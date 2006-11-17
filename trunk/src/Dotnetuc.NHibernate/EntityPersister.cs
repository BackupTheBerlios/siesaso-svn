using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Dotnetuc.NHibernate
{
    /// <summary>
    /// Die Komponente dient zum automatischen Persistieren von IEntity-Listen in einer
    /// BindingSource. Dabei ist die Komponente ausgelegt aus das Bearbeiten mittels
    /// der folgenden Komponenten:
    /// <list type="bullet">
    /// <item><see cref="DataGridView" /></item>
    /// </list>
    /// </summary>
    [System.Drawing.ToolboxBitmap(typeof(BindingSourceInterceptor), "Icons.EntityPersister")]
    public partial class EntityPersister : Component
    {

        #region Logger
        /// <summary>
        /// Instanz des Named-Loggers. Der Namen des Loggers entspricht dem FullName der Klasse. Dadurch
        /// wird durch den Namespace die Logger-Hierarchie aufgebaut.
        /// </summary>
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        public EntityPersister()
        {
            InitializeComponent();
            bindingListChangedEventHandler = new ListChangedEventHandler(BindingSourceListChanged);
            bindingCurrentChangedEventHandler = new EventHandler(BindingSourceCurrentChanged);
        }

        public EntityPersister(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            bindingListChangedEventHandler = new ListChangedEventHandler(BindingSourceListChanged);
            bindingCurrentChangedEventHandler = new EventHandler(BindingSourceCurrentChanged);
        }

        private ListChangedEventHandler bindingListChangedEventHandler = null;

        private EventHandler bindingCurrentChangedEventHandler = null;

        private IEntity currentItemOld = null;

        private IEntity currentItem = null;

        #region BindingSource Member

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

                // ggf. EventHandler entfernen
                if (bindingSource != null)
                {
                    bindingSource.ListChanged -= bindingListChangedEventHandler;
                    bindingSource.CurrentChanged -= bindingCurrentChangedEventHandler;
                }
                // Instanz merken
                bindingSource = value;

                // ggf. EventHandler hinzufügen
                if (bindingSource != null)
                {
                    bindingSource.ListChanged += bindingListChangedEventHandler;
                    bindingSource.CurrentChanged += bindingCurrentChangedEventHandler;
                }
            }
        }

        #endregion

        #region BindingSource Events

        private void BindingSourceListChanged(object sender, ListChangedEventArgs e)
        {
            // KO-Kriterien "sender"
            if (!(sender is BindingSource)) return;
            if (e.NewIndex == -1) return;
            BindingSource bnd = (BindingSource)sender;
            System.Collections.IList lst = (System.Collections.IList)bnd.List;

            // KO-Kriterien "sender.List"
            if (lst == null) return;
            if (lst.Count == 0) return;
            if (!(lst[0] is IEntity)) return;

            // KO-Kriterien "e"
            if (e.NewIndex >= lst.Count) return;

            // Abfragen der Art der Listenänderung
            IEntity ent = (IEntity)lst[e.NewIndex];

            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    
                    //ent.Save();
                    break;
                case ListChangedType.ItemChanged:
                    ent.Save();
                    break;
                case ListChangedType.ItemDeleted:
                    if (currentItemOld == null) break;
                    currentItemOld.Delete();
                    break;
                case ListChangedType.ItemMoved:
                    break;
                case ListChangedType.PropertyDescriptorAdded:
                    break;
                case ListChangedType.PropertyDescriptorChanged:
                    break;
                case ListChangedType.PropertyDescriptorDeleted:
                    break;
                case ListChangedType.Reset:
                    break;
                default:
                    break;
            }
        }

        private void BindingSourceCurrentChanged(object sender, EventArgs e)
        {
            // KO-Kriterien "sender"
            if (!(sender is BindingSource))
            {
                currentItem = null;
                return;
            }
            BindingSource bnd = (BindingSource)sender;

            // KO-Kriterien "sender.Current"
            if (!(bnd.Current is IEntity))
            {
                currentItem = null;
                return;
            }

            // Aktuelles Item merken
            currentItemOld = currentItem;
            currentItem = (IEntity)bnd.Current;
        }

        #endregion

    }
}
