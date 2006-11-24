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
    /// Liste zum Verwalten von Traineren
    /// </summary>
    [System.Drawing.ToolboxBitmap(typeof(TrainerList), "Icons.Trainer")]
    public partial class TrainerList : UserControl, IEntityEditControl
    {
        public TrainerList()
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
                TrainerBindingSource.DataSource = value;
            }
        }

        public bool CanPresent(object entity)
        {
            if (entity is List<Trainer>) return true;
            if (entity is Trainer) return true;
            return false;
        }

        public void Present(Object entity)
        {
            this.Entity = entity;
        }

        public bool IsPresenting(object testEntity)
        {
            if (testEntity is List<Trainer> && entity is List<Trainer>) return true;
            if (testEntity is Trainer && testEntity == entity) return true;

            return false;
        }

        #endregion
    }
}
