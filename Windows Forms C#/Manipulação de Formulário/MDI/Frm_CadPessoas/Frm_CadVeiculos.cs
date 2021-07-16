using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Frm_CadPessoas
{
    public partial class Frm_CadVeiculos : Form
    {
        public String StrResposta;
        public String StrPlaca;
        public Frm_CadVeiculos()
        {
            InitializeComponent();
        }

        private void Frm_CadVeiculos_Load(object sender, EventArgs e)
        {
            Lbl2_PlacaRecebida.Text = StrPlaca;

        }

        private void Btn2_Resposta_Click(object sender, EventArgs e)
        {
            StrResposta = TxtB2_Resposta.Text.Trim();
        }
    }
}
