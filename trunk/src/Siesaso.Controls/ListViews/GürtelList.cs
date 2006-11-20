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
    /// Liste zum Verwalten von Gürteln
    /// </summary>
    [System.Drawing.ToolboxBitmap(typeof(GürtelList), "Icons.Gürtel")]
    public partial class GürtelList : UserControl, IEntityEditControl
    {

        private Object entity;

        public Object Entity
        {
            get { return entity; }
            set
            {
                entity = value;
                gürtelBindingSource.DataSource = entity;
            }
        }

        public GürtelList()
        {
            InitializeComponent();
        }

        #region IEntityEditControl Members


        public bool CanPresent(object entity)
        {
            if (entity is List<Gürtel>) return true;
            if (entity is Gürtel) return true;
            return false;
        }

        public void Present(Object entity)
        {
            this.Entity = entity;
        }

        public bool IsPresenting(object testEntity)
        {
            if (testEntity is List<Gürtel> && entity is List<Gürtel>) return true;
            if (testEntity is Gürtel && testEntity == entity) return true;

            return false;
        }

        #endregion
    }
}
