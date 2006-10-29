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
        }

        private void gürtelBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {

        }

        private void gürtelBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        private void gürtelBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {

        }

        private void gürtelBindingSource_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void gürtelBindingSource_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void gürtelBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {

        }

        private void gürtelBindingSource_PositionChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gürtelBindingSource.Add(new Gürtel());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gürtelBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gürtelBindingSource.RemoveAt(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((Gürtel)gürtelBindingSource.Current).Nummer = 4711;
        }


   }
}