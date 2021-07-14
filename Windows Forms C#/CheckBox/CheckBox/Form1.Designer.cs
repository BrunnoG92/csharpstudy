
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btn1_cadastro = new System.Windows.Forms.Button();
            this.btn2_Limpar = new System.Windows.Forms.Button();
            this.txtb_CaixaNome = new System.Windows.Forms.TextBox();
            this.lbl1_Nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(11, 136);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(11, 161);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button btn1_cadastro;
        private System.Windows.Forms.Button btn2_Limpar;
        private System.Windows.Forms.TextBox txtb_CaixaNome;
        private System.Windows.Forms.Label lbl1_Nome;
    }
}

