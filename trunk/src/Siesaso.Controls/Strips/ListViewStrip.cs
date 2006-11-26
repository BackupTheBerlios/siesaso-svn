using System;
using System.Collections.Generic;
using System.Text;
using Softwarekueche.Siesaso.Hibernate;

namespace Softwarekueche.Siesaso.Controls.Strips
{
    public class ListViewStrip : System.Windows.Forms.ToolStrip
    {
        public event EventHandler<ListViewStripEventArgs> ToolButtonClicked;

        #region Designer Generated Code

        private System.Windows.Forms.ToolStripButton toolJudoka;
        private System.Windows.Forms.ToolStripButton toolVereine;
        private System.Windows.Forms.ToolStripButton toolTrainer;
        private System.Windows.Forms.ToolStripButton toolTurniere;
        private System.Windows.Forms.ToolStripButton toolGürtel;
        private System.Windows.Forms.ToolStripButton toolKlassen;
        private System.Windows.Forms.ToolStripButton toolGeschlecht;
        private System.Windows.Forms.ToolStripButton toolKämpfer;

        private void InitializeComponent()
        {
            this.toolJudoka = new System.Windows.Forms.ToolStripButton();
            this.toolKämpfer = new System.Windows.Forms.ToolStripButton();
            this.toolVereine = new System.Windows.Forms.ToolStripButton();
            this.toolTrainer = new System.Windows.Forms.ToolStripButton();
            this.toolTurniere = new System.Windows.Forms.ToolStripButton();
            this.toolGürtel = new System.Windows.Forms.ToolStripButton();
            this.toolKlassen = new System.Windows.Forms.ToolStripButton();
            this.toolGeschlecht = new System.Windows.Forms.ToolStripButton();
            this.SuspendLayout();
            // 
            // toolJudoka
            // 
            this.toolJudoka.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolJudoka.Image = global::Softwarekueche.Siesaso.Controls.Properties.Resources.Judoka;
            this.toolJudoka.ImageTransparentColor = System.Drawing.Color.White;
            this.toolJudoka.Name = "toolJudoka";
            this.toolJudoka.Size = new System.Drawing.Size(23, 22);
            this.toolJudoka.Text = "Judoka";
            this.toolJudoka.ToolTipText = "Liste aller Judoka anzeigen";
            // 
            // toolKämpfer
            // 
            this.toolKämpfer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolKämpfer.Image = global::Softwarekueche.Siesaso.Controls.Properties.Resources.Kämpfer;
            this.toolKämpfer.ImageTransparentColor = System.Drawing.Color.White;
            this.toolKämpfer.Name = "toolKämpfer";
            this.toolKämpfer.Size = new System.Drawing.Size(23, 22);
            this.toolKämpfer.Text = "Kämpfer";
            this.toolKämpfer.ToolTipText = "Liste der Kämpfer anzeigen";
            // 
            // toolVereine
            // 
            this.toolVereine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolVereine.Image = global::Softwarekueche.Siesaso.Controls.Properties.Resources.Verein;
            this.toolVereine.ImageTransparentColor = System.Drawing.Color.White;
            this.toolVereine.Name = "toolVereine";
            this.toolVereine.Size = new System.Drawing.Size(23, 22);
            this.toolVereine.Text = "Vereine";
            this.toolVereine.ToolTipText = "Liste aller Vereine anzeigen";
            // 
            // toolTrainer
            // 
            this.toolTrainer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTrainer.Image = global::Softwarekueche.Siesaso.Controls.Properties.Resources.Trainer;
            this.toolTrainer.ImageTransparentColor = System.Drawing.Color.White;
            this.toolTrainer.Name = "toolTrainer";
            this.toolTrainer.Size = new System.Drawing.Size(23, 20);
            this.toolTrainer.Text = "Trainer";
            this.toolTrainer.ToolTipText = "Liste der Trainer anzeigen";
            // 
            // toolTurniere
            // 
            this.toolTurniere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTurniere.Image = global::Softwarekueche.Siesaso.Controls.Properties.Resources.Turnier;
            this.toolTurniere.ImageTransparentColor = System.Drawing.Color.White;
            this.toolTurniere.Name = "toolTurniere";
            this.toolTurniere.Size = new System.Drawing.Size(23, 23);
            this.toolTurniere.Text = "Turniere";
            this.toolTurniere.ToolTipText = "Liste der Turniere anzeigen";
            // 
            // toolGürtel
            // 
            this.toolGürtel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGürtel.Image = global::Softwarekueche.Siesaso.Controls.Properties.Resources.Gürtel;
            this.toolGürtel.ImageTransparentColor = System.Drawing.Color.White;
            this.toolGürtel.Name = "toolGürtel";
            this.toolGürtel.Size = new System.Drawing.Size(23, 23);
            this.toolGürtel.Text = "Gürtel";
            this.toolGürtel.ToolTipText = "Liste der Gürtel anzeigen";
            // 
            // toolKlassen
            // 
            this.toolKlassen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolKlassen.Image = global::Softwarekueche.Siesaso.Controls.Properties.Resources.Klasse;
            this.toolKlassen.ImageTransparentColor = System.Drawing.Color.White;
            this.toolKlassen.Name = "toolKlassen";
            this.toolKlassen.Size = new System.Drawing.Size(23, 23);
            this.toolKlassen.Text = "Klasse";
            this.toolKlassen.ToolTipText = "Liste der Klassen anzeigen";
            // 
            // toolGeschlecht
            // 
            this.toolGeschlecht.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGeschlecht.Image = global::Softwarekueche.Siesaso.Controls.Properties.Resources.Geschlecht;
            this.toolGeschlecht.ImageTransparentColor = System.Drawing.Color.White;
            this.toolGeschlecht.Name = "toolGeschlecht";
            this.toolGeschlecht.Size = new System.Drawing.Size(23, 23);
            this.toolGeschlecht.Text = "Geschlecht";
            this.toolGeschlecht.ToolTipText = "Liste aller \"Geschlechter\" anzeigen";
            // 
            // ListViewStrip
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolJudoka,
            this.toolKämpfer,
            this.toolVereine,
            this.toolTrainer,
            this.toolTurniere,
            this.toolGürtel,
            this.toolKlassen,
            this.toolGeschlecht});
            this.ResumeLayout(false);

        }

        #endregion

        #region Konstruktor

        public ListViewStrip()
            : base()
        {
            InitializeComponent();

            this.toolJudoka.Click += new EventHandler(toolItem_Click);
            this.toolVereine.Click += new EventHandler(toolItem_Click);
            this.toolTrainer.Click += new EventHandler(toolItem_Click);
            this.toolTurniere.Click += new EventHandler(toolItem_Click);
            this.toolGürtel.Click += new EventHandler(toolItem_Click);
            this.toolKlassen.Click += new EventHandler(toolItem_Click);
            this.toolGeschlecht.Click += new EventHandler(toolItem_Click);
            this.toolKämpfer.Click += new EventHandler(toolItem_Click);
        }

        void toolItem_Click(object sender, EventArgs e)
        {
            if (sender == toolJudoka)
            {
                ToolButtonClicked(this, new ListViewStripEventArgs(Judoka.List(), typeof(ListViews.JudokaList)));
            }
            else if (sender == toolKämpfer)
            {
                ToolButtonClicked(this, new ListViewStripEventArgs(Kämpfer.List(), typeof(ListViews.KämpferList)));
            }
            else if (sender == toolVereine)
            {
                ToolButtonClicked(this, new ListViewStripEventArgs(Verein.List(), typeof(ListViews.VereinList)));
            }
            else if (sender == toolTrainer)
            {
                ToolButtonClicked(this, new ListViewStripEventArgs(Trainer.List(), typeof(ListViews.TrainerList)));
            }
            else if (sender == toolTurniere)
            {
                ToolButtonClicked(this, new ListViewStripEventArgs(Turnier.List(), typeof(ListViews.TurnierList)));
            }
            else if (sender == toolGürtel)
            {
                ToolButtonClicked(this, new ListViewStripEventArgs(Gürtel.List(), typeof(ListViews.GürtelList)));
            }
            else if (sender == toolKlassen)
            {
                ToolButtonClicked(this, new ListViewStripEventArgs(Klasse.List(), typeof(ListViews.KlasseList)));
            }
            else if (sender == toolGeschlecht)
            {
                ToolButtonClicked(this, new ListViewStripEventArgs(Geschlecht.List(), typeof(ListViews.GeschlechtList)));
            }
            else
            {
                throw new NotImplementedException("ToolStripItem hat keine ListView");
            }
        }

        #endregion
    }
}
