namespace Softwarekueche.Siesaso.Controls.ListViews
{
    partial class TurnierList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TurnierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TurnierDataGridView = new System.Windows.Forms.DataGridView();
            this.TurnierEntityPersister = new Dotnetuc.NHibernate.EntityPersister(this.components);
            this.dctName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dctBeschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dctDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dctAusrichter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dctLeitung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TurnierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnierDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TurnierBindingSource
            // 
            this.TurnierBindingSource.DataSource = typeof(Softwarekueche.Siesaso.Hibernate.Turnier);
            // 
            // TurnierDataGridView
            // 
            this.TurnierDataGridView.AllowUserToAddRows = false;
            this.TurnierDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TurnierDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TurnierDataGridView.AutoGenerateColumns = false;
            this.TurnierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dctName,
            this.dctBeschreibung,
            this.dctDatum,
            this.dctAusrichter,
            this.dctLeitung});
            this.TurnierDataGridView.DataSource = this.TurnierBindingSource;
            this.TurnierDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TurnierDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TurnierDataGridView.Name = "TurnierDataGridView";
            this.TurnierDataGridView.ReadOnly = true;
            this.TurnierDataGridView.Size = new System.Drawing.Size(469, 445);
            this.TurnierDataGridView.TabIndex = 1;
            // 
            // TurnierEntityPersister
            // 
            this.TurnierEntityPersister.BindingSource = this.TurnierBindingSource;
            // 
            // dctName
            // 
            this.dctName.DataPropertyName = "Name";
            this.dctName.HeaderText = "Name";
            this.dctName.Name = "dctName";
            this.dctName.ReadOnly = true;
            // 
            // dctBeschreibung
            // 
            this.dctBeschreibung.DataPropertyName = "Beschreibung";
            this.dctBeschreibung.HeaderText = "Beschreibung";
            this.dctBeschreibung.Name = "dctBeschreibung";
            this.dctBeschreibung.ReadOnly = true;
            // 
            // dctDatum
            // 
            this.dctDatum.DataPropertyName = "Datum";
            this.dctDatum.HeaderText = "Datum";
            this.dctDatum.Name = "dctDatum";
            this.dctDatum.ReadOnly = true;
            // 
            // dctAusrichter
            // 
            this.dctAusrichter.DataPropertyName = "Ausrichter";
            this.dctAusrichter.HeaderText = "Ausrichter";
            this.dctAusrichter.Name = "dctAusrichter";
            this.dctAusrichter.ReadOnly = true;
            // 
            // dctLeitung
            // 
            this.dctLeitung.DataPropertyName = "Leitung";
            this.dctLeitung.HeaderText = "Leitung";
            this.dctLeitung.Name = "dctLeitung";
            this.dctLeitung.ReadOnly = true;
            // 
            // TurnierList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TurnierDataGridView);
            this.Name = "TurnierList";
            this.Size = new System.Drawing.Size(469, 445);
            ((System.ComponentModel.ISupportInitialize)(this.TurnierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnierDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource TurnierBindingSource;
        private System.Windows.Forms.DataGridView TurnierDataGridView;
        private Dotnetuc.NHibernate.EntityPersister TurnierEntityPersister;
        private System.Windows.Forms.DataGridViewTextBoxColumn langnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctBeschreibung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctAusrichter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctLeitung;
    }
}
