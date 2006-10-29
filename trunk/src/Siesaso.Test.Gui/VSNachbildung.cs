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

            CreateTabPage(listBox1.SelectedItem);
         }

        private void CreateTabPage(object p)
        {
            if (p is Gürtel)
            {
                EntityEditTabPage tp = new EntityEditTabPage(p.ToString());
                tp.Controls.Add(new WebBrowser());

                entityEditTabControl1.TabPages.Add(tp);
            }
        }

        private void VSNachbildung_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = Gürtel.List();

        }
    }
}