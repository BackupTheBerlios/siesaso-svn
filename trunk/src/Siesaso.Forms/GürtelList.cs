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
            set { entity = value; }
        }
	
        public GürtelList()
        {
            InitializeComponent();
        }

        #region IEntityEditControl Members


        public bool CanPresent(object entity)
        {
            if (entity is Gürtel) return true;
            return false;
        }

        public void Present(object entity)
        {
            if (!(entity is Gürtel)) throw new InvalidCastException("Element kann nicht dargestellt werden");
            this.Entity = (Gürtel)entity;
        }

        #endregion
    }
}
