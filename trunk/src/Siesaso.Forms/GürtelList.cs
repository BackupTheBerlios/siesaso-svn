using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Siesaso.Forms;
using Siesaso.Hibernate;

namespace Siesaso.Forms
{
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
            return false;
        }

        public void Present(Object entity)
        {
            if (!(entity is List<Gürtel>)) throw new InvalidCastException("Element kann nicht dargestellt werden");
            this.Entity = entity;
        }

        #endregion
    }
}
