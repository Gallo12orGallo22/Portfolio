namespace DIPLOM
{
    partial class mat_prihod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mat_prihod));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПриходаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDматериалаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиематериалаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDпоставщикаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаЗаЕдиницуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материалыПриходviewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.косметический_кабинетDataSet1 = new DIPLOM.Косметический_кабинетDataSet1();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.косметический_кабинетDataSet = new DIPLOM.Косметический_кабинетDataSet();
            this.косметическийкабинетDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.материалыПриходviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.материалыПриходviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.материалы_Приход_viewTableAdapter = new DIPLOM.Косметический_кабинетDataSet1TableAdapters.Материалы_Приход_viewTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПриходаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDматериалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиематериалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDпоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыПриходviewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметическийкабинетDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыПриходviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыПриходviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.датаПриходаDataGridViewTextBoxColumn1,
            this.iDматериалаDataGridViewTextBoxColumn1,
            this.наименованиематериалаDataGridViewTextBoxColumn1,
            this.количествоDataGridViewTextBoxColumn1,
            this.iDпоставщикаDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn1,
            this.ценаЗаЕдиницуDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.материалыПриходviewBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1410, 750);
            this.dataGridView1.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // датаПриходаDataGridViewTextBoxColumn1
            // 
            this.датаПриходаDataGridViewTextBoxColumn1.DataPropertyName = "Дата прихода";
            this.датаПриходаDataGridViewTextBoxColumn1.HeaderText = "Дата прихода";
            this.датаПриходаDataGridViewTextBoxColumn1.Name = "датаПриходаDataGridViewTextBoxColumn1";
            this.датаПриходаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDматериалаDataGridViewTextBoxColumn1
            // 
            this.iDматериалаDataGridViewTextBoxColumn1.DataPropertyName = "ID_материала";
            this.iDматериалаDataGridViewTextBoxColumn1.HeaderText = "ID_материала";
            this.iDматериалаDataGridViewTextBoxColumn1.Name = "iDматериалаDataGridViewTextBoxColumn1";
            this.iDматериалаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDматериалаDataGridViewTextBoxColumn1.Visible = false;
            // 
            // наименованиематериалаDataGridViewTextBoxColumn1
            // 
            this.наименованиематериалаDataGridViewTextBoxColumn1.DataPropertyName = "Наименование_материала";
            this.наименованиематериалаDataGridViewTextBoxColumn1.HeaderText = "Наименование_материала";
            this.наименованиематериалаDataGridViewTextBoxColumn1.Name = "наименованиематериалаDataGridViewTextBoxColumn1";
            this.наименованиематериалаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn1
            // 
            this.количествоDataGridViewTextBoxColumn1.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn1.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn1.Name = "количествоDataGridViewTextBoxColumn1";
            this.количествоDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDпоставщикаDataGridViewTextBoxColumn1
            // 
            this.iDпоставщикаDataGridViewTextBoxColumn1.DataPropertyName = "ID_поставщика";
            this.iDпоставщикаDataGridViewTextBoxColumn1.HeaderText = "ID_поставщика";
            this.iDпоставщикаDataGridViewTextBoxColumn1.Name = "iDпоставщикаDataGridViewTextBoxColumn1";
            this.iDпоставщикаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDпоставщикаDataGridViewTextBoxColumn1.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn1
            // 
            this.наименованиеDataGridViewTextBoxColumn1.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.Name = "наименованиеDataGridViewTextBoxColumn1";
            this.наименованиеDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ценаЗаЕдиницуDataGridViewTextBoxColumn
            // 
            this.ценаЗаЕдиницуDataGridViewTextBoxColumn.DataPropertyName = "Цена за единицу";
            this.ценаЗаЕдиницуDataGridViewTextBoxColumn.HeaderText = "Цена за единицу";
            this.ценаЗаЕдиницуDataGridViewTextBoxColumn.Name = "ценаЗаЕдиницуDataGridViewTextBoxColumn";
            this.ценаЗаЕдиницуDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // материалыПриходviewBindingSource2
            // 
            this.материалыПриходviewBindingSource2.DataMember = "Материалы_Приход_view";
            this.материалыПриходviewBindingSource2.DataSource = this.косметический_кабинетDataSet1;
            // 
            // косметический_кабинетDataSet1
            // 
            this.косметический_кабинетDataSet1.DataSetName = "Косметический_кабинетDataSet1";
            this.косметический_кабинетDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton1.Text = "Добавить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton3.Text = "Удалить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.SystemColors.Info;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton2.Text = "Отчет Excel";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(916, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // косметический_кабинетDataSet
            // 
            this.косметический_кабинетDataSet.DataSetName = "Косметический_кабинетDataSet";
            this.косметический_кабинетDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // косметическийкабинетDataSetBindingSource
            // 
            this.косметическийкабинетDataSetBindingSource.DataSource = this.косметический_кабинетDataSet;
            this.косметическийкабинетDataSetBindingSource.Position = 0;
            // 
            // материалыПриходviewBindingSource1
            // 
            this.материалыПриходviewBindingSource1.DataMember = "Материалы_Приход_view";
            this.материалыПриходviewBindingSource1.DataSource = this.косметический_кабинетDataSet1;
            // 
            // материалыПриходviewBindingSource
            // 
            this.материалыПриходviewBindingSource.DataMember = "Материалы_Приход_view";
            this.материалыПриходviewBindingSource.DataSource = this.косметический_кабинетDataSet1;
            // 
            // материалы_Приход_viewTableAdapter
            // 
            this.материалы_Приход_viewTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаПриходаDataGridViewTextBoxColumn
            // 
            this.датаПриходаDataGridViewTextBoxColumn.DataPropertyName = "Дата прихода";
            this.датаПриходаDataGridViewTextBoxColumn.HeaderText = "Дата прихода";
            this.датаПриходаDataGridViewTextBoxColumn.Name = "датаПриходаDataGridViewTextBoxColumn";
            this.датаПриходаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDматериалаDataGridViewTextBoxColumn
            // 
            this.iDматериалаDataGridViewTextBoxColumn.DataPropertyName = "ID_материала";
            this.iDматериалаDataGridViewTextBoxColumn.HeaderText = "ID_материала";
            this.iDматериалаDataGridViewTextBoxColumn.Name = "iDматериалаDataGridViewTextBoxColumn";
            this.iDматериалаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиематериалаDataGridViewTextBoxColumn
            // 
            this.наименованиематериалаDataGridViewTextBoxColumn.DataPropertyName = "Наименование_материала";
            this.наименованиематериалаDataGridViewTextBoxColumn.HeaderText = "Наименование_материала";
            this.наименованиематериалаDataGridViewTextBoxColumn.Name = "наименованиематериалаDataGridViewTextBoxColumn";
            this.наименованиематериалаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDпоставщикаDataGridViewTextBoxColumn
            // 
            this.iDпоставщикаDataGridViewTextBoxColumn.DataPropertyName = "ID_поставщика";
            this.iDпоставщикаDataGridViewTextBoxColumn.HeaderText = "ID_поставщика";
            this.iDпоставщикаDataGridViewTextBoxColumn.Name = "iDпоставщикаDataGridViewTextBoxColumn";
            this.iDпоставщикаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование поставщика";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mat_prihod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 465);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mat_prihod";
            this.Text = "Приходы";
            this.Load += new System.EventHandler(this.mat_prihod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыПриходviewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметическийкабинетDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыПриходviewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыПриходviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource косметическийкабинетDataSetBindingSource;
        private Косметический_кабинетDataSet косметический_кабинетDataSet;
        private Косметический_кабинетDataSet1 косметический_кабинетDataSet1;
        private System.Windows.Forms.BindingSource материалыПриходviewBindingSource;
        private Косметический_кабинетDataSet1TableAdapters.Материалы_Приход_viewTableAdapter материалы_Приход_viewTableAdapter;
        private System.Windows.Forms.BindingSource материалыПриходviewBindingSource1;
        private System.Windows.Forms.BindingSource материалыПриходviewBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПриходаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDматериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиематериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDпоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПриходаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDматериалаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиематериалаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDпоставщикаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаЗаЕдиницуDataGridViewTextBoxColumn;
    }
}