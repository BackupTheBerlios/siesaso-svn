namespace Softwarekueche.Siesaso.Controls.ListViews
{
    partial class VereinList
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
            this.vereinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vereinDataGridView = new System.Windows.Forms.DataGridView();
            this.vereinEntityPersister = new Dotnetuc.NHibernate.EntityPersister(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.langnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vereinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vereinDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vereinBindingSource
            // 
            this.vereinBindingSource.DataSource = typeof(Softwarekueche.Siesaso.Hibernate.Verein);
            // 
            // vereinDataGridView
            // 
            this.vereinDataGridView.AllowUserToAddRows = false;
            this.vereinDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vereinDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.vereinDataGridView.AutoGenerateColumns = false;
            this.vereinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.langnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn});
            this.vereinDataGridView.DataSource = this.vereinBindingSource;
            this.vereinDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vereinDataGridView.Location = new System.Drawing.Point(0, 0);
            this.vereinDataGridView.Name = "vereinDataGridView";
            this.vereinDataGridView.ReadOnly = true;
            this.vereinDataGridView.Size = new System.Drawing.Size(469, 445);
            this.vereinDataGridView.TabIndex = 1;
            // 
            // vereinEntityPersister
            // 
            this.vereinEntityPersister.BindingSource = this.vereinBindingSource;
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
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VereinList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vereinDataGridView);
            this.Name = "VereinList";
            this.Size = new System.Drawing.Size(469, 445);
            ((System.ComponentModel.ISupportInitialize)(this.vereinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vereinDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vereinBindingSource;
        private System.Windows.Forms.DataGridView vereinDataGridView;
        private Dotnetuc.NHibernate.EntityPersister vereinEntityPersister;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn langnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
    }
}
