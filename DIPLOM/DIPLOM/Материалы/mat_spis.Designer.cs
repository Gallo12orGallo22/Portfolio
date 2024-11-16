namespace DIPLOM
{
    partial class mat_spis
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
            this.материалыviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.косметический_кабинетDataSet = new DIPLOM.Косметический_кабинетDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.материалы_На_СкладеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материалы_На_СкладеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.материалы_viewTableAdapter = new DIPLOM.Косметический_кабинетDataSetTableAdapters.Материалы_viewTableAdapter();
            this.материалы_На_СкладеTableAdapter = new DIPLOM.Косметический_кабинетDataSetTableAdapters.Материалы_На_СкладеTableAdapter();
            this.tableAdapterManager = new DIPLOM.Косметический_кабинетDataSetTableAdapters.TableAdapterManager();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.материалыviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалы_На_СкладеDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалы_На_СкладеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // материалыviewBindingSource
            // 
            this.материалыviewBindingSource.DataMember = "Материалы_view";
            this.материалыviewBindingSource.DataSource = this.косметический_кабинетDataSet;
            // 
            // косметический_кабинетDataSet
            // 
            this.косметический_кабинетDataSet.DataSetName = "Косметический_кабинетDataSet";
            this.косметический_кабинетDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 174);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Количество";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 75);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 19);
            this.button2.TabIndex = 83;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 19);
            this.button1.TabIndex = 82;
            this.button1.Text = "Списать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // материалы_На_СкладеDataGridView
            // 
            this.материалы_На_СкладеDataGridView.AutoGenerateColumns = false;
            this.материалы_На_СкладеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.материалы_На_СкладеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.материалы_На_СкладеDataGridView.DataSource = this.материалы_На_СкладеBindingSource;
            this.материалы_На_СкладеDataGridView.Location = new System.Drawing.Point(13, 42);
            this.материалы_На_СкладеDataGridView.Name = "материалы_На_СкладеDataGridView";
            this.материалы_На_СкладеDataGridView.Size = new System.Drawing.Size(268, 313);
            this.материалы_На_СкладеDataGridView.TabIndex = 88;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование_материала";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование_материала";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Количество на складе";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество на складе";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // материалы_На_СкладеBindingSource
            // 
            this.материалы_На_СкладеBindingSource.DataMember = "Материалы_На_Складе";
            this.материалы_На_СкладеBindingSource.DataSource = this.косметический_кабинетDataSet;
            // 
            // материалы_viewTableAdapter
            // 
            this.материалы_viewTableAdapter.ClearBeforeFill = true;
            // 
            // материалы_На_СкладеTableAdapter
            // 
            this.материалы_На_СкладеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = DIPLOM.Косметический_кабинетDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 14);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 89;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(361, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 90;
            // 
            // mat_spis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 367);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.материалы_На_СкладеDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "mat_spis";
            this.Text = "Списание";
            this.Load += new System.EventHandler(this.mat_spis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.материалыviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалы_На_СкладеDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалы_На_СкладеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Косметический_кабинетDataSet косметический_кабинетDataSet;
        private System.Windows.Forms.BindingSource материалыviewBindingSource;
        private Косметический_кабинетDataSetTableAdapters.Материалы_viewTableAdapter материалы_viewTableAdapter;
        private System.Windows.Forms.BindingSource материалы_На_СкладеBindingSource;
        private Косметический_кабинетDataSetTableAdapters.Материалы_На_СкладеTableAdapter материалы_На_СкладеTableAdapter;
        private Косметический_кабинетDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView материалы_На_СкладеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}