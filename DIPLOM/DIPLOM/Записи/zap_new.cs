using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DIPLOM
{
    public partial class zap_new : Form
    {
        public zap_new()
        {
            InitializeComponent();
            _Rc = false;
        }
        bool _Rc;
        public bool Rc { get { return _Rc; } }
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
            set { dateTimePicker1.Value = Convert.ToDateTime(value);}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _Rc = true;
            Close();
        }
        public TimeSpan time
        {
            get {  return TimeSpan.Parse(textBox1.Text); }
            set { textBox1.Text = Convert.ToString(value); }
        }
        public int fio
        {
            get { return Convert.ToInt32(comboBox1.SelectedValue); }
            set { comboBox1.ValueMember = Convert.ToString(value); }
        }
        public int us
        {
            get { return Convert.ToInt32(comboBox2.SelectedValue); }
            set { comboBox2.ValueMember = Convert.ToString(value); }
        }

        private void zap_new_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet1.Услуги_view". При необходимости она может быть перемещена или удалена.
            this.услуги_viewTableAdapter.Fill(this.косметический_кабинетDataSet1.Услуги_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet1.Клиенты_view". При необходимости она может быть перемещена или удалена.
            this.клиенты_viewTableAdapter.Fill(this.косметический_кабинетDataSet1.Клиенты_view);

        }
    }
}
