using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Siesaso.Hibernate;

namespace Siesaso.Test.Gui
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gürtelBindingSource.DataSource = Gürtel.List();

        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void gürtelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gürtelBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (e.NewObject == null) return;
            MessageBox.Show(e.NewObject.ToString());
        }

   }
}