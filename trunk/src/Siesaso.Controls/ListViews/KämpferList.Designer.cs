namespace Softwarekueche.Siesaso.Controls.ListViews
{
    partial class K�mpferList
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
            this.K�mpferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.K�mpferDataGridView = new System.Windows.Forms.DataGridView();
            this.K�mpferEntityPersister = new Dotnetuc.NHibernate.EntityPersister(this.components);
            this.klasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gewichtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasseRealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judokaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punkteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punkteRealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.K�mpferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K�mpferDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // K�mpferBindingSource
            // 
            this.K�mpferBindingSource.DataSource = typeof(Softwarekueche.Siesaso.Hibernate.K�mpfer);
            // 
            // K�mpferDataGridView
            // 
            this.K�mpferDataGridView.AllowUserToAddRows = false;
            this.K�mpferDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.K�mpferDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.K�mpferDataGridView.AutoGenerateColumns = false;
            this.K�mpferDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klasseDataGridViewTextBoxColumn,
            this.gewichtDataGridViewTextBoxColumn,
            this.klasseRealDataGridViewTextBoxColumn,
            this.judokaDataGridViewTextBoxColumn,
            this.punkteDataGridViewTextBoxColumn,
            this.punkteRealDataGridViewTextBoxColumn,
            this.turnierDataGridViewTextBoxColumn});
            this.K�mpferDataGridView.DataSource = this.K�mpferBindingSource;
            this.K�mpferDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.K�mpferDataGridView.Location = new System.Drawing.Point(0, 0);
            this.K�mpferDataGridView.Name = "K�mpferDataGridView";
            this.K�mpferDataGridView.ReadOnly = true;
            this.K�mpferDataGridView.Size = new System.Drawing.Size(469, 445);
            this.K�mpferDataGridView.TabIndex = 1;
            // 
            // K�mpferEntityPersister
            // 
            this.K�mpferEntityPersister.BindingSource = this.K�mpferBindingSource;
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
            // K�mpferList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.K�mpferDataGridView);
            this.Name = "K�mpferList";
            this.Size = new System.Drawing.Size(469, 445);
            ((System.ComponentModel.ISupportInitialize)(this.K�mpferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.K�mpferDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource K�mpferBindingSource;
        private System.Windows.Forms.DataGridView K�mpferDataGridView;
        private Dotnetuc.NHibernate.EntityPersister K�mpferEntityPersister;
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
