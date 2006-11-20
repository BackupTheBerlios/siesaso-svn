namespace Softwarekueche.Siesaso.Controls.ListViews
{
    partial class KlasseList
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
            this.KlasseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KlasseDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.langnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geschlecht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxAlter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dctName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxGewicht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Langname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlasseEntityPersister = new Dotnetuc.NHibernate.EntityPersister(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KlasseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KlasseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // KlasseBindingSource
            // 
            this.KlasseBindingSource.DataSource = typeof(Softwarekueche.Siesaso.Hibernate.Klasse);
            // 
            // KlasseDataGridView
            // 
            this.KlasseDataGridView.AllowUserToAddRows = false;
            this.KlasseDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.KlasseDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.KlasseDataGridView.AutoGenerateColumns = false;
            this.KlasseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.langnameDataGridViewTextBoxColumn,
            this.Geschlecht,
            this.MaxAlter,
            this.dctName,
            this.MaxGewicht,
            this.Langname});
            this.KlasseDataGridView.DataSource = this.KlasseBindingSource;
            this.KlasseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KlasseDataGridView.Location = new System.Drawing.Point(0, 0);
            this.KlasseDataGridView.Name = "KlasseDataGridView";
            this.KlasseDataGridView.ReadOnly = true;
            this.KlasseDataGridView.Size = new System.Drawing.Size(469, 445);
            this.KlasseDataGridView.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // langnameDataGridViewTextBoxColumn
            // 
            this.langnameDataGridViewTextBoxColumn.DataPropertyName = "Langname";
            this.langnameDataGridViewTextBoxColumn.HeaderText = "Langname";
            this.langnameDataGridViewTextBoxColumn.Name = "langnameDataGridViewTextBoxColumn";
            this.langnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Geschlecht
            // 
            this.Geschlecht.DataPropertyName = "Geschlecht";
            this.Geschlecht.HeaderText = "Geschlecht";
            this.Geschlecht.Name = "Geschlecht";
            this.Geschlecht.ReadOnly = true;
            // 
            // MaxAlter
            // 
            this.MaxAlter.DataPropertyName = "MaxAlter";
            this.MaxAlter.HeaderText = "MaxAlter";
            this.MaxAlter.Name = "MaxAlter";
            this.MaxAlter.ReadOnly = true;
            // 
            // dctName
            // 
            this.dctName.DataPropertyName = "Name";
            this.dctName.HeaderText = "Name";
            this.dctName.Name = "dctName";
            this.dctName.ReadOnly = true;
            // 
            // MaxGewicht
            // 
            this.MaxGewicht.DataPropertyName = "MaxGewicht";
            this.MaxGewicht.HeaderText = "MaxGewicht";
            this.MaxGewicht.Name = "MaxGewicht";
            this.MaxGewicht.ReadOnly = true;
            // 
            // Langname
            // 
            this.Langname.DataPropertyName = "Langname";
            this.Langname.HeaderText = "Langname";
            this.Langname.Name = "Langname";
            this.Langname.ReadOnly = true;
            // 
            // KlasseEntityPersister
            // 
            this.KlasseEntityPersister.BindingSource = this.KlasseBindingSource;
            // 
            // KlasseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KlasseDataGridView);
            this.Name = "KlasseList";
            this.Size = new System.Drawing.Size(469, 445);
            ((System.ComponentModel.ISupportInitialize)(this.KlasseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KlasseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource KlasseBindingSource;
        private System.Windows.Forms.DataGridView KlasseDataGridView;
        private Dotnetuc.NHibernate.EntityPersister KlasseEntityPersister;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn langnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geschlecht;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxAlter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxGewicht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Langname;
    }
}
