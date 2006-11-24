namespace Softwarekueche.Siesaso.Controls.ListViews
{
    partial class TrainerList
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
            this.TrainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TrainerDataGridView = new System.Windows.Forms.DataGridView();
            this.TrainerEntityPersister = new Dotnetuc.NHibernate.EntityPersister(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.langnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TrainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TrainerBindingSource
            // 
            this.TrainerBindingSource.DataSource = typeof(Softwarekueche.Siesaso.Hibernate.Trainer);
            // 
            // TrainerDataGridView
            // 
            this.TrainerDataGridView.AllowUserToAddRows = false;
            this.TrainerDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TrainerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TrainerDataGridView.AutoGenerateColumns = false;
            this.TrainerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.langnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn});
            this.TrainerDataGridView.DataSource = this.TrainerBindingSource;
            this.TrainerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TrainerDataGridView.Name = "TrainerDataGridView";
            this.TrainerDataGridView.ReadOnly = true;
            this.TrainerDataGridView.Size = new System.Drawing.Size(469, 445);
            this.TrainerDataGridView.TabIndex = 1;
            // 
            // TrainerEntityPersister
            // 
            this.TrainerEntityPersister.BindingSource = this.TrainerBindingSource;
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
            // TrainerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TrainerDataGridView);
            this.Name = "TrainerList";
            this.Size = new System.Drawing.Size(469, 445);
            ((System.ComponentModel.ISupportInitialize)(this.TrainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource TrainerBindingSource;
        private System.Windows.Forms.DataGridView TrainerDataGridView;
        private Dotnetuc.NHibernate.EntityPersister TrainerEntityPersister;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn langnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
    }
}
