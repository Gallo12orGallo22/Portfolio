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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Записи_Отменены". При необходимости она может быть перемещена или удалена.
            this.записи_ОтмененыTableAdapter.Fill(this.косметический_кабинетDataSet.Записи_Отменены);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Записи_Выполнено". При необходимости она может быть перемещена или удалена.
            this.записи_ВыполненоTableAdapter.Fill(this.косметический_кабинетDataSet.Записи_Выполнено);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Записи_Ожидаются". При необходимости она может быть перемещена или удалена.
            this.записи_ОжидаютсяTableAdapter.Fill(this.косметический_кабинетDataSet.Записи_Ожидаются);
            textBox1.Text = "Итого " + Convert.ToString(this.записи_ВыполненоTableAdapter.ScalarQuery());


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            zap_new f = new zap_new();
            f.ShowDialog();
            if (f.Rc)
            {
                try
                {
                    this.записи_ОжидаютсяTableAdapter.Записи_Добавить(Convert.ToDateTime(f.date), f.time, Convert.ToInt32(f.fio), Convert.ToInt32(f.us), 1);
                    this.записи_ОжидаютсяTableAdapter.Fill(this.косметический_кабинетDataSet.Записи_Ожидаются);
                }
                catch { MessageBox.Show("Вы не ввели данные для добавления!"); }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            zap_new f = new zap_new();
            f.date = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[1].Value);
            f.time = TimeSpan.Parse(Convert.ToString(dataGridView2.CurrentRow.Cells[2].Value));
            f.comboBox1.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[3].Value);
            f.comboBox2.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[4].Value);
            f.ShowDialog();
            
            if (f.Rc)
            {
                try
                {
                    this.записи_ОжидаютсяTableAdapter.Записи_Изменить(Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value),Convert.ToDateTime(f.date), f.time, Convert.ToInt32(f.fio), Convert.ToInt32(f.us), 1);
                    this.записи_ОжидаютсяTableAdapter.Fill(this.косметический_кабинетDataSet.Записи_Ожидаются);
                }
                catch { MessageBox.Show("Вы не ввели данные для изменения!"); }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            war f = new war();
            f.ShowDialog();
            if (f.Rc)
            {
                try
                {
                    this.записи_ОжидаютсяTableAdapter.Записи_Удалить(Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value));
                    this.записи_ОжидаютсяTableAdapter.Fill(this.косметический_кабинетDataSet.Записи_Ожидаются);
                }
                catch { MessageBox.Show("Вы не выбрали строку для удаления!"); }
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.записи_ОжидаютсяTableAdapter.Запись_Изменить_Статус(Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value), 2);
                this.записи_ОжидаютсяTableAdapter.Провести_процедуру(Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[6].Value));
                this.записи_ОжидаютсяTableAdapter.Fill(this.косметический_кабинетDataSet.Записи_Ожидаются);
                this.записи_ВыполненоTableAdapter.Fill(this.косметический_кабинетDataSet.Записи_Выполнено);
                textBox1.Text = "Итого " + Convert.ToString(this.записи_ВыполненоTableAdapter.ScalarQuery());
                //this.dataGridView1.Rows.Add();
                //this.dataGridView1.Rows.Add();
            }
            catch { MessageBox.Show("Вы не выбрали запись для проведения!"); }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            try
            {
                this.записи_ОжидаютсяTableAdapter.Запись_Изменить_Статус(Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value), 3);
                this.записи_ОжидаютсяTableAdapter.Fill(this.косметический_кабинетDataSet.Записи_Ожидаются);
                this.записи_ОтмененыTableAdapter.Fill(this.косметический_кабинетDataSet.Записи_Отменены);
            }
            catch { MessageBox.Show("Вы не выбрали запись для отмены!"); }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.записи_ВыполненоTableAdapter.FillBy(this.косметический_кабинетDataSet.Записи_Выполнено, Convert.ToString(dateTimePicker1.Value));
            int price = 0;
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                price = price + (Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value));
            }
            textBox1.Text = "Итого " + price.ToString();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            this.записи_ВыполненоTableAdapter.Fill(this.косметический_кабинетDataSet.Записи_Выполнено);
            textBox1.Text = "Итого " + Convert.ToString(this.записи_ВыполненоTableAdapter.ScalarQuery());
        }
    }
}
