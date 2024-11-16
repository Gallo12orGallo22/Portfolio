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
    public partial class Client_card : Form
    {
        public Client_card()
        {
            
            InitializeComponent();            
        }
        public int i
        {
            get { return Convert.ToInt32(textBox1.Text); }
            set { textBox1.Text=Convert.ToString(value); }
        }
        private void Client_card_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "косметический_кабинетDataSet.Карта_клиента_view". При необходимости она может быть перемещена или удалена.
            this.карта_клиента_viewTableAdapter.Fill(this.косметический_кабинетDataSet.Карта_клиента_view);
            this.карта_клиента_viewTableAdapter.FillBy(this.косметический_кабинетDataSet.Карта_клиента_view,i);

        }
    }
}
