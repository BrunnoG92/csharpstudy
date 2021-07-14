
namespace ProjetoModulo1
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
            this.btnBotao1 = new System.Windows.Forms.Button();
            this.btnBotao2 = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lsbListaNomes = new System.Windows.Forms.ListBox();
            this.lblListaNomes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBotao1
            // 
            this.btnBotao1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBotao1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBotao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotao1.Location = new System.Drawing.Point(286, 36);
            this.btnBotao1.Name = "btnBotao1";
            this.btnBotao1.Size = new System.Drawing.Size(95, 24);
            this.btnBotao1.TabIndex = 0;
            this.btnBotao1.Text = "Cadastrar";
            this.btnBotao1.UseVisualStyleBackColor = false;
            this.btnBotao1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnBotao2
            // 
            this.btnBotao2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotao2.Location = new System.Drawing.Point(411, 36);
            this.btnBotao2.Name = "btnBotao2";
            this.btnBotao2.Size = new System.Drawing.Size(92, 24);
            this.btnBotao2.TabIndex = 1;
            this.btnBotao2.Text = "Limpar";
            this.btnBotao2.UseVisualStyleBackColor = true;
            this.btnBotao2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(12, 36);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(238, 23);
            this.txtNome.TabIndex = 3;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // lsbListaNomes
            // 
            this.lsbListaNomes.FormattingEnabled = true;
            this.lsbListaNomes.ItemHeight = 15;
            this.lsbListaNomes.Location = new System.Drawing.Point(12, 106);
            this.lsbListaNomes.Name = "lsbListaNomes";
            this.lsbListaNomes.Size = new System.Drawing.Size(238, 94);
            this.lsbListaNomes.TabIndex = 4;
            this.lsbListaNomes.DoubleClick += new System.EventHandler(this.lsbListaNomes_DoubleClick);
            // 
            // lblListaNomes
            // 
            this.lblListaNomes.AutoSize = true;
            this.lblListaNomes.Location = new System.Drawing.Point(13, 75);
            this.lblListaNomes.Name = "lblListaNomes";
            this.lblListaNomes.Size = new System.Drawing.Size(88, 15);
            this.lblListaNomes.TabIndex = 5;
            this.lblListaNomes.Text = "Lista de Nomes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 210);
            this.Controls.Add(this.lblListaNomes);
            this.Controls.Add(this.lsbListaNomes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnBotao2);
            this.Controls.Add(this.btnBotao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBotao1;
        private System.Windows.Forms.Button btnBotao2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox lsbListaNomes;
        private System.Windows.Forms.Label lblListaNomes;
    }
}

