namespace Siesaso.Test.Gui
{
    partial class MyForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dctName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g�rtelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farbeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityBindingSource1 = new Siesaso.Hibernate.EntityBindingSource();
            this.entityPersister1 = new Siesaso.Hibernate.EntityPersister(this.components);
            this.bindingSourceInterceptor1 = new Siesaso.Hibernate.BindingSourceInterceptor(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g�rtelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dctName,
            this.Nummer,
            this.idDataGridViewTextBoxColumn,
            this.farbeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.g�rtelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // dctName
            // 
            this.dctName.DataPropertyName = "Name";
            this.dctName.HeaderText = "Name";
            this.dctName.Name = "dctName";
            // 
            // Nummer
            // 
            this.Nummer.DataPropertyName = "Nummer";
            this.Nummer.HeaderText = "Nummer";
            this.Nummer.Name = "Nummer";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // farbeDataGridViewTextBoxColumn
            // 
            this.farbeDataGridViewTextBoxColumn.DataPropertyName = "Farbe";
            this.farbeDataGridViewTextBoxColumn.HeaderText = "Farbe";
            this.farbeDataGridViewTextBoxColumn.Name = "farbeDataGridViewTextBoxColumn";
            // 
            // g�rtelBindingSource
            // 
            this.g�rtelBindingSource.DataSource = typeof(Siesaso.Hibernate.G�rtel);
            this.g�rtelBindingSource.CurrentChanged += new System.EventHandler(this.g�rtelBindingSource_CurrentChanged);
            this.g�rtelBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.g�rtelBindingSource_AddingNew);
            this.g�rtelBindingSource.DataMemberChanged += new System.EventHandler(this.g�rtelBindingSource_DataMemberChanged);
            this.g�rtelBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.g�rtelBindingSource_BindingComplete);
            this.g�rtelBindingSource.PositionChanged += new System.EventHandler(this.g�rtelBindingSource_PositionChanged);
            this.g�rtelBindingSource.DataSourceChanged += new System.EventHandler(this.g�rtelBindingSource_DataSourceChanged);
            this.g�rtelBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.g�rtelBindingSource_DataError);
            this.g�rtelBindingSource.CurrentItemChanged += new System.EventHandler(this.g�rtelBindingSource_CurrentItemChanged);
            this.g�rtelBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.g�rtelBindingSource_ListChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nummerDataGridViewTextBoxColumn,
            this.farbeDataGridViewTextBoxColumn1,
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.entityBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 261);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(558, 243);
            this.dataGridView2.TabIndex = 1;
            // 
            // nummerDataGridViewTextBoxColumn
            // 
            this.nummerDataGridViewTextBoxColumn.DataPropertyName = "Nummer";
            this.nummerDataGridViewTextBoxColumn.HeaderText = "Nummer";
            this.nummerDataGridViewTextBoxColumn.Name = "nummerDataGridViewTextBoxColumn";
            // 
            // farbeDataGridViewTextBoxColumn1
            // 
            this.farbeDataGridViewTextBoxColumn1.DataPropertyName = "Farbe";
            this.farbeDataGridViewTextBoxColumn1.HeaderText = "Farbe";
            this.farbeDataGridViewTextBoxColumn1.Name = "farbeDataGridViewTextBoxColumn1";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // entityBindingSource1
            // 
            this.entityBindingSource1.DataSource = typeof(Siesaso.Hibernate.G�rtel);
            // 
            // entityPersister1
            // 
            this.entityPersister1.BindingSource = this.g�rtelBindingSource;
            // 
            // bindingSourceInterceptor1
            // 
            this.bindingSourceInterceptor1.BindingSource = this.g�rtelBindingSource;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 633);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g�rtelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource g�rtelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nummer;
        private Siesaso.Hibernate.EntityPersister entityPersister1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farbeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private Siesaso.Hibernate.EntityBindingSource entityBindingSource1;
        private Siesaso.Hibernate.BindingSourceInterceptor bindingSourceInterceptor1;
    }
}

