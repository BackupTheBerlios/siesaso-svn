namespace Softwarekueche.Siesaso.Controls
{
    partial class JudokaList
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
            this.JudokaDataGridView = new System.Windows.Forms.DataGridView();
            this.dctVorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dctNachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dctZusatz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dctGeburtsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcbGürtel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gürtelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.judokaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.judokaEntityPersister = new Dotnetuc.NHibernate.EntityPersister(this.components);
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gürtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geburtsdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zusatzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isUnsavedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.JudokaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gürtelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judokaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // JudokaDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.JudokaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.JudokaDataGridView.AutoGenerateColumns = false;
            this.JudokaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dctVorname,
            this.dctNachname,
            this.dctZusatz,
            this.dctGeburtsdatum,
            this.dcbGürtel,
            this.gürtelDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.instanceDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.geburtsdatumDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.zusatzDataGridViewTextBoxColumn,
            this.isUnsavedDataGridViewCheckBoxColumn});
            this.JudokaDataGridView.DataSource = this.judokaBindingSource;
            this.JudokaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JudokaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.JudokaDataGridView.Name = "JudokaDataGridView";
            this.JudokaDataGridView.Size = new System.Drawing.Size(631, 445);
            this.JudokaDataGridView.TabIndex = 1;
            this.JudokaDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.JudokaDataGridView_DataError);
            // 
            // dctVorname
            // 
            this.dctVorname.DataPropertyName = "Vorname";
            this.dctVorname.HeaderText = "Vorname";
            this.dctVorname.Name = "dctVorname";
            // 
            // dctNachname
            // 
            this.dctNachname.DataPropertyName = "Nachname";
            this.dctNachname.HeaderText = "Nachname";
            this.dctNachname.Name = "dctNachname";
            // 
            // dctZusatz
            // 
            this.dctZusatz.DataPropertyName = "Zusatz";
            this.dctZusatz.HeaderText = "Zusatz";
            this.dctZusatz.Name = "dctZusatz";
            // 
            // dctGeburtsdatum
            // 
            this.dctGeburtsdatum.DataPropertyName = "Geburtsdatum";
            this.dctGeburtsdatum.HeaderText = "Geburtsdatum";
            this.dctGeburtsdatum.Name = "dctGeburtsdatum";
            // 
            // dcbGürtel
            // 
            this.dcbGürtel.DataPropertyName = "Gürtel";
            this.dcbGürtel.DataSource = this.gürtelBindingSource;
            this.dcbGürtel.DisplayMember = "Name";
            this.dcbGürtel.HeaderText = "Gürtel";
            this.dcbGürtel.MaxDropDownItems = 15;
            this.dcbGürtel.Name = "dcbGürtel";
            this.dcbGürtel.ValueMember = "Instance";
            // 
            // gürtelBindingSource
            // 
            this.gürtelBindingSource.DataSource = typeof(Softwarekueche.Siesaso.Hibernate.Gürtel);
            // 
            // judokaBindingSource
            // 
            this.judokaBindingSource.DataSource = typeof(Softwarekueche.Siesaso.Hibernate.Judoka);
            // 
            // judokaEntityPersister
            // 
            this.judokaEntityPersister.BindingSource = this.judokaBindingSource;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Gürtel";
            this.dataGridViewComboBoxColumn1.HeaderText = "Gürtel";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // gürtelDataGridViewTextBoxColumn
            // 
            this.gürtelDataGridViewTextBoxColumn.DataPropertyName = "Gürtel";
            this.gürtelDataGridViewTextBoxColumn.HeaderText = "Gürtel";
            this.gürtelDataGridViewTextBoxColumn.Name = "gürtelDataGridViewTextBoxColumn";
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            // 
            // instanceDataGridViewTextBoxColumn
            // 
            this.instanceDataGridViewTextBoxColumn.DataPropertyName = "Instance";
            this.instanceDataGridViewTextBoxColumn.HeaderText = "Instance";
            this.instanceDataGridViewTextBoxColumn.Name = "instanceDataGridViewTextBoxColumn";
            this.instanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // geburtsdatumDataGridViewTextBoxColumn
            // 
            this.geburtsdatumDataGridViewTextBoxColumn.DataPropertyName = "Geburtsdatum";
            this.geburtsdatumDataGridViewTextBoxColumn.HeaderText = "Geburtsdatum";
            this.geburtsdatumDataGridViewTextBoxColumn.Name = "geburtsdatumDataGridViewTextBoxColumn";
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            // 
            // zusatzDataGridViewTextBoxColumn
            // 
            this.zusatzDataGridViewTextBoxColumn.DataPropertyName = "Zusatz";
            this.zusatzDataGridViewTextBoxColumn.HeaderText = "Zusatz";
            this.zusatzDataGridViewTextBoxColumn.Name = "zusatzDataGridViewTextBoxColumn";
            // 
            // isUnsavedDataGridViewCheckBoxColumn
            // 
            this.isUnsavedDataGridViewCheckBoxColumn.DataPropertyName = "IsUnsaved";
            this.isUnsavedDataGridViewCheckBoxColumn.HeaderText = "IsUnsaved";
            this.isUnsavedDataGridViewCheckBoxColumn.Name = "isUnsavedDataGridViewCheckBoxColumn";
            this.isUnsavedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // JudokaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.JudokaDataGridView);
            this.Name = "JudokaList";
            this.Size = new System.Drawing.Size(631, 445);
            ((System.ComponentModel.ISupportInitialize)(this.JudokaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gürtelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judokaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource judokaBindingSource;
        private System.Windows.Forms.DataGridView JudokaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Dotnetuc.NHibernate.EntityPersister judokaEntityPersister;
        private System.Windows.Forms.BindingSource gürtelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctVorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctNachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctZusatz;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctGeburtsdatum;
        private System.Windows.Forms.DataGridViewComboBoxColumn dcbGürtel;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gürtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geburtsdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zusatzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isUnsavedDataGridViewCheckBoxColumn;
    }
}
