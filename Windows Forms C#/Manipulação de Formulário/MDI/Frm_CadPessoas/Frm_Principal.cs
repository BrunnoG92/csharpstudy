﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Frm_CadPessoas
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_ChamaPessoas_Click(object sender, EventArgs e)
        {
            Frm_CadPessoas Form = new Frm_CadPessoas();
            Form.MdiParent = this;
            Form.Show();
        }

        private void Frm_ChamaVeiculos_Click(object sender, EventArgs e)
        {
            Frm_CadVeiculos Form = new Frm_CadVeiculos();
            Form.MdiParent = this;
            Form.Show();
        }
    }
}
