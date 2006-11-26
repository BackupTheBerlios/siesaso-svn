using System;
using System.Collections.Generic;
using System.Text;
using Dotnetuc.Forms;

namespace Softwarekueche.Siesaso.Controls.Strips
{
    /// <summary>
    /// Event-Args f�r das ListViewStrip. Damit werden die n�tigen Parameter 
    /// �bergeben.
    /// </summary>
    public class ListViewStripEventArgs : EventArgs
    {
        #region Eigenschaften

        private Object entity;
        private Type entityEditControl;

        public Type EntityEditControl
        {
            get { return entityEditControl; }
            set
            {
                // TODO Testen auf IEntityEditControl
                entityEditControl = value;
            }
        }

        public Object Entity
        {
            get { return entity; }
            set { entity = value; }
        }

        #endregion

        #region Konstruktoren

        public ListViewStripEventArgs()
            : base()
        {
        }

        public ListViewStripEventArgs(Object entity, Type entityEditControl)
            : this()
        {
            this.entity = entity;
            this.entityEditControl = entityEditControl;
        }

        #endregion
    }
}
