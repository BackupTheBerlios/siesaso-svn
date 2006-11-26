using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Dotnetuc.Forms;
using Softwarekueche.Siesaso.Hibernate;

namespace Softwarekueche.Siesaso.Controls.ListViews
{
    /// <summary>
    /// Liste zum Verwalten von Geschlechtn
    /// </summary>
    [System.Drawing.ToolboxBitmap(typeof(GeschlechtList), "Icons.Geschlecht")]
    public partial class GeschlechtList : UserControl, IEntityEditControl
    {

        private Object entity;

        public Object Entity
        {
            get { return entity; }
            set
            {
                entity = value;
                GeschlechtBindingSource.DataSource = entity;
            }
        }

        public GeschlechtList()
        {
            InitializeComponent();
        }

        #region IEntityEditControl Members


        public bool CanPresent(object entity)
        {
            if (entity is List<Geschlecht>) return true;
            if (entity is Geschlecht) return true;
            return false;
        }

        public void Present(Object entity)
        {
            this.Entity = entity;
        }

        public bool IsPresenting(object testEntity)
        {
            if (testEntity is List<Geschlecht> && entity is List<Geschlecht>) return true;
            if (testEntity is Geschlecht && testEntity == entity) return true;

            return false;
        }

        #endregion
    }
}
