using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CriarColunas();
        }
        private void CriarColunas()
        {
            lvl_ListaNomes.Clear();
            lvl_ListaNomes.Columns.Insert(0, "Nome:", 250, HorizontalAlignment.Left);
            lvl_ListaNomes.Columns.Insert(1, "Idade:", 100, HorizontalAlignment.Right);
        }
        private void TxtB_CaixaNome_Validating(object sender, CancelEventArgs e)
        {
            if (TxtB_CaixaNome.Text.Trim().Length < 3)
            {
                MessageBox.Show("Nome inválido");
                TxtB_CaixaNome.Focus();
            }
        }
        private void TxtB_CaixaIdade_Validating(object sender, CancelEventArgs e)
        {
            if (TxtB_CaixaIdade.Text.Trim().Equals(String.Empty)) //se for vazio a caixa
            {
                MessageBox.Show("Idade inválida");
                TxtB_CaixaIdade.Focus();
            }
        }
        private void Btn1_Cadastrar_Click(object sender, EventArgs e)
        {
            ListViewItem ItmX = lvl_ListaNomes.Items.Add(TxtB_CaixaNome.Text.Trim()); // criada a lista ItmX
            ItmX.SubItems.Add(new ListViewItem.ListViewSubItem(null, TxtB_CaixaIdade.Text.Trim())); //Instanciada a lsita ItmX e a sublista
            TxtB_CaixaNome.Text = String.Empty;
            TxtB_CaixaIdade.Text = String.Empty;
        }
        private void Btn2_Limpar_Click(object sender, EventArgs e)
        {
            lvl_ListaNomes.Items.Clear();
        }

        private void TxtB_CaixaNome_TextChanged(object sender, EventArgs e)
        {

        }

        
        
    }
}
