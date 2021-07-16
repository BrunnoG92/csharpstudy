
namespace Frm_CadPessoas
{
    partial class Frm_CadPessoas
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
            this.Btn_ChamaForm = new System.Windows.Forms.Button();
            this.Lbl1_PlacaNumero = new System.Windows.Forms.Label();
            this.TxtB_PlacaNumero = new System.Windows.Forms.TextBox();
            this.TxtB_Resposta = new System.Windows.Forms.TextBox();
            this.Lbl3_Resposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_ChamaForm
            // 
            this.Btn_ChamaForm.Location = new System.Drawing.Point(83, 159);
            this.Btn_ChamaForm.Name = "Btn_ChamaForm";
            this.Btn_ChamaForm.Size = new System.Drawing.Size(141, 55);
            this.Btn_ChamaForm.TabIndex = 0;
            this.Btn_ChamaForm.Text = "Chamar Formulário";
            this.Btn_ChamaForm.UseVisualStyleBackColor = true;
            this.Btn_ChamaForm.Click += new System.EventHandler(this.Btn_ChamaForm_Click);
            // 
            // Lbl1_PlacaNumero
            // 
            this.Lbl1_PlacaNumero.AutoSize = true;
            this.Lbl1_PlacaNumero.Location = new System.Drawing.Point(12, 40);
            this.Lbl1_PlacaNumero.Name = "Lbl1_PlacaNumero";
            this.Lbl1_PlacaNumero.Size = new System.Drawing.Size(68, 15);
            this.Lbl1_PlacaNumero.TabIndex = 1;
            this.Lbl1_PlacaNumero.Text = "N° da Placa";
            // 
            // TxtB_PlacaNumero
            // 
            this.TxtB_PlacaNumero.Location = new System.Drawing.Point(106, 37);
            this.TxtB_PlacaNumero.Name = "TxtB_PlacaNumero";
            this.TxtB_PlacaNumero.Size = new System.Drawing.Size(100, 23);
            this.TxtB_PlacaNumero.TabIndex = 2;
            // 
            // TxtB_Resposta
            // 
            this.TxtB_Resposta.Location = new System.Drawing.Point(106, 88);
            this.TxtB_Resposta.Name = "TxtB_Resposta";
            this.TxtB_Resposta.Size = new System.Drawing.Size(100, 23);
            this.TxtB_Resposta.TabIndex = 3;
            // 
            // Lbl3_Resposta
            // 
            this.Lbl3_Resposta.AutoSize = true;
            this.Lbl3_Resposta.Location = new System.Drawing.Point(12, 91);
            this.Lbl3_Resposta.Name = "Lbl3_Resposta";
            this.Lbl3_Resposta.Size = new System.Drawing.Size(54, 15);
            this.Lbl3_Resposta.TabIndex = 4;
            this.Lbl3_Resposta.Text = "Resposta";
            // 
            // Frm_CadPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 289);
            this.Controls.Add(this.Lbl3_Resposta);
            this.Controls.Add(this.TxtB_Resposta);
            this.Controls.Add(this.TxtB_PlacaNumero);
            this.Controls.Add(this.Lbl1_PlacaNumero);
            this.Controls.Add(this.Btn_ChamaForm);
            this.Name = "Frm_CadPessoas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_CadPessoas_FormClosed);
            this.Load += new System.EventHandler(this.Frm_CadPessoas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ChamaForm;
        private System.Windows.Forms.Label Lbl1_PlacaNumero;
        private System.Windows.Forms.TextBox TxtB_PlacaNumero;
        private System.Windows.Forms.TextBox TxtB_Resposta;
        private System.Windows.Forms.Label Lbl3_Resposta;
    }
}

