namespace DIPLOM
{
    partial class prihod_new
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.поставщикиviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.косметический_кабинетDataSet = new DIPLOM.Косметический_кабинетDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.материалыviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.материалы_viewTableAdapter = new DIPLOM.Косметический_кабинетDataSetTableAdapters.Материалы_viewTableAdapter();
            this.поставщики_viewTableAdapter = new DIPLOM.Косметический_кабинетDataSetTableAdapters.Поставщики_viewTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.поставщикиviewBindingSource;
            this.comboBox2.DisplayMember = "Наименование";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(121, 151);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 77;
            this.comboBox2.ValueMember = "ID";
            // 
            // поставщикиviewBindingSource
            // 
            this.поставщикиviewBindingSource.DataMember = "Поставщики_view";
            this.поставщикиviewBindingSource.DataSource = this.косметический_кабинетDataSet;
            // 
            // косметический_кабинетDataSet
            // 
            this.косметический_кабинетDataSet.DataSetName = "Косметический_кабинетDataSet";
            this.косметический_кабинетDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.материалыviewBindingSource;
            this.comboBox1.DisplayMember = "Наименование_материала";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 76;
            this.comboBox1.ValueMember = "ID";
            // 
            // материалыviewBindingSource
            // 
            this.материалыviewBindingSource.DataMember = "Материалы_view";
            this.материалыviewBindingSource.DataSource = this.косметический_кабинетDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 116);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 75;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Поставщик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Количество";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 231);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 19);
            this.button2.TabIndex = 71;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 19);
            this.button1.TabIndex = 70;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Материал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Дата";
            // 
            // материалы_viewTableAdapter
            // 
            this.материалы_viewTableAdapter.ClearBeforeFill = true;
            // 
            // поставщики_viewTableAdapter
            // 
            this.поставщики_viewTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 188);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Цена за единицу";
            // 
            // prihod_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 286);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
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
            this.Name = "prihod_new";
            this.Text = "prihod_new";
            this.Load += new System.EventHandler(this.prihod_new_Load);
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.косметический_кабинетDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Косметический_кабинетDataSet косметический_кабинетDataSet;
        private System.Windows.Forms.BindingSource материалыviewBindingSource;
        private Косметический_кабинетDataSetTableAdapters.Материалы_viewTableAdapter материалы_viewTableAdapter;
        private System.Windows.Forms.BindingSource поставщикиviewBindingSource;
        private Косметический_кабинетDataSetTableAdapters.Поставщики_viewTableAdapter поставщики_viewTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}