using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdb__CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Sim.Checked)
            {
                MessageBox.Show("Marcado SIM");
            }
            else
            {
                MessageBox.Show("Marcado NÂO");
            }
        }

        private void Btn2_Limpar_Click(object sender, EventArgs e)
        {
            Rdb2_Nao.Checked = true;
        }

      
    }
}
