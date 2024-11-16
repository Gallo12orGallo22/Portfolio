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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Клиенты_view". При необходимости она может быть перемещена или удалена.
            this.клиенты_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Клиенты_view);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            client_new f = new client_new();
            f.ShowDialog();
            if (f.Rc)
            {
                try
                {
                     this.клиенты_viewTableAdapter.Клиенты_Добавить(f.fio,f.phone,f.chron,f.prot);
                     this.клиенты_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Клиенты_view);
                }
                catch
                {
                    MessageBox.Show("Вы не ввели данные для добавления!");
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            client_new f = new client_new();
            f.fio = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            f.phone = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);
            f.chron = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
            f.prot = Convert.ToString(this.dataGridView1.CurrentRow.Cells[4].Value);

            f.ShowDialog();
            if (f.Rc)
            {
                try
                {
                    this.клиенты_viewTableAdapter.Клиенты_Изменить(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value),f.fio, f.phone, f.chron, f.prot);
                    this.клиенты_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Клиенты_view);
                }
                catch
                {
                    MessageBox.Show("Вы не ввели данные для изменения!");
                }
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
                    this.клиенты_viewTableAdapter.Клиенты_Удалить(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                    this.клиенты_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Клиенты_view);
                }
                catch
                {
                    MessageBox.Show("Вы не выбрали запись для удаления!");
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
                          
                try
                {
                  Client_card f = new Client_card();
                  f.i = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                  f.ShowDialog();  
                  
                }
                catch { MessageBox.Show("Выберите клиента!"); }
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.клиенты_viewTableAdapter.FillBy(this.косметический_кабинетDataSet.Клиенты_view, toolStripTextBox1.Text); 
        }
    }
}
