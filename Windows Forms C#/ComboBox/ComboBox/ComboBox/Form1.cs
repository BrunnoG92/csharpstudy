using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Cadastrar_Click(object sender, EventArgs e)
        {
            Cmb_CMBNOMES.Items.Add(Txt_CaixaNome.Text);

        }


        private void Btn2_Limpar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Você selecionou: " + Cmb_CMBNOMES.SelectedItem.ToString());
        }

       
    }
}
