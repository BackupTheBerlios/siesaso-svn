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
            g�rtelBindingSource.DataSource = G�rtel.List();

        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void g�rtelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void g�rtelBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
        }

        private void g�rtelBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {

        }

        private void g�rtelBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        private void g�rtelBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {

        }

        private void g�rtelBindingSource_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void g�rtelBindingSource_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void g�rtelBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {

        }

        private void g�rtelBindingSource_PositionChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g�rtelBindingSource.Add(new G�rtel());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g�rtelBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g�rtelBindingSource.RemoveAt(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((G�rtel)g�rtelBindingSource.Current).Nummer = 4711;
        }


   }
}