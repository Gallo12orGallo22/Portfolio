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
    public partial class prihod_new : Form
    {
        public prihod_new()
        {
            InitializeComponent();
            _Rc = false;
        }
        bool _Rc;
        public bool Rc { get { return _Rc; } }
        private void prihod_new_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Поставщики_view". При необходимости она может быть перемещена или удалена.
            this.поставщики_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Поставщики_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Материалы_view". При необходимости она может быть перемещена или удалена.
            this.материалы_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Материалы_view);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Rc = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _Rc = false;
            Close();
        }
        public DateTime date
        {
            get { return Convert.ToDateTime(dateTimePicker1.Value); }
            set { dateTimePicker1.Value = Convert.ToDateTime(value); }
        }
        public int name
        {
            get { return Convert.ToInt32(comboBox1.SelectedValue); }
            set { comboBox1.Text = Convert.ToString(value); }
        }
        public int num
        {
            get { return Convert.ToInt32(textBox1.Text); }
            set { textBox1.Text = Convert.ToString(value); }
        }
        public int post
        {
            get { return Convert.ToInt32(comboBox2.SelectedValue); }
            set { comboBox2.ValueMember = Convert.ToString(value); }
        }
        public decimal cost
        {
            get { return Convert.ToDecimal(textBox2.Text); }
            set { textBox2.Text = Convert.ToString(value); }
        }
    }
}
