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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders f1 = new Orders();
            f1.MdiParent = this;
            f1.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients f1 = new Clients();
            f1.MdiParent = this;
            f1.Show();
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guids f1 = new Guids();
            f1.MdiParent = this;
            f1.Show();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void производствоToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void хранилищеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sklad f1 = new Sklad();
            f1.MdiParent = this;
            f1.Show();
        }

        private void приходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mat_prihod f1 = new mat_prihod();
            f1.MdiParent = this;
            f1.Show();
        }

        private void списаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mat_spis f1 = new mat_spis();
            f1.MdiParent = this;
            f1.Show();
        }
    }
}
