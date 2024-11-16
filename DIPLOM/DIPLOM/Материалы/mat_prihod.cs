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
    public partial class mat_prihod : Form
    {
        public mat_prihod()
        {
            InitializeComponent();
        }

        private void mat_prihod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet1.Материалы_Приход_view". При необходимости она может быть перемещена или удалена.
            this.материалы_Приход_viewTableAdapter.Fill(this.косметический_кабинетDataSet1.Материалы_Приход_view);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            prihod_new f = new prihod_new();
            //f.date = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[1].Value);
            //f.name = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[2].Value);
            //f.num = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[4].Value);
            //f.post = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[5].Value);

            f.ShowDialog();
            if (f.Rc)
            {
                try
                {
                    this.материалы_Приход_viewTableAdapter.Приход_Добавить(f.date, f.name, f.num, f.post, f.cost);
                    this.материалы_Приход_viewTableAdapter.Fill(this.косметический_кабинетDataSet1.Материалы_Приход_view);
                }
                catch
                {
                    MessageBox.Show("Вы не ввели данные для добавления!");
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.материалы_Приход_viewTableAdapter.Приход_Удалить(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                this.материалы_Приход_viewTableAdapter.Fill(this.косметический_кабинетDataSet1.Материалы_Приход_view);
            }
            catch
            {
                MessageBox.Show("Вы не выбрали запись для удаления!");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application MExcel = new Microsoft.Office.Interop.Excel.Application();
                MExcel.Application.Workbooks.Add();

                int q = 1;
                MExcel.Cells[1, 1] = dataGridView1.Columns[q].HeaderText;
                q = 3;
                MExcel.Cells[1, 2] = dataGridView1.Columns[q].HeaderText;
                q = 4;
                MExcel.Cells[1, 3] = dataGridView1.Columns[q].HeaderText;
                q = 6;
                MExcel.Cells[1, 4] = dataGridView1.Columns[q].HeaderText;
                q = 7;
                MExcel.Cells[1, 5] = dataGridView1.Columns[q].HeaderText;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    decimal a = Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                    MExcel.Cells[i + 2, 1] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    MExcel.Cells[i + 2, 2] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    MExcel.Cells[i + 2, 3] = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    MExcel.Cells[i + 2, 4] = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    MExcel.Cells[i + 2, 5] = a.ToString();
                }
                int price = 0;
                for (int i = 1; i < dataGridView1.Rows.Count; i++)
                {
                    price = price + (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value));
                }
                MExcel.Cells[dataGridView1.Rows.Count + 2, 4] = "Итого:";
                MExcel.Cells[dataGridView1.Rows.Count + 2, 5] = price;

                MExcel.Columns.AutoFit();
                MExcel.Rows.AutoFit();
                MExcel.Columns.Font.Size = 12;
                MExcel.Visible = true;
            }
            else
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}