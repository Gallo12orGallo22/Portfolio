namespace DIPLOM
{
    partial class Client_card
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСтатусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.хроническиеЗаболеванияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.противопоказанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.картаклиентаviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.косметический_кабинетDataSet = new DIPLOM.Косметический_кабинетDataSet();
            this.карта_клиента_viewTableAdapter = new DIPLOM.Косметический_кабинетDataSetTableAdapters.Карта_клиента_viewTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.картаклиентаviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.iDКлиентаDataGridViewTextBoxColumn,
            this.iDУслугиDataGridViewTextBoxColumn,
            this.iDСтатусDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.хроническиеЗаболеванияDataGridViewTextBoxColumn,
            this.противопоказанияDataGridViewTextBoxColumn,
            this.наименованиеУслугиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.картаклиентаviewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            // 
            // iDКлиентаDataGridViewTextBoxColumn
            // 
            this.iDКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ID_Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.HeaderText = "ID_Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.Name = "iDКлиентаDataGridViewTextBoxColumn";
            this.iDКлиентаDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDУслугиDataGridViewTextBoxColumn
            // 
            this.iDУслугиDataGridViewTextBoxColumn.DataPropertyName = "ID_Услуги";
            this.iDУслугиDataGridViewTextBoxColumn.HeaderText = "ID_Услуги";
            this.iDУслугиDataGridViewTextBoxColumn.Name = "iDУслугиDataGridViewTextBoxColumn";
            this.iDУслугиDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDСтатусDataGridViewTextBoxColumn
            // 
            this.iDСтатусDataGridViewTextBoxColumn.DataPropertyName = "ID_Статус";
            this.iDСтатусDataGridViewTextBoxColumn.HeaderText = "ID_Статус";
            this.iDСтатусDataGridViewTextBoxColumn.Name = "iDСтатусDataGridViewTextBoxColumn";
            this.iDСтатусDataGridViewTextBoxColumn.Visible = false;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // хроническиеЗаболеванияDataGridViewTextBoxColumn
            // 
            this.хроническиеЗаболеванияDataGridViewTextBoxColumn.DataPropertyName = "Хронические заболевания";
            this.хроническиеЗаболеванияDataGridViewTextBoxColumn.HeaderText = "Хронические заболевания";
            this.хроническиеЗаболеванияDataGridViewTextBoxColumn.Name = "хроническиеЗаболеванияDataGridViewTextBoxColumn";
            // 
            // противопоказанияDataGridViewTextBoxColumn
            // 
            this.противопоказанияDataGridViewTextBoxColumn.DataPropertyName = "Противопоказания";
            this.противопоказанияDataGridViewTextBoxColumn.HeaderText = "Противопоказания";
            this.противопоказанияDataGridViewTextBoxColumn.Name = "противопоказанияDataGridViewTextBoxColumn";
            // 
            // наименованиеУслугиDataGridViewTextBoxColumn
            // 
            this.наименованиеУслугиDataGridViewTextBoxColumn.DataPropertyName = "Наименование услуги";
            this.наименованиеУслугиDataGridViewTextBoxColumn.HeaderText = "Наименование услуги";
            this.наименованиеУслугиDataGridViewTextBoxColumn.Name = "наименованиеУслугиDataGridViewTextBoxColumn";
            // 
            // картаклиентаviewBindingSource
            // 
            this.картаклиентаviewBindingSource.DataMember = "Карта_клиента_view";
            this.картаклиентаviewBindingSource.DataSource = this.косметический_кабинетDataSet;
            // 
            // косметический_кабинетDataSet
            // 
            this.косметический_кабинетDataSet.DataSetName = "Косметический_кабинетDataSet";
            this.косметический_кабинетDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // карта_клиента_viewTableAdapter
            // 
            this.карта_клиента_viewTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(448, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Client_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 421);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Client_card";
            this.Text = "Client_card";
            this.Load += new System.EventHandler(this.Client_card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.картаклиентаviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Косметический_кабинетDataSet косметический_кабинетDataSet;
        private System.Windows.Forms.BindingSource картаклиентаviewBindingSource;
        private Косметический_кабинетDataSetTableAdapters.Карта_клиента_viewTableAdapter карта_клиента_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСтатусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn хроническиеЗаболеванияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn противопоказанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
    }
}