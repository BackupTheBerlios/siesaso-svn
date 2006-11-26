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
    /// Liste zum Verwalten von K�mpferen
    /// </summary>
    [System.Drawing.ToolboxBitmap(typeof(K�mpferList), "Icons.K�mpfer")]
    public partial class K�mpferList : UserControl, IEntityEditControl
    {
        public K�mpferList()
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
                K�mpferBindingSource.DataSource = value;
            }
        }

        public bool CanPresent(object entity)
        {
            if (entity is List<K�mpfer>) return true;
            if (entity is K�mpfer) return true;
            return false;
        }

        public void Present(Object entity)
        {
            this.Entity = entity;
        }

        public bool IsPresenting(object testEntity)
        {
            if (testEntity is List<K�mpfer> && entity is List<K�mpfer>) return true;
            if (testEntity is K�mpfer && testEntity == entity) return true;

            return false;
        }

        #endregion
    }
}
