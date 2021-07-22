using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoModulo2
{
    public partial class FrmSplitContainer : Form
    {
        public FrmSplitContainer()
        {
            InitializeComponent();
        }

        private void FrmSplitContainer_Load(object sender, EventArgs e)
        {
            Lsb_Imagens.Items.Add("Chapolim");
            Lsb_Imagens.Items.Add("Chaves");
            Lsb_Imagens.Items.Add("Chompiras");
        }

        private void Lsb_Imagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lsb_Imagens.SelectedIndices.Count < 1) // há algum item selecionado ?
            {
                return;
            }
            if (Lsb_Imagens.SelectedIndex == 0)
            {
                Lbl_Informacao.Text = ("CHAPOLIN COLOURADO");
                Pnl_Image.BackgroundImage = Properties.Resources.Chapolim;
            }
            else if (Lsb_Imagens.SelectedIndex == 1)
            {
                Lbl_Informacao.Text = ("CHAVES");
                Pnl_Image.BackgroundImage = Properties.Resources.Chaves;
            }
            else if (Lsb_Imagens.SelectedIndex == 2)
            {
                Lbl_Informacao.Text = ("CHOMPIRAS");
                Pnl_Image.BackgroundImage = Properties.Resources.Chompiras;
            }
        }
    }
}
