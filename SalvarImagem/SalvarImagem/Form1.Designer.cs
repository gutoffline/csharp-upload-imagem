namespace SalvarImagem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblCaminhoDaImagem = new System.Windows.Forms.Label();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.Janela = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMINHO:";
            // 
            // lblCaminhoDaImagem
            // 
            this.lblCaminhoDaImagem.AutoSize = true;
            this.lblCaminhoDaImagem.Location = new System.Drawing.Point(105, 46);
            this.lblCaminhoDaImagem.Name = "lblCaminhoDaImagem";
            this.lblCaminhoDaImagem.Size = new System.Drawing.Size(125, 13);
            this.lblCaminhoDaImagem.TabIndex = 1;
            this.lblCaminhoDaImagem.Text = "ONDE ESTA A IMAGEM";
            // 
            // btnArquivo
            // 
            this.btnArquivo.Location = new System.Drawing.Point(32, 122);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnArquivo.TabIndex = 2;
            this.btnArquivo.Text = "Arquivo...";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(185, 218);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "UPLOAD";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(304, 71);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(135, 119);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImagem.TabIndex = 4;
            this.picImagem.TabStop = false;
            // 
            // Janela
            // 
            this.Janela.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 330);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.lblCaminhoDaImagem);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCaminhoDaImagem;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.OpenFileDialog Janela;
    }
}

