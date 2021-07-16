
namespace ListView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn1_Cadastrar = new System.Windows.Forms.Button();
            this.Btn2_Limpar = new System.Windows.Forms.Button();
            this.Lbl1_Nome = new System.Windows.Forms.Label();
            this.TxtB_CaixaNome = new System.Windows.Forms.TextBox();
            this.lvl_ListaNomes = new System.Windows.Forms.ListView();
            this.TxtB_CaixaIdade = new System.Windows.Forms.TextBox();
            this.Lbl_Idade = new System.Windows.Forms.Label();
            this.Btn3_BotaoRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn1_Cadastrar
            // 
            this.Btn1_Cadastrar.Location = new System.Drawing.Point(411, 15);
            this.Btn1_Cadastrar.Name = "Btn1_Cadastrar";
            this.Btn1_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Btn1_Cadastrar.TabIndex = 0;
            this.Btn1_Cadastrar.Text = "Cadastrar";
            this.Btn1_Cadastrar.UseVisualStyleBackColor = true;
            this.Btn1_Cadastrar.Click += new System.EventHandler(this.Btn1_Cadastrar_Click);
            // 
            // Btn2_Limpar
            // 
            this.Btn2_Limpar.Location = new System.Drawing.Point(492, 15);
            this.Btn2_Limpar.Name = "Btn2_Limpar";
            this.Btn2_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn2_Limpar.TabIndex = 1;
            this.Btn2_Limpar.Text = "Limpar";
            this.Btn2_Limpar.UseVisualStyleBackColor = true;
            this.Btn2_Limpar.Click += new System.EventHandler(this.Btn2_Limpar_Click);
            // 
            // Lbl1_Nome
            // 
            this.Lbl1_Nome.AutoSize = true;
            this.Lbl1_Nome.Location = new System.Drawing.Point(12, 18);
            this.Lbl1_Nome.Name = "Lbl1_Nome";
            this.Lbl1_Nome.Size = new System.Drawing.Size(43, 15);
            this.Lbl1_Nome.TabIndex = 2;
            this.Lbl1_Nome.Text = "Nome:";
            // 
            // TxtB_CaixaNome
            // 
            this.TxtB_CaixaNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtB_CaixaNome.Location = new System.Drawing.Point(61, 15);
            this.TxtB_CaixaNome.Name = "TxtB_CaixaNome";
            this.TxtB_CaixaNome.Size = new System.Drawing.Size(191, 23);
            this.TxtB_CaixaNome.TabIndex = 3;
            this.TxtB_CaixaNome.TextChanged += new System.EventHandler(this.TxtB_CaixaNome_TextChanged);
            this.TxtB_CaixaNome.Validating += new System.ComponentModel.CancelEventHandler(this.TxtB_CaixaNome_Validating);
            // 
            // lvl_ListaNomes
            // 
            this.lvl_ListaNomes.AllowColumnReorder = true;
            this.lvl_ListaNomes.FullRowSelect = true;
            this.lvl_ListaNomes.HideSelection = false;
            this.lvl_ListaNomes.Location = new System.Drawing.Point(21, 82);
            this.lvl_ListaNomes.MultiSelect = false;
            this.lvl_ListaNomes.Name = "lvl_ListaNomes";
            this.lvl_ListaNomes.Size = new System.Drawing.Size(506, 129);
            this.lvl_ListaNomes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvl_ListaNomes.TabIndex = 4;
            this.lvl_ListaNomes.UseCompatibleStateImageBehavior = false;
            this.lvl_ListaNomes.View = System.Windows.Forms.View.Details;
            this.lvl_ListaNomes.DoubleClick += new System.EventHandler(this.lvl_ListaNomes_DoubleClick);
            // 
            // TxtB_CaixaIdade
            // 
            this.TxtB_CaixaIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtB_CaixaIdade.Location = new System.Drawing.Point(327, 15);
            this.TxtB_CaixaIdade.Name = "TxtB_CaixaIdade";
            this.TxtB_CaixaIdade.Size = new System.Drawing.Size(56, 23);
            this.TxtB_CaixaIdade.TabIndex = 6;
            this.TxtB_CaixaIdade.Validating += new System.ComponentModel.CancelEventHandler(this.TxtB_CaixaIdade_Validating);
            // 
            // Lbl_Idade
            // 
            this.Lbl_Idade.AutoSize = true;
            this.Lbl_Idade.Location = new System.Drawing.Point(271, 15);
            this.Lbl_Idade.Name = "Lbl_Idade";
            this.Lbl_Idade.Size = new System.Drawing.Size(39, 15);
            this.Lbl_Idade.TabIndex = 5;
            this.Lbl_Idade.Text = "Idade:";
            // 
            // Btn3_BotaoRemover
            // 
            this.Btn3_BotaoRemover.Image = global::ListView.Properties.Resources.icone_remover;
            this.Btn3_BotaoRemover.Location = new System.Drawing.Point(551, 231);
            this.Btn3_BotaoRemover.Name = "Btn3_BotaoRemover";
            this.Btn3_BotaoRemover.Size = new System.Drawing.Size(29, 29);
            this.Btn3_BotaoRemover.TabIndex = 7;
            this.Btn3_BotaoRemover.UseVisualStyleBackColor = true;
            this.Btn3_BotaoRemover.Click += new System.EventHandler(this.Btn3_BotaoRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 272);
            this.Controls.Add(this.Btn3_BotaoRemover);
            this.Controls.Add(this.TxtB_CaixaIdade);
            this.Controls.Add(this.Lbl_Idade);
            this.Controls.Add(this.lvl_ListaNomes);
            this.Controls.Add(this.TxtB_CaixaNome);
            this.Controls.Add(this.Lbl1_Nome);
            this.Controls.Add(this.Btn2_Limpar);
            this.Controls.Add(this.Btn1_Cadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1_Cadastrar;
        private System.Windows.Forms.Button Btn2_Limpar;
        private System.Windows.Forms.Label Lbl1_Nome;
        private System.Windows.Forms.TextBox TxtB_CaixaNome;
        private System.Windows.Forms.ListView lvl_ListaNomes;
        private System.Windows.Forms.TextBox TxtB_CaixaIdade;
        private System.Windows.Forms.Label Lbl_Idade;
        private System.Windows.Forms.Button Btn3_BotaoRemover;
    }
}

