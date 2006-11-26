using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Dotnetuc.NHibernate;
using Dotnetuc.CsvMapper;

using Softwarekueche.Siesaso.Hibernate;
using Softwarekueche.Siesaso.Controls.ListViews;

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

            if (listBox1.SelectedItem is Gürtel)
            {
                entityEditTabControl1.Edit(listBox1.SelectedItem, typeof(GürtelList), listBox1.SelectedItem.ToString());
            }
            else if (listBox1.SelectedItem is Judoka)
            {
                entityEditTabControl1.Edit(listBox1.SelectedItem, typeof(JudokaList), listBox1.SelectedItem.ToString());
            }
        }

        private void VSNachbildung_Load(object sender, EventArgs e)
        {
            System.Collections.Generic.List<Object> arrayList = new System.Collections.Generic.List<Object>();
            foreach (object itm in Gürtel.List())
            {
                arrayList.Add(itm);
            }
            foreach (object itm in Judoka.List())
            {
                arrayList.Add(itm);
            }
            bindingSource1.DataSource = arrayList;
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (entityEditTabControl1.SelectedTab == null) return;
            entityEditTabControl1.TabPages.Remove(entityEditTabControl1.SelectedTab);
        }

        private void alleSchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entityEditTabControl1.TabPages.Clear();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cSVImportierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Datei öffnen
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;

            IList<Judoka> jlst = Judoka.List();

            CsvMapper<Judoka> jcsv = new CsvMapper<Judoka>(ofd.FileName);
            jcsv.IgnoreErrors = true;
            List<Judoka> jclst = jcsv.List();

            foreach (Judoka perJ in jlst)
            {
                String perJHash = perJ.GetNameHash(Judoka.HashType.None);

                foreach (Judoka csvJ in jclst)
                {
                    if (perJHash == csvJ.GetNameHash(Judoka.HashType.None))
                    {
                        Console.WriteLine("Persistiert: " + perJ.ToString() + " [" + perJ.Id + "]");
                        csvJ.Id = perJ.Id;
                    }
                }
            }

            foreach (Judoka csvJ in jclst)
            {
                if (csvJ.Id == 0)
                {
                    Console.WriteLine("Nicht Persistent: " + csvJ.ToString());

                    if (csvJ.Geschlecht == null || csvJ.Verein == null || csvJ.Gürtel == null)
                    {
                        MessageBox.Show("Judoka hat Geschlecht, Verein oder Gürtel NULL");
                        continue;
                    }
                    else
                    {
                        csvJ.Save();
                    }
                }
            }
        }

        private void listViewStrip1_ToolButtonClicked(object sender, Softwarekueche.Siesaso.Controls.Strips.ListViewStripEventArgs e)
        {
            entityEditTabControl1.Edit(e.Entity, e.EntityEditControl, "");
        }

    }
}