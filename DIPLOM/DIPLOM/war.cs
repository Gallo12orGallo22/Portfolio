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
    public partial class war : Form
    {
        public war()
        {
            InitializeComponent();
            _Rc = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Rc = true;
            Close();
        }

        bool _Rc;
        public bool Rc { get { return _Rc; } }

        private void button2_Click(object sender, EventArgs e)
        {
            _Rc = false;
            Close();
        }
    }
}
