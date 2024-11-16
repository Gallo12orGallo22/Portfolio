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
    public partial class Guids : Form
    {
        public Guids()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guids_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Города_view". При необходимости она может быть перемещена или удалена.
            this.города_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Города_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Использование_материалов_view". При необходимости она может быть перемещена или удалена.
            this.использование_материалов_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Использование_материалов_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Статус_записи_view". При необходимости она может быть перемещена или удалена.
            this.статус_записи_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Статус_записи_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Материалы_view". При необходимости она может быть перемещена или удалена.
            this.материалы_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Материалы_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Поставщики_view". При необходимости она может быть перемещена или удалена.
            this.поставщики_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Поставщики_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Услуги_view". При необходимости она может быть перемещена или удалена.
            this.услуги_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Услуги_view);

        }

        private void toolStripButton28_Click(object sender, EventArgs e)
        {
            //us_dob f = new us_dob();
            //f.ShowDialog();
            //if (f.Rc)
            //{
            //    try
            //    {
            //        this.услуги_viewTableAdapter.Услуги_Добавить(f.name, Convert.ToDecimal(f.cost));
            //        this.услуги_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Услуги_view);
            //    }
            //    catch { MessageBox.Show("Вы не ввели данные для добавления!"); }
            //}
            try
            {
                this.услуги_viewTableAdapter.Услуги_Добавить( toolStripTextBox13.Text, Convert.ToDecimal(toolStripTextBox14.Text));
                this.услуги_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Услуги_view);
                toolStripTextBox13.Text = "";
                toolStripTextBox14.Text = "";
            }
            catch { MessageBox.Show("Вы не ввели данные для добавления!"); }
        }

        private void toolStripButton29_Click(object sender, EventArgs e)
        {
            //us_dob f = new us_dob();
            //f.ShowDialog();
            //f.name = this.dataGridView8.CurrentRow.Cells[1].Value.ToString();
            //f.cost = Convert.ToDecimal(this.dataGridView8.CurrentRow.Cells[2].Value);
            //if (f.Rc)
            
                try
                {
                    this.услуги_viewTableAdapter.Услуги_Изменить(Convert.ToInt32(this.dataGridView8.CurrentRow.Cells[0].Value), toolStripTextBox13.Text, Convert.ToDecimal(toolStripTextBox14.Text));
                    this.услуги_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Услуги_view);
                toolStripTextBox13.Text = "";
                toolStripTextBox14.Text = "";
            }
            catch { MessageBox.Show("Вы не ввели данные для изменения!"); }
            
        }

        private void toolStripTextBox13_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton30_Click(object sender, EventArgs e)
        {
            try
            {
                this.услуги_viewTableAdapter.Услуги_Удалить(Convert.ToInt32(this.dataGridView8.CurrentRow.Cells[0].Value));
                this.услуги_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Услуги_view);
                toolStripTextBox13.Text = "";
                toolStripTextBox14.Text = "";
            }
            catch { MessageBox.Show("Вы не выбрали поле для удаления!"); }
        }

        private void toolStripButton31_Click(object sender, EventArgs e)
        {
            toolStripTextBox13.Text = "";
            toolStripTextBox14.Text = "";

        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripTextBox13.Text = Convert.ToString(this.dataGridView8.CurrentRow.Cells[1].Value);
            toolStripTextBox14.Text = Convert.ToString(this.dataGridView8.CurrentRow.Cells[2].Value);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                this.поставщики_viewTableAdapter.Поставщики_Добавить(toolStripTextBox3.Text, Convert.ToInt32(comboBox3.SelectedValue), toolStripTextBox6.Text); //!!!!!!!!!!!!!!!!
                this.поставщики_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Поставщики_view);
                toolStripTextBox3.Text = "";
                toolStripTextBox6.Text = "";

            }
            catch { MessageBox.Show("Вы не ввели данные для добавления!"); }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                this.поставщики_viewTableAdapter.Поставщики_Изменить(Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value),toolStripTextBox3.Text, Convert.ToInt32(comboBox3.SelectedValue), toolStripTextBox6.Text); //!!!!!!!!!!!!!!!!
                this.поставщики_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Поставщики_view);
                toolStripTextBox3.Text = "";
                toolStripTextBox6.Text = "";
            }
            catch { MessageBox.Show("Вы не ввели данные для добавления!"); }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                this.поставщики_viewTableAdapter.Поставщики_Удалить(Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value)); //!!!!!!!!!!!!!!!!
                this.поставщики_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Поставщики_view);
                toolStripTextBox3.Text = "";
                toolStripTextBox6.Text = "";
            }
            catch { MessageBox.Show("Вы не выбрали поле для удаления!"); }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            toolStripTextBox3.Text = "";
            toolStripTextBox6.Text = "";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripTextBox3.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells[1].Value);
            toolStripTextBox6.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells[2].Value);
        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            try
            {
                this.материалы_viewTableAdapter.Материалы_Добавить(toolStripTextBox10.Text); //!!!!!!!!!!!!!!!!
                this.материалы_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Материалы_view);
                toolStripTextBox10.Text = "";
               

            }
            catch { MessageBox.Show("Вы не ввели данные для добавления!"); }
        }

        private void toolStripButton22_Click(object sender, EventArgs e)
        {
            try
            {
                this.материалы_viewTableAdapter.Материалы_Изменить(Convert.ToInt32(this.dataGridView6.CurrentRow.Cells[0].Value),toolStripTextBox10.Text); //!!!!!!!!!!!!!!!!
                this.материалы_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Материалы_view);
                toolStripTextBox10.Text = "";
               

            }
            catch { MessageBox.Show("Вы не ввели данные для изменения!"); }
        }

        private void toolStripButton23_Click(object sender, EventArgs e)
        {
            try
            {
                this.материалы_viewTableAdapter.Материалы_Удалить(Convert.ToInt32(this.dataGridView6.CurrentRow.Cells[0].Value)); //!!!!!!!!!!!!!!!!
                this.материалы_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Материалы_view);
                toolStripTextBox10.Text = "";
                

            }
            catch { MessageBox.Show("Вы не выбрали поле для удаления!"); }
        }

        private void toolStripButton24_Click(object sender, EventArgs e)
        {
            toolStripTextBox10.Text = "";
         
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripTextBox10.Text = Convert.ToString(this.dataGridView6.CurrentRow.Cells[1].Value);
            

        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            try
            {
                this.статус_записи_viewTableAdapter.Статус_записи_Добавить(toolStripTextBox9.Text); 
                this.статус_записи_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Статус_записи_view);
                toolStripTextBox9.Text = "";

            }
            catch { MessageBox.Show("Вы не ввели данные для добавления!"); }
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            try
            {
                this.статус_записи_viewTableAdapter.Статус_записи_Изменить(Convert.ToInt32(this.dataGridView5.CurrentRow.Cells[0].Value),toolStripTextBox9.Text); 
                this.статус_записи_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Статус_записи_view);
                toolStripTextBox9.Text = "";

            }
            catch { MessageBox.Show("Вы не ввели данные для изменения!"); }
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            try
            {
                this.статус_записи_viewTableAdapter.Статус_записи_Удалить(Convert.ToInt32(this.dataGridView5.CurrentRow.Cells[0].Value));
                this.статус_записи_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Статус_записи_view);
                toolStripTextBox9.Text = "";

            }
            catch { MessageBox.Show("Вы не ввели данные для удаления!"); }

        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            toolStripTextBox9.Text = "";

        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripTextBox9.Text = Convert.ToString(this.dataGridView5.CurrentRow.Cells[1].Value);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.использование_материалов_viewTableAdapter.Использование_материалов_Добавить(Convert.ToInt32(comboBox1.SelectedValue),Convert.ToInt32(comboBox2.SelectedValue),Convert.ToInt32(toolStripTextBox5.Text));
                this.использование_материалов_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Использование_материалов_view);
                comboBox1.Text = "";
                comboBox2.Text = "";
                toolStripTextBox5.Text = "";
            }
            catch { MessageBox.Show("Вы не ввели данные для добавления!"); }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.использование_материалов_viewTableAdapter.Использование_материалов_Изменить(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value),Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(toolStripTextBox5.Text));
                this.использование_материалов_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Использование_материалов_view);
                comboBox1.Text = "";
                comboBox2.Text = "";
                toolStripTextBox5.Text = "";
            }
            catch { MessageBox.Show("Вы не ввели данные для изменения!"); }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.использование_материалов_viewTableAdapter.Использование_материалов_Удалить(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                this.использование_материалов_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Использование_материалов_view);
                comboBox1.Text = "";
                comboBox2.Text = "";
                toolStripTextBox5.Text = "";
            }
            catch { MessageBox.Show("Вы не выбрали строку для удаления!"); }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            toolStripTextBox5.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            comboBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);
            toolStripTextBox5.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            try
            {
                this.города_viewTableAdapter.Города_Добавить(toolStripTextBox7.Text);
                this.города_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Города_view);
                toolStripTextBox7.Text = "";

            }
            catch { MessageBox.Show("Вы не ввели данные для добавления!"); }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            try
            {
                this.города_viewTableAdapter.Города_Изменить(Convert.ToInt32(this.dataGridView4.CurrentRow.Cells[0].Value),toolStripTextBox7.Text);
                this.города_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Города_view);
                toolStripTextBox7.Text = "";

            }
            catch { MessageBox.Show("Вы не ввели данные для изменения!"); }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            try
            {
                this.города_viewTableAdapter.Города_Удалить(Convert.ToInt32(this.dataGridView4.CurrentRow.Cells[0].Value));
                this.города_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Города_view);
                toolStripTextBox7.Text = "";

            }
            catch { MessageBox.Show("Вы не выбрали поле для удаления!"); }
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            toolStripTextBox7.Text = "";

        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripTextBox7.Text = Convert.ToString(this.dataGridView4.CurrentRow.Cells[1].Value);

        }
    }
}
