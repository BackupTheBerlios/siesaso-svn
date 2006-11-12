using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Siesaso.Hibernate;
using Siesaso.Forms;

namespace Siesaso.Test.Gui
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

            entityEditTabControl1.Edit(listBox1.SelectedItem, typeof(GürtelList), listBox1.SelectedItem.ToString());
         }

        private void VSNachbildung_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = Gürtel.List();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            entityEditTabControl1.Edit(Gürtel.List(), typeof(GürtelList), "Gürtel");
        }
    }
}