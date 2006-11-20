using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Softwarekueche.Siesaso.Forms;
using Softwarekueche.Siesaso.Hibernate;

namespace Softwarekueche.Siesaso.Controls.ListViews
{
    /// <summary>
    /// Liste zum Verwalten von Turnieren
    /// </summary>
    [System.Drawing.ToolboxBitmap(typeof(VereinList), "Icons.Turnier")]
    public partial class TurnierList : UserControl, IEntityEditControl
    {
        public TurnierList()
        {
            InitializeComponent();
        }

        #region IEntityEditControl Members

        private Object entity;

        public Object Entity
        {
            get { return entity; }
            set
            {
                entity = value;
                TurnierBindingSource.DataSource = value;
            }
        }

        public bool CanPresent(object entity)
        {
            if (entity is List<Turnier>) return true;
            if (entity is Turnier) return true;
            return false;
        }

        public void Present(Object entity)
        {
            this.Entity = entity;
        }

        public bool IsPresenting(object testEntity)
        {
            if (testEntity is List<Turnier> && entity is List<Turnier>) return true;
            if (testEntity is Turnier && testEntity == entity) return true;

            return false;
        }

        #endregion
    }
}
