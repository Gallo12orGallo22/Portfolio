namespace DIPLOM
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хранилищеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продажиToolStripMenuItem,
            this.складToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.продажиToolStripMenuItem.Text = "Записи";
            this.продажиToolStripMenuItem.Click += new System.EventHandler(this.продажиToolStripMenuItem_Click);
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.хранилищеToolStripMenuItem,
            this.приходToolStripMenuItem,
            this.списаниеToolStripMenuItem});
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.складToolStripMenuItem.Text = "Материалы";
            this.складToolStripMenuItem.Click += new System.EventHandler(this.складToolStripMenuItem_Click);
            // 
            // хранилищеToolStripMenuItem
            // 
            this.хранилищеToolStripMenuItem.Name = "хранилищеToolStripMenuItem";
            this.хранилищеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.хранилищеToolStripMenuItem.Text = "Хранилище";
            this.хранилищеToolStripMenuItem.Click += new System.EventHandler(this.хранилищеToolStripMenuItem_Click);
            // 
            // приходToolStripMenuItem
            // 
            this.приходToolStripMenuItem.Name = "приходToolStripMenuItem";
            this.приходToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.приходToolStripMenuItem.Text = "Приход";
            this.приходToolStripMenuItem.Click += new System.EventHandler(this.приходToolStripMenuItem_Click);
            // 
            // списаниеToolStripMenuItem
            // 
            this.списаниеToolStripMenuItem.Name = "списаниеToolStripMenuItem";
            this.списаниеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.списаниеToolStripMenuItem.Text = "Списание";
            this.списаниеToolStripMenuItem.Click += new System.EventHandler(this.списаниеToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            this.справочникиToolStripMenuItem.Click += new System.EventHandler(this.справочникиToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Главная";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хранилищеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списаниеToolStripMenuItem;
    }
}

