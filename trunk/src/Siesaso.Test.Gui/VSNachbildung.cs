using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Softwarekueche.Siesaso.Hibernate;
using Softwarekueche.Siesaso.Controls;

namespace Softwarekueche.Siesaso.Test.Gui
{
    public partial class VSNachbildung : Form
    {
        public VSNachbildung()
        {
            InitializeComponent();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            //if (!(listBox1.SelectedItem is IEditable)) return;

            entityEditTabControl1.Edit(listBox1.SelectedItem, typeof(G�rtelList), listBox1.SelectedItem.ToString());
         }

        private void VSNachbildung_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = G�rtel.List();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            entityEditTabControl1.Edit(G�rtel.List(), typeof(G�rtelList), "G�rtel");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            entityEditTabControl1.Edit(Verein.List(), typeof(VereinList), "Vereine");
        }
    }
}