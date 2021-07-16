
namespace Frm_CadPessoas
{
    partial class Frm_Principal
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
            this.Btn_ChamaPessoas = new System.Windows.Forms.Button();
            this.Frm_ChamaVeiculos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_ChamaPessoas
            // 
            this.Btn_ChamaPessoas.Location = new System.Drawing.Point(48, 61);
            this.Btn_ChamaPessoas.Name = "Btn_ChamaPessoas";
            this.Btn_ChamaPessoas.Size = new System.Drawing.Size(122, 23);
            this.Btn_ChamaPessoas.TabIndex = 1;
            this.Btn_ChamaPessoas.Text = "Chama Pessoas";
            this.Btn_ChamaPessoas.UseVisualStyleBackColor = true;
            this.Btn_ChamaPessoas.Click += new System.EventHandler(this.Btn_ChamaPessoas_Click);
            // 
            // Frm_ChamaVeiculos
            // 
            this.Frm_ChamaVeiculos.Location = new System.Drawing.Point(48, 118);
            this.Frm_ChamaVeiculos.Name = "Frm_ChamaVeiculos";
            this.Frm_ChamaVeiculos.Size = new System.Drawing.Size(122, 23);
            this.Frm_ChamaVeiculos.TabIndex = 2;
            this.Frm_ChamaVeiculos.Text = "Chama Veiculos";
            this.Frm_ChamaVeiculos.UseVisualStyleBackColor = true;
            this.Frm_ChamaVeiculos.Click += new System.EventHandler(this.Frm_ChamaVeiculos_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Frm_ChamaVeiculos);
            this.Controls.Add(this.Btn_ChamaPessoas);
            this.IsMdiContainer = true;
            this.Name = "Frm_Principal";
            this.Text = "Frm_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ChamaPessoas;
        private System.Windows.Forms.Button Frm_ChamaVeiculos;
    }
}