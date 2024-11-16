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
    public partial class Sklad : Form
    {
        public Sklad()
        {
            InitializeComponent();
        }

        private void Sklad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Материалы_На_Складе". При необходимости она может быть перемещена или удалена.
            this.материалы_На_СкладеTableAdapter.Fill(this.косметический_кабинетDataSet.Материалы_На_Складе);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application MExcel = new Microsoft.Office.Interop.Excel.Application();
                MExcel.Application.Workbooks.Add();

                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    MExcel.Cells[1, i] = dataGridView1.Columns[i].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    MExcel.Cells[i + 2, 1] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    MExcel.Cells[i + 2, 2] = dataGridView1.Rows[i].Cells[2].Value.ToString();

                }
                //int price = 0;
                //for (int i = 1; i < dataGridView1.Rows.Count; i++)
                //{
                //    price = price + Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                //}
                //MExcel.Cells[dataGridView1.Rows.Count + 2, 2] = "Вывод по стоимости:";
                //MExcel.Cells[dataGridView1.Rows.Count + 2, 3] = price;

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
