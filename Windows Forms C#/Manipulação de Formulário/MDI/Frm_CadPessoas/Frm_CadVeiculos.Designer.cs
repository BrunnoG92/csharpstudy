
namespace Frm_CadPessoas
{
    partial class Frm_CadVeiculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl2_PlacaRecebida = new System.Windows.Forms.Label();
            this.TxtB2_Resposta = new System.Windows.Forms.TextBox();
            this.Btn2_Resposta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl2_PlacaRecebida
            // 
            this.Lbl2_PlacaRecebida.AutoSize = true;
            this.Lbl2_PlacaRecebida.Location = new System.Drawing.Point(103, 89);
            this.Lbl2_PlacaRecebida.Name = "Lbl2_PlacaRecebida";
            this.Lbl2_PlacaRecebida.Size = new System.Drawing.Size(38, 15);
            this.Lbl2_PlacaRecebida.TabIndex = 0;
            this.Lbl2_PlacaRecebida.Text = "label1";
            // 
            // TxtB2_Resposta
            // 
            this.TxtB2_Resposta.Location = new System.Drawing.Point(214, 81);
            this.TxtB2_Resposta.Name = "TxtB2_Resposta";
            this.TxtB2_Resposta.Size = new System.Drawing.Size(100, 23);
            this.TxtB2_Resposta.TabIndex = 1;
            // 
            // Btn2_Resposta
            // 
            this.Btn2_Resposta.Location = new System.Drawing.Point(344, 81);
            this.Btn2_Resposta.Name = "Btn2_Resposta";
            this.Btn2_Resposta.Size = new System.Drawing.Size(75, 23);
            this.Btn2_Resposta.TabIndex = 2;
            this.Btn2_Resposta.Text = "Resposta";
            this.Btn2_Resposta.UseVisualStyleBackColor = true;
            this.Btn2_Resposta.Click += new System.EventHandler(this.Btn2_Resposta_Click);
            // 
            // Frm_CadVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn2_Resposta);
            this.Controls.Add(this.TxtB2_Resposta);
            this.Controls.Add(this.Lbl2_PlacaRecebida);
            this.Name = "Frm_CadVeiculos";
            this.Text = "Frm_CadVeiculos";
            this.Load += new System.EventHandler(this.Frm_CadVeiculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl2_PlacaRecebida;
        private System.Windows.Forms.TextBox TxtB2_Resposta;
        private System.Windows.Forms.Button Btn2_Resposta;
    }
}