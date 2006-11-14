using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Siesaso.Forms;
using Siesaso.Hibernate;

namespace Siesaso.Controls
{
    [System.Drawing.ToolboxBitmap(typeof(GürtelList), "Icons.Verein")]
    public partial class VereinList : UserControl, IEntityEditControl
    {
        public VereinList()
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
                vereinBindingSource.DataSource = value;
            }
        }

        public bool CanPresent(object entity)
        {
            if (entity is List<Verein>) return true;
            if (entity is Verein) return true;
            return false;
        }

        public void Present(Object entity)
        {
            this.Entity = entity;
        }

        public bool IsPresenting(object testEntity)
        {
            if (testEntity is List<Verein> && entity is List<Verein>) return true;
            if (testEntity is Verein && testEntity == entity) return true;

            return false;
        }

        #endregion
    }
}
