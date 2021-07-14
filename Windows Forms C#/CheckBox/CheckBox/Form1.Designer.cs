
namespace CheckBox
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
            this.chk_Exemplo = new System.Windows.Forms.CheckBox();
            this.btn1_cadastro = new System.Windows.Forms.Button();
            this.btn2_Limpar = new System.Windows.Forms.Button();
            this.txtb_CaixaNome = new System.Windows.Forms.TextBox();
            this.lbl1_Nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_Exemplo
            // 
            this.chk_Exemplo.AutoSize = true;
            this.chk_Exemplo.Location = new System.Drawing.Point(13, 65);
            this.chk_Exemplo.Name = "chk_Exemplo";
            this.chk_Exemplo.Size = new System.Drawing.Size(46, 19);
            this.chk_Exemplo.TabIndex = 0;
            this.chk_Exemplo.Text = "Sim";
            this.chk_Exemplo.UseVisualStyleBackColor = true;
            this.chk_Exemplo.CheckStateChanged += new System.EventHandler(this.chk_Exemplo_CheckStateChanged);
            // 
            // btn1_cadastro
            // 
            this.btn1_cadastro.Location = new System.Drawing.Point(274, 24);
            this.btn1_cadastro.Name = "btn1_cadastro";
            this.btn1_cadastro.Size = new System.Drawing.Size(75, 23);
            this.btn1_cadastro.TabIndex = 3;
            this.btn1_cadastro.Text = "Cadastrar";
            this.btn1_cadastro.UseVisualStyleBackColor = true;
            this.btn1_cadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2_Limpar
            // 
            this.btn2_Limpar.Location = new System.Drawing.Point(373, 24);
            this.btn2_Limpar.Name = "btn2_Limpar";
            this.btn2_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn2_Limpar.TabIndex = 4;
            this.btn2_Limpar.Text = "Limpar";
            this.btn2_Limpar.UseVisualStyleBackColor = true;
            this.btn2_Limpar.Click += new System.EventHandler(this.btn2_Limpar_Click);
            // 
            // txtb_CaixaNome
            // 
            this.txtb_CaixaNome.Location = new System.Drawing.Point(11, 25);
            this.txtb_CaixaNome.Name = "txtb_CaixaNome";
            this.txtb_CaixaNome.Size = new System.Drawing.Size(220, 23);
            this.txtb_CaixaNome.TabIndex = 5;
            // 
            // lbl1_Nome
            // 
            this.lbl1_Nome.AutoSize = true;
            this.lbl1_Nome.Location = new System.Drawing.Point(13, 2);
            this.lbl1_Nome.Name = "lbl1_Nome";
            this.lbl1_Nome.Size = new System.Drawing.Size(43, 15);
            this.lbl1_Nome.TabIndex = 6;
            this.lbl1_Nome.Text = "Nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 210);
            this.Controls.Add(this.lbl1_Nome);
            this.Controls.Add(this.txtb_CaixaNome);
            this.Controls.Add(this.btn2_Limpar);
            this.Controls.Add(this.btn1_cadastro);
            this.Controls.Add(this.chk_Exemplo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Exemplo;
        private System.Windows.Forms.Button btn1_cadastro;
        private System.Windows.Forms.Button btn2_Limpar;
        private System.Windows.Forms.TextBox txtb_CaixaNome;
        private System.Windows.Forms.Label lbl1_Nome;
    }
}

