using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo1
{
    public partial class Form1 : Form
    {
        private int iSelecionado;
        public Form1()
        {
            iSelecionado = -1;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (iSelecionado > -1) // se posição valida , editar o texto selecionado
            {
                lsbListaNomes.Items[iSelecionado] = txtNome.Text;
                Ordenar(); // chamada da ordenação após a edição do nome
                Button2_Click(btnBotao2, new EventArgs());
                iSelecionado = -1;
                btnBotao1.Text = "Cadastrar";
                return;
            }
            lsbListaNomes.Items.Add(txtNome.Text);
            Ordenar(); //chamada da ordenação, após a inserção do nome
            Button2_Click(btnBotao2, new EventArgs());
        }
        private void  Ordenar()
        {
            ListBox.ObjectCollection lista = lsbListaNomes.Items; // salvo todo o list box na variavel lista
            List<String> listastring = new List<String>(); // recebe o texto da listbox, pecorrendo a lista e salvando em string
            foreach (var item in lista)
            {
                listastring.Add(item.ToString());
            }
            listastring = (from S in listastring select S).OrderBy( x=> x).ToList(); // ordenação com lambda / linq
            lsbListaNomes.Items.Clear();

            foreach (var item in listastring)
            {
                lsbListaNomes.Items.Add(item);
            }
        }
        private void Button2_Click(object sender, EventArgs e)

        {
            txtNome.Text = String.Empty;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                Button1_Click(btnBotao1, new EventArgs());
            }
        }

        private void lsbListaNomes_DoubleClick(object sender, EventArgs e)
        {   
            iSelecionado = lsbListaNomes.SelectedIndex; //salva a posição do nome na lista
            txtNome.Text = lsbListaNomes.Items[iSelecionado].ToString(); // clique duplo para selecionar o nome na lista para a text box
            btnBotao1.Text = "Editar"; // troco o nome do botão

        }
    }
}
