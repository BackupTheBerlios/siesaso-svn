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
            this.entityPersister1 = new Dotnetuc.NHibernate.EntityPersister(this.components);
            this.bindingSourceInterceptor1 = new Dotnetuc.NHibernate.BindingSourceInterceptor(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g�rtelBindingSource)).BeginInit();
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
            // entityPersister1
            // 
            this.entityPersister1.BindingSource = this.g�rtelBindingSource;
            // 
            // bindingSourceInterceptor1
            // 
            this.bindingSourceInterceptor1.BindingSource = this.g�rtelBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "addnew";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "change";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(283, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 633);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g�rtelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource g�rtelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nummer;
        private Dotnetuc.NHibernate.EntityPersister entityPersister1;
        private Dotnetuc.NHibernate.BindingSourceInterceptor bindingSourceInterceptor1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

