﻿namespace Softwarekueche.Siesaso.Controls
{
    partial class GeschlechtList
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
            this.GeschlechtDataGridView = new System.Windows.Forms.DataGridView();
            this.Kurz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeschlechtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kurzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.langDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isUnsavedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GeschlechtDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeschlechtBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GeschlechtDataGridView
            // 
            this.GeschlechtDataGridView.AllowUserToAddRows = false;
            this.GeschlechtDataGridView.AllowUserToDeleteRows = false;
            this.GeschlechtDataGridView.AutoGenerateColumns = false;
            this.GeschlechtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeschlechtDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kurz,
            this.Lang,
            this.kurzDataGridViewTextBoxColumn,
            this.langDataGridViewTextBoxColumn,
            this.isUnsavedDataGridViewCheckBoxColumn});
            this.GeschlechtDataGridView.DataSource = this.GeschlechtBindingSource;
            this.GeschlechtDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeschlechtDataGridView.Location = new System.Drawing.Point(0, 0);
            this.GeschlechtDataGridView.Name = "GeschlechtDataGridView";
            this.GeschlechtDataGridView.ReadOnly = true;
            this.GeschlechtDataGridView.RowHeadersVisible = false;
            this.GeschlechtDataGridView.Size = new System.Drawing.Size(391, 395);
            this.GeschlechtDataGridView.TabIndex = 0;
            // 
            // Kurz
            // 
            this.Kurz.DataPropertyName = "Kurz";
            this.Kurz.HeaderText = "Kurz";
            this.Kurz.Name = "Kurz";
            this.Kurz.ReadOnly = true;
            // 
            // Lang
            // 
            this.Lang.DataPropertyName = "Lang";
            this.Lang.HeaderText = "Lang";
            this.Lang.Name = "Lang";
            this.Lang.ReadOnly = true;
            // 
            // GeschlechtBindingSource
            // 
            this.GeschlechtBindingSource.DataSource = typeof(Softwarekueche.Siesaso.Hibernate.Geschlecht);
            // 
            // kurzDataGridViewTextBoxColumn
            // 
            this.kurzDataGridViewTextBoxColumn.DataPropertyName = "Kurz";
            this.kurzDataGridViewTextBoxColumn.HeaderText = "Kurz";
            this.kurzDataGridViewTextBoxColumn.Name = "kurzDataGridViewTextBoxColumn";
            this.kurzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // langDataGridViewTextBoxColumn
            // 
            this.langDataGridViewTextBoxColumn.DataPropertyName = "Lang";
            this.langDataGridViewTextBoxColumn.HeaderText = "Lang";
            this.langDataGridViewTextBoxColumn.Name = "langDataGridViewTextBoxColumn";
            this.langDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isUnsavedDataGridViewCheckBoxColumn
            // 
            this.isUnsavedDataGridViewCheckBoxColumn.DataPropertyName = "IsUnsaved";
            this.isUnsavedDataGridViewCheckBoxColumn.HeaderText = "IsUnsaved";
            this.isUnsavedDataGridViewCheckBoxColumn.Name = "isUnsavedDataGridViewCheckBoxColumn";
            this.isUnsavedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // GeschlechtList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GeschlechtDataGridView);
            this.Name = "GeschlechtList";
            this.Size = new System.Drawing.Size(391, 395);
            ((System.ComponentModel.ISupportInitialize)(this.GeschlechtDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeschlechtBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GeschlechtDataGridView;
        private System.Windows.Forms.BindingSource GeschlechtBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lang;
        private System.Windows.Forms.DataGridViewTextBoxColumn kurzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn langDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isUnsavedDataGridViewCheckBoxColumn;
    }
}
