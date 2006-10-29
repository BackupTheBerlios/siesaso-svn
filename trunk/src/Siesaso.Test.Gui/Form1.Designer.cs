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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gürtelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entityPersister1 = new Dotnetuc.NHibernate.EntityPersister(this.components);
            this.bindingSourceInterceptor1 = new Dotnetuc.NHibernate.BindingSourceInterceptor(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gürtelBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.gürtelBindingSource;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "addnew";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "change";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // gürtelBindingSource
            // 
            this.gürtelBindingSource.DataSource = typeof(Siesaso.Hibernate.Gürtel);
            this.gürtelBindingSource.CurrentChanged += new System.EventHandler(this.gürtelBindingSource_CurrentChanged);
            this.gürtelBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.gürtelBindingSource_AddingNew);
            this.gürtelBindingSource.DataMemberChanged += new System.EventHandler(this.gürtelBindingSource_DataMemberChanged);
            this.gürtelBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.gürtelBindingSource_BindingComplete);
            this.gürtelBindingSource.PositionChanged += new System.EventHandler(this.gürtelBindingSource_PositionChanged);
            this.gürtelBindingSource.DataSourceChanged += new System.EventHandler(this.gürtelBindingSource_DataSourceChanged);
            this.gürtelBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.gürtelBindingSource_DataError);
            this.gürtelBindingSource.CurrentItemChanged += new System.EventHandler(this.gürtelBindingSource_CurrentItemChanged);
            this.gürtelBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.gürtelBindingSource_ListChanged);
            // 
            // entityPersister1
            // 
            this.entityPersister1.BindingSource = this.gürtelBindingSource;
            // 
            // bindingSourceInterceptor1
            // 
            this.bindingSourceInterceptor1.BindingSource = this.gürtelBindingSource;
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
            ((System.ComponentModel.ISupportInitialize)(this.gürtelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gürtelBindingSource;
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

