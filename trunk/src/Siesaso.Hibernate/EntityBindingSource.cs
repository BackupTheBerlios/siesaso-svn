using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Siesaso.Hibernate
{
    public class EntityBindingSource : BindingSource
    {

        public EventHandler<ItemAddedEventArgs> ItemAdded = null;

        public EntityBindingSource()
        {
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // EntityBindingSource
            // 
            this.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.EntityBindingSource_AddingNew);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void EntityBindingSource_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {

        }
    }
}
