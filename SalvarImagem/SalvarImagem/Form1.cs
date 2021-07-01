using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalvarImagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            Janela.InitialDirectory = "C://Desktop";
            Janela.Title = "Selecione uma imagem.";
            Janela.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            Janela.FilterIndex = 1;
            try
            {
                if (Janela.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (Janela.CheckFileExists)
                    {
                        string caminhoDaImagem = System.IO.Path.GetFullPath(Janela.FileName);
                        lblCaminhoDaImagem.Text = caminhoDaImagem;
                        picImagem.Image = new Bitmap(Janela.FileName);
                        picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Realize o upload da imagem.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeDoArquivo = System.IO.Path.GetFileName(Janela.FileName);
                if (nomeDoArquivo == null)
                {
                    MessageBox.Show("Por favor selecione uma imagem válida");
                }
                else
                {
                    string caminho = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(Janela.FileName, caminho + "\\img\\" + nomeDoArquivo);
                    MessageBox.Show("Sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Arquivo já existe");
            }
        }
    }
}
