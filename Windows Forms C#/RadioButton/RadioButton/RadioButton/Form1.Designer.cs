
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
            this.rdb_Sim = new System.Windows.Forms.RadioButton();
            this.Rdb2_Nao = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
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
            this.Btn2_Limpar.Click += new System.EventHandler(this.Btn2_Limpar_Click);
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
            // rdb_Sim
            // 
            this.rdb_Sim.AutoSize = true;
            this.rdb_Sim.Location = new System.Drawing.Point(6, 22);
            this.rdb_Sim.Name = "rdb_Sim";
            this.rdb_Sim.Size = new System.Drawing.Size(45, 19);
            this.rdb_Sim.TabIndex = 4;
            this.rdb_Sim.TabStop = true;
            this.rdb_Sim.Text = "Sim";
            this.rdb_Sim.UseVisualStyleBackColor = true;
            this.rdb_Sim.CheckedChanged += new System.EventHandler(this.rdb__CheckedChanged);
            // 
            // Rdb2_Nao
            // 
            this.Rdb2_Nao.AutoSize = true;
            this.Rdb2_Nao.Location = new System.Drawing.Point(6, 47);
            this.Rdb2_Nao.Name = "Rdb2_Nao";
            this.Rdb2_Nao.Size = new System.Drawing.Size(47, 19);
            this.Rdb2_Nao.TabIndex = 5;
            this.Rdb2_Nao.TabStop = true;
            this.Rdb2_Nao.Text = "Não";
            this.Rdb2_Nao.UseVisualStyleBackColor = true;
           
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rdb2_Nao);
            this.groupBox1.Controls.Add(this.rdb_Sim);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 242);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbl1_Nome);
            this.Controls.Add(this.TxtB_Nome);
            this.Controls.Add(this.Btn2_Limpar);
            this.Controls.Add(this.Btn1_Cadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1_Cadastrar;
        private System.Windows.Forms.Button Btn2_Limpar;
        private System.Windows.Forms.TextBox TxtB_Nome;
        private System.Windows.Forms.Label Lbl1_Nome;
        private System.Windows.Forms.RadioButton rdb_Sim;
        private System.Windows.Forms.RadioButton Rdb2_Nao;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

