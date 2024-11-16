using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DIPLOM
{
    public partial class client_new : Form
    {
        public client_new()
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
        public string fio
        {
            get { return textBox1.Text; }
            set { textBox1.Text = Convert.ToString(value); }
        }
        public string phone
        {
            get { return textBox2.Text; }
            set { textBox2.Text = Convert.ToString(value); }
        }
        public string chron
        {
            get { return textBox3.Text; }
            set { textBox3.Text = Convert.ToString(value); }
        }
        public string prot
        {
            get { return textBox4.Text; }
            set { textBox4.Text = Convert.ToString(value); }
        }
    }
}
