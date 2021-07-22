
namespace ProjetoModulo2
{
    partial class FrmSplitContainer
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
            this.Spc_Container = new System.Windows.Forms.SplitContainer();
            this.Lsb_Imagens = new System.Windows.Forms.ListBox();
            this.Spc_Conteudo = new System.Windows.Forms.SplitContainer();
            this.Lbl_Informacao = new System.Windows.Forms.Label();
            this.Pnl_Image = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Spc_Container)).BeginInit();
            this.Spc_Container.Panel1.SuspendLayout();
            this.Spc_Container.Panel2.SuspendLayout();
            this.Spc_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spc_Conteudo)).BeginInit();
            this.Spc_Conteudo.Panel1.SuspendLayout();
            this.Spc_Conteudo.Panel2.SuspendLayout();
            this.Spc_Conteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spc_Container
            // 
            this.Spc_Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Spc_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spc_Container.Location = new System.Drawing.Point(0, 0);
            this.Spc_Container.Name = "Spc_Container";
            // 
            // Spc_Container.Panel1
            // 
            this.Spc_Container.Panel1.Controls.Add(this.Lsb_Imagens);
            // 
            // Spc_Container.Panel2
            // 
            this.Spc_Container.Panel2.Controls.Add(this.Spc_Conteudo);
            this.Spc_Container.Size = new System.Drawing.Size(800, 450);
            this.Spc_Container.SplitterDistance = 266;
            this.Spc_Container.TabIndex = 0;
            // 
            // Lsb_Imagens
            // 
            this.Lsb_Imagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lsb_Imagens.FormattingEnabled = true;
            this.Lsb_Imagens.ItemHeight = 15;
            this.Lsb_Imagens.Location = new System.Drawing.Point(0, 0);
            this.Lsb_Imagens.Name = "Lsb_Imagens";
            this.Lsb_Imagens.Size = new System.Drawing.Size(264, 448);
            this.Lsb_Imagens.TabIndex = 0;
            this.Lsb_Imagens.SelectedIndexChanged += new System.EventHandler(this.Lsb_Imagens_SelectedIndexChanged);
            // 
            // Spc_Conteudo
            // 
            this.Spc_Conteudo.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.Spc_Conteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spc_Conteudo.Location = new System.Drawing.Point(0, 0);
            this.Spc_Conteudo.Name = "Spc_Conteudo";
            this.Spc_Conteudo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Spc_Conteudo.Panel1
            // 
            this.Spc_Conteudo.Panel1.Controls.Add(this.Lbl_Informacao);
            // 
            // Spc_Conteudo.Panel2
            // 
            this.Spc_Conteudo.Panel2.Controls.Add(this.Pnl_Image);
            this.Spc_Conteudo.Size = new System.Drawing.Size(528, 448);
            this.Spc_Conteudo.SplitterDistance = 212;
            this.Spc_Conteudo.TabIndex = 0;
            // 
            // Lbl_Informacao
            // 
            this.Lbl_Informacao.AutoSize = true;
            this.Lbl_Informacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Informacao.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Informacao.Name = "Lbl_Informacao";
            this.Lbl_Informacao.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Informacao.TabIndex = 0;
            this.Lbl_Informacao.Text = "label1";
            // 
            // Pnl_Image
            // 
            this.Pnl_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pnl_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pnl_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Image.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Image.Name = "Pnl_Image";
            this.Pnl_Image.Size = new System.Drawing.Size(528, 232);
            this.Pnl_Image.TabIndex = 0;
            // 
            // FrmSplitContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Spc_Container);
            this.Name = "FrmSplitContainer";
            this.Text = "FrmSplitContainer";
            this.Load += new System.EventHandler(this.FrmSplitContainer_Load);
            this.Spc_Container.Panel1.ResumeLayout(false);
            this.Spc_Container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Spc_Container)).EndInit();
            this.Spc_Container.ResumeLayout(false);
            this.Spc_Conteudo.Panel1.ResumeLayout(false);
            this.Spc_Conteudo.Panel1.PerformLayout();
            this.Spc_Conteudo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Spc_Conteudo)).EndInit();
            this.Spc_Conteudo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Spc_Container;
        private System.Windows.Forms.SplitContainer Spc_Conteudo;
        private System.Windows.Forms.Label Lbl_Informacao;
        private System.Windows.Forms.Panel Pnl_Image;
        private System.Windows.Forms.ListBox Lsb_Imagens;
    }
}