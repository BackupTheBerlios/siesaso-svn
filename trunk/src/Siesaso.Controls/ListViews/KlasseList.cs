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
    /// Liste zum Verwalten von Klasseen
    /// </summary>
    [System.Drawing.ToolboxBitmap(typeof(KlasseList), "Icons.Klasse")]
    public partial class KlasseList : UserControl, IEntityEditControl
    {
        public KlasseList()
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
                KlasseBindingSource.DataSource = value;
            }
        }

        public bool CanPresent(object entity)
        {
            if (entity is List<Klasse>) return true;
            if (entity is Klasse) return true;
            return false;
        }

        public void Present(Object entity)
        {
            this.Entity = entity;
        }

        public bool IsPresenting(object testEntity)
        {
            if (testEntity is List<Klasse> && entity is List<Klasse>) return true;
            if (testEntity is Klasse && testEntity == entity) return true;

            return false;
        }

        #endregion
    }
}
