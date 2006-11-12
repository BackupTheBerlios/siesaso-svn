namespace Siesaso.Forms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gürtelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isUnsavedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gürtelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nummerDataGridViewTextBoxColumn,
            this.farbeDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.isUnsavedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.gürtelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // gürtelBindingSource
            // 
            this.gürtelBindingSource.DataSource = typeof(Siesaso.Hibernate.Gürtel);
            // 
            // nummerDataGridViewTextBoxColumn
            // 
            this.nummerDataGridViewTextBoxColumn.DataPropertyName = "Nummer";
            this.nummerDataGridViewTextBoxColumn.HeaderText = "Nummer";
            this.nummerDataGridViewTextBoxColumn.Name = "nummerDataGridViewTextBoxColumn";
            // 
            // farbeDataGridViewTextBoxColumn
            // 
            this.farbeDataGridViewTextBoxColumn.DataPropertyName = "Farbe";
            this.farbeDataGridViewTextBoxColumn.HeaderText = "Farbe";
            this.farbeDataGridViewTextBoxColumn.Name = "farbeDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // isUnsavedDataGridViewCheckBoxColumn
            // 
            this.isUnsavedDataGridViewCheckBoxColumn.DataPropertyName = "IsUnsaved";
            this.isUnsavedDataGridViewCheckBoxColumn.HeaderText = "IsUnsaved";
            this.isUnsavedDataGridViewCheckBoxColumn.Name = "isUnsavedDataGridViewCheckBoxColumn";
            this.isUnsavedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // GürtelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "GürtelList";
            this.Size = new System.Drawing.Size(391, 395);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gürtelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isUnsavedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource gürtelBindingSource;
    }
}
