
namespace RadioButton
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
            this.TxtB_Nome = new System.Windows.Forms.TextBox();
            this.Lbl1_Nome = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Btn1_Cadastrar
            // 
            this.Btn1_Cadastrar.Location = new System.Drawing.Point(238, 45);
            this.Btn1_Cadastrar.Name = "Btn1_Cadastrar";
            this.Btn1_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Btn1_Cadastrar.TabIndex = 0;
            this.Btn1_Cadastrar.Text = "Cadastrar";
            this.Btn1_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // Btn2_Limpar
            // 
            this.Btn2_Limpar.Location = new System.Drawing.Point(331, 46);
            this.Btn2_Limpar.Name = "Btn2_Limpar";
            this.Btn2_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn2_Limpar.TabIndex = 1;
            this.Btn2_Limpar.Text = "Limpar";
            this.Btn2_Limpar.UseVisualStyleBackColor = true;
            // 
            // TxtB_Nome
            // 
            this.TxtB_Nome.Location = new System.Drawing.Point(12, 46);
            this.TxtB_Nome.Name = "TxtB_Nome";
            this.TxtB_Nome.Size = new System.Drawing.Size(198, 23);
            this.TxtB_Nome.TabIndex = 2;
            // 
            // Lbl1_Nome
            // 
            this.Lbl1_Nome.AutoSize = true;
            this.Lbl1_Nome.Location = new System.Drawing.Point(12, 9);
            this.Lbl1_Nome.Name = "Lbl1_Nome";
            this.Lbl1_Nome.Size = new System.Drawing.Size(43, 15);
            this.Lbl1_Nome.TabIndex = 3;
            this.Lbl1_Nome.Text = "Nome:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 99);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 241);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Lbl1_Nome);
            this.Controls.Add(this.TxtB_Nome);
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
        private System.Windows.Forms.TextBox TxtB_Nome;
        private System.Windows.Forms.Label Lbl1_Nome;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

