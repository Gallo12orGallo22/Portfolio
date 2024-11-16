using DIPLOM.Косметический_кабинетDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIPLOM
{
    public partial class mat_spis : Form
    {
        public mat_spis()
        {
            InitializeComponent();
        }

        private void mat_spis_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Материалы_На_Складе". При необходимости она может быть перемещена или удалена.
            this.материалы_На_СкладеTableAdapter.Fill(this.косметический_кабинетDataSet.Материалы_На_Складе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Материалы_view". При необходимости она может быть перемещена или удалена.
            this.материалы_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Материалы_view);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.материалы_На_СкладеTableAdapter.Списание(Convert.ToInt32(this.материалы_На_СкладеDataGridView.CurrentRow.Cells[0].Value), Convert.ToInt32(numericUpDown1.Value));
                this.материалы_На_СкладеTableAdapter.Fill(this.косметический_кабинетDataSet.Материалы_На_Складе);

            }
            catch { MessageBox.Show("Вы не ввели данные!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.материалы_На_СкладеTableAdapter.FillBy(this.косметический_кабинетDataSet.Материалы_На_Складе, textBox2.Text);
        }
    }
}
