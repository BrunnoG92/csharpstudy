
namespace ComboBox
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
            this.Txt_CaixaNome = new System.Windows.Forms.TextBox();
            this.lbl1_Nome = new System.Windows.Forms.Label();
            this.Cmb_CMBNOMES = new System.Windows.Forms.ComboBox();
            this.lbl2_Nomes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn1_Cadastrar
            // 
            this.Btn1_Cadastrar.Location = new System.Drawing.Point(430, 40);
            this.Btn1_Cadastrar.Name = "Btn1_Cadastrar";
            this.Btn1_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Btn1_Cadastrar.TabIndex = 0;
            this.Btn1_Cadastrar.Text = "Cadastrar";
            this.Btn1_Cadastrar.UseVisualStyleBackColor = true;
            this.Btn1_Cadastrar.Click += new System.EventHandler(this.Btn1_Cadastrar_Click);
            // 
            // Btn2_Limpar
            // 
            this.Btn2_Limpar.Location = new System.Drawing.Point(534, 40);
            this.Btn2_Limpar.Name = "Btn2_Limpar";
            this.Btn2_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn2_Limpar.TabIndex = 1;
            this.Btn2_Limpar.Text = "Limpar";
            this.Btn2_Limpar.UseVisualStyleBackColor = true;
            this.Btn2_Limpar.Click += new System.EventHandler(this.Btn2_Limpar_Click);
            // 
            // Txt_CaixaNome
            // 
            this.Txt_CaixaNome.Location = new System.Drawing.Point(91, 37);
            this.Txt_CaixaNome.Name = "Txt_CaixaNome";
            this.Txt_CaixaNome.Size = new System.Drawing.Size(300, 23);
            this.Txt_CaixaNome.TabIndex = 2;
            // 
            // lbl1_Nome
            // 
            this.lbl1_Nome.AutoSize = true;
            this.lbl1_Nome.Location = new System.Drawing.Point(23, 40);
            this.lbl1_Nome.Name = "lbl1_Nome";
            this.lbl1_Nome.Size = new System.Drawing.Size(43, 15);
            this.lbl1_Nome.TabIndex = 3;
            this.lbl1_Nome.Text = "Nome:";
            // 
            // Cmb_CMBNOMES
            // 
            this.Cmb_CMBNOMES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CMBNOMES.FormattingEnabled = true;
            this.Cmb_CMBNOMES.Items.AddRange(new object[] {
            "Bruno",
            "Fellype",
            "Maria",
            "Caio"});
            this.Cmb_CMBNOMES.Location = new System.Drawing.Point(91, 100);
            this.Cmb_CMBNOMES.Name = "Cmb_CMBNOMES";
            this.Cmb_CMBNOMES.Size = new System.Drawing.Size(300, 23);
            this.Cmb_CMBNOMES.TabIndex = 4;
            this.Cmb_CMBNOMES.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl2_Nomes
            // 
            this.lbl2_Nomes.AutoSize = true;
            this.lbl2_Nomes.Location = new System.Drawing.Point(23, 103);
            this.lbl2_Nomes.Name = "lbl2_Nomes";
            this.lbl2_Nomes.Size = new System.Drawing.Size(48, 15);
            this.lbl2_Nomes.TabIndex = 5;
            this.lbl2_Nomes.Text = "Nomes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 359);
            this.Controls.Add(this.lbl2_Nomes);
            this.Controls.Add(this.Cmb_CMBNOMES);
            this.Controls.Add(this.lbl1_Nome);
            this.Controls.Add(this.Txt_CaixaNome);
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
        private System.Windows.Forms.TextBox Txt_CaixaNome;
        private System.Windows.Forms.Label lbl1_Nome;
        private System.Windows.Forms.ComboBox Cmb_CMBNOMES;
        private System.Windows.Forms.Label lbl2_Nomes;
    }
}

