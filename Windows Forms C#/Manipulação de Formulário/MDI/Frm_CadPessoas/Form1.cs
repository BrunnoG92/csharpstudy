using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_CadPessoas
{
    public partial class Frm_CadPessoas : Form
    {
        public Frm_CadPessoas()
        {
            InitializeComponent();
        }

        private void Frm_CadPessoas_Load(object sender, EventArgs e)
        {
            Text = "Novo Titulo";
        }

        private void Frm_CadPessoas_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Btn_ChamaForm_Click(object sender, EventArgs e)
        {   

            Frm_CadVeiculos Form = new Frm_CadVeiculos(); // Instanciado o segundo formulário
            Form.StrPlaca = TxtB_PlacaNumero.Text.Trim();
            Form.Text = "Cadastro de Veiculos";
            Form.StartPosition = FormStartPosition.CenterScreen;
            Form.Location = new Point(0, 0);
            Form.ShowDialog(); // Chama o segundo formulário
            TxtB_Resposta.Text = Form.StrResposta;

        }
    }
}
