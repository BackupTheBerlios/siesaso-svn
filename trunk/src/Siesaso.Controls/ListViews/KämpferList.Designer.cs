namespace Softwarekueche.Siesaso.Controls.ListViews
{
    partial class KämpferList
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
            this.KämpferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KämpferDataGridView = new System.Windows.Forms.DataGridView();
            this.KämpferEntityPersister = new Dotnetuc.NHibernate.EntityPersister(this.components);
            this.klasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gewichtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasseRealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judokaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punkteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punkteRealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.KämpferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KämpferDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // KämpferBindingSource
            // 
            this.KämpferBindingSource.DataSource = typeof(Softwarekueche.Siesaso.Hibernate.Kämpfer);
            // 
            // KämpferDataGridView
            // 
            this.KämpferDataGridView.AllowUserToAddRows = false;
            this.KämpferDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.KämpferDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.KämpferDataGridView.AutoGenerateColumns = false;
            this.KämpferDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klasseDataGridViewTextBoxColumn,
            this.gewichtDataGridViewTextBoxColumn,
            this.klasseRealDataGridViewTextBoxColumn,
            this.judokaDataGridViewTextBoxColumn,
            this.punkteDataGridViewTextBoxColumn,
            this.punkteRealDataGridViewTextBoxColumn,
            this.turnierDataGridViewTextBoxColumn});
            this.KämpferDataGridView.DataSource = this.KämpferBindingSource;
            this.KämpferDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KämpferDataGridView.Location = new System.Drawing.Point(0, 0);
            this.KämpferDataGridView.Name = "KämpferDataGridView";
            this.KämpferDataGridView.ReadOnly = true;
            this.KämpferDataGridView.Size = new System.Drawing.Size(469, 445);
            this.KämpferDataGridView.TabIndex = 1;
            // 
            // KämpferEntityPersister
            // 
            this.KämpferEntityPersister.BindingSource = this.KämpferBindingSource;
            // 
            // klasseDataGridViewTextBoxColumn
            // 
            this.klasseDataGridViewTextBoxColumn.DataPropertyName = "Klasse";
            this.klasseDataGridViewTextBoxColumn.HeaderText = "Klasse";
            this.klasseDataGridViewTextBoxColumn.Name = "klasseDataGridViewTextBoxColumn";
            this.klasseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gewichtDataGridViewTextBoxColumn
            // 
            this.gewichtDataGridViewTextBoxColumn.DataPropertyName = "Gewicht";
            this.gewichtDataGridViewTextBoxColumn.HeaderText = "Gewicht";
            this.gewichtDataGridViewTextBoxColumn.Name = "gewichtDataGridViewTextBoxColumn";
            this.gewichtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klasseRealDataGridViewTextBoxColumn
            // 
            this.klasseRealDataGridViewTextBoxColumn.DataPropertyName = "KlasseReal";
            this.klasseRealDataGridViewTextBoxColumn.HeaderText = "KlasseReal";
            this.klasseRealDataGridViewTextBoxColumn.Name = "klasseRealDataGridViewTextBoxColumn";
            this.klasseRealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // judokaDataGridViewTextBoxColumn
            // 
            this.judokaDataGridViewTextBoxColumn.DataPropertyName = "Judoka";
            this.judokaDataGridViewTextBoxColumn.HeaderText = "Judoka";
            this.judokaDataGridViewTextBoxColumn.Name = "judokaDataGridViewTextBoxColumn";
            this.judokaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // punkteDataGridViewTextBoxColumn
            // 
            this.punkteDataGridViewTextBoxColumn.DataPropertyName = "Punkte";
            this.punkteDataGridViewTextBoxColumn.HeaderText = "Punkte";
            this.punkteDataGridViewTextBoxColumn.Name = "punkteDataGridViewTextBoxColumn";
            this.punkteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // punkteRealDataGridViewTextBoxColumn
            // 
            this.punkteRealDataGridViewTextBoxColumn.DataPropertyName = "PunkteReal";
            this.punkteRealDataGridViewTextBoxColumn.HeaderText = "PunkteReal";
            this.punkteRealDataGridViewTextBoxColumn.Name = "punkteRealDataGridViewTextBoxColumn";
            this.punkteRealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turnierDataGridViewTextBoxColumn
            // 
            this.turnierDataGridViewTextBoxColumn.DataPropertyName = "Turnier";
            this.turnierDataGridViewTextBoxColumn.HeaderText = "Turnier";
            this.turnierDataGridViewTextBoxColumn.Name = "turnierDataGridViewTextBoxColumn";
            this.turnierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // KämpferList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KämpferDataGridView);
            this.Name = "KämpferList";
            this.Size = new System.Drawing.Size(469, 445);
            ((System.ComponentModel.ISupportInitialize)(this.KämpferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KämpferDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource KämpferBindingSource;
        private System.Windows.Forms.DataGridView KämpferDataGridView;
        private Dotnetuc.NHibernate.EntityPersister KämpferEntityPersister;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn langnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gewichtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasseRealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judokaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punkteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punkteRealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnierDataGridViewTextBoxColumn;
    }
}
