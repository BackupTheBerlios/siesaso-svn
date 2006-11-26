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
    /// Liste zum Verwalten von Judokaen
    /// </summary>
    [System.Drawing.ToolboxBitmap(typeof(JudokaList), "Icons.Judoka")]
    public partial class JudokaList : UserControl, IEntityEditControl
    {
        public JudokaList()
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
                gürtelBindingSource.DataSource = Gürtel.List();
                judokaBindingSource.DataSource = value;
            }
        }

        public bool CanPresent(object entity)
        {
            if (entity is List<Judoka>) return true;
            if (entity is Judoka) return true;
            return false;
        }

        public void Present(Object entity)
        {
            this.Entity = entity;
        }

        public bool IsPresenting(object testEntity)
        {
            if (testEntity is List<Judoka> && entity is List<Judoka>) return true;
            if (testEntity is Judoka && testEntity == entity) return true;

            return false;
        }

        #endregion

        private void JudokaDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.Exception.ToString());
            e.Cancel = true;
        }

    }
}
