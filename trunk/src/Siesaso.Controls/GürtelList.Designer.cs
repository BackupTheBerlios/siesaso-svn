namespace Softwarekueche.Siesaso.Controls
{
    partial class GürtelList
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
            this.gürtelDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gürtelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gürtelEntityPersister = new Dotnetuc.NHibernate.EntityPersister(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gürtelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gürtelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gürtelDataGridView
            // 
            this.gürtelDataGridView.AllowUserToAddRows = false;
            this.gürtelDataGridView.AllowUserToDeleteRows = false;
            this.gürtelDataGridView.AutoGenerateColumns = false;
            this.gürtelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gürtelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nummerDataGridViewTextBoxColumn,
            this.farbeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.gürtelDataGridView.DataSource = this.gürtelBindingSource;
            this.gürtelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gürtelDataGridView.Location = new System.Drawing.Point(0, 0);
            this.gürtelDataGridView.Name = "gürtelDataGridView";
            this.gürtelDataGridView.ReadOnly = true;
            this.gürtelDataGridView.RowHeadersVisible = false;
            this.gürtelDataGridView.Size = new System.Drawing.Size(391, 395);
            this.gürtelDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // nummerDataGridViewTextBoxColumn
            // 
            this.nummerDataGridViewTextBoxColumn.DataPropertyName = "Nummer";
            this.nummerDataGridViewTextBoxColumn.HeaderText = "Nummer";
            this.nummerDataGridViewTextBoxColumn.Name = "nummerDataGridViewTextBoxColumn";
            this.nummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // farbeDataGridViewTextBoxColumn
            // 
            this.farbeDataGridViewTextBoxColumn.DataPropertyName = "Farbe";
            this.farbeDataGridViewTextBoxColumn.HeaderText = "Farbe";
            this.farbeDataGridViewTextBoxColumn.Name = "farbeDataGridViewTextBoxColumn";
            this.farbeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gürtelBindingSource
            // 
            this.gürtelBindingSource.DataSource = typeof(Siesaso.Hibernate.Gürtel);
            // 
            // gürtelEntityPersister
            // 
            this.gürtelEntityPersister.BindingSource = this.gürtelBindingSource;
            // 
            // GürtelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gürtelDataGridView);
            this.Name = "GürtelList";
            this.Size = new System.Drawing.Size(391, 395);
            ((System.ComponentModel.ISupportInitialize)(this.gürtelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gürtelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gürtelDataGridView;
        private System.Windows.Forms.BindingSource gürtelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private Dotnetuc.NHibernate.EntityPersister gürtelEntityPersister;
    }
}
