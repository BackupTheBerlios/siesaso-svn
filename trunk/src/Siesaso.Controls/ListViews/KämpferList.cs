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
    /// Liste zum Verwalten von Kämpferen
    /// </summary>
    [System.Drawing.ToolboxBitmap(typeof(KämpferList), "Icons.Kämpfer")]
    public partial class KämpferList : UserControl, IEntityEditControl
    {
        public KämpferList()
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
                KämpferBindingSource.DataSource = value;
            }
        }

        public bool CanPresent(object entity)
        {
            if (entity is List<Kämpfer>) return true;
            if (entity is Kämpfer) return true;
            return false;
        }

        public void Present(Object entity)
        {
            this.Entity = entity;
        }

        public bool IsPresenting(object testEntity)
        {
            if (testEntity is List<Kämpfer> && entity is List<Kämpfer>) return true;
            if (testEntity is Kämpfer && testEntity == entity) return true;

            return false;
        }

        #endregion
    }
}
