namespace DIPLOM
{
    partial class Sklad
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиематериалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материалыНаСкладеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.косметический_кабинетDataSet = new DIPLOM.Косметический_кабинетDataSet();
            this.материалы_На_СкладеTableAdapter = new DIPLOM.Косметический_кабинетDataSetTableAdapters.Материалы_На_СкладеTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыНаСкладеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(787, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.SystemColors.Info;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel1.Text = "Отчет Excel";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.наименованиематериалаDataGridViewTextBoxColumn,
            this.количествоНаСкладеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.материалыНаСкладеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1412, 733);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиематериалаDataGridViewTextBoxColumn
            // 
            this.наименованиематериалаDataGridViewTextBoxColumn.DataPropertyName = "Наименование_материала";
            this.наименованиематериалаDataGridViewTextBoxColumn.HeaderText = "Наименование_материала";
            this.наименованиематериалаDataGridViewTextBoxColumn.Name = "наименованиематериалаDataGridViewTextBoxColumn";
            this.наименованиематериалаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоНаСкладеDataGridViewTextBoxColumn
            // 
            this.количествоНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.HeaderText = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.Name = "количествоНаСкладеDataGridViewTextBoxColumn";
            this.количествоНаСкладеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // материалыНаСкладеBindingSource
            // 
            this.материалыНаСкладеBindingSource.DataMember = "Материалы_На_Складе";
            this.материалыНаСкладеBindingSource.DataSource = this.косметический_кабинетDataSet;
            // 
            // косметический_кабинетDataSet
            // 
            this.косметический_кабинетDataSet.DataSetName = "Косметический_кабинетDataSet";
            this.косметический_кабинетDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // материалы_На_СкладеTableAdapter
            // 
            this.материалы_На_СкладеTableAdapter.ClearBeforeFill = true;
            // 
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 429);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sklad";
            this.Text = "Хранилище";
            this.Load += new System.EventHandler(this.Sklad_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыНаСкладеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Косметический_кабинетDataSet косметический_кабинетDataSet;
        private System.Windows.Forms.BindingSource материалыНаСкладеBindingSource;
        private Косметический_кабинетDataSetTableAdapters.Материалы_На_СкладеTableAdapter материалы_На_СкладеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьЗаЕдиницуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиематериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоНаСкладеDataGridViewTextBoxColumn;
    }
}