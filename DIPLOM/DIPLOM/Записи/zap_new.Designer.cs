namespace DIPLOM
{
    partial class zap_new
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.косметический_кабинетDataSet1 = new DIPLOM.Косметический_кабинетDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.клиентыviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.услугиviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиенты_viewTableAdapter = new DIPLOM.Косметический_кабинетDataSetTableAdapters.Клиенты_viewTableAdapter();
            this.услуги_viewTableAdapter = new DIPLOM.Косметический_кабинетDataSetTableAdapters.Услуги_viewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 197);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 19);
            this.button2.TabIndex = 58;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 19);
            this.button1.TabIndex = 57;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Время";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Услуга";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 64;
            // 
            // косметический_кабинетDataSet1
            // 
            this.косметический_кабинетDataSet1.DataSetName = "Косметический_кабинетDataSet";
            this.косметический_кабинетDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 65;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.клиентыviewBindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 66;
            this.comboBox1.ValueMember = "ID";
            // 
            // клиентыviewBindingSource
            // 
            this.клиентыviewBindingSource.DataMember = "Клиенты_view";
            this.клиентыviewBindingSource.DataSource = this.косметический_кабинетDataSet1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.услугиviewBindingSource;
            this.comboBox2.DisplayMember = "Наименование услуги";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(149, 143);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 67;
            this.comboBox2.ValueMember = "ID";
            // 
            // услугиviewBindingSource
            // 
            this.услугиviewBindingSource.DataMember = "Услуги_view";
            this.услугиviewBindingSource.DataSource = this.косметический_кабинетDataSet1;
            // 
            // клиенты_viewTableAdapter
            // 
            this.клиенты_viewTableAdapter.ClearBeforeFill = true;
            // 
            // услуги_viewTableAdapter
            // 
            this.услуги_viewTableAdapter.ClearBeforeFill = true;
            // 
            // zap_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 280);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "zap_new";
            this.Text = "Добавление записи";
            this.Load += new System.EventHandler(this.zap_new_Load);
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Косметический_кабинетDataSet косметический_кабинетDataSet1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource клиентыviewBindingSource;
        private Косметический_кабинетDataSetTableAdapters.Клиенты_viewTableAdapter клиенты_viewTableAdapter;
        private System.Windows.Forms.BindingSource услугиviewBindingSource;
        private Косметический_кабинетDataSetTableAdapters.Услуги_viewTableAdapter услуги_viewTableAdapter;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
    }
}