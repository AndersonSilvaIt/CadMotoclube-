using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CadastroEvento_Core.Entidades;
using CadastroEvento_Core.Data.EF.Repositorios;
using System.Runtime.InteropServices;

namespace Cadastro_Evento
{
    public partial class FormInitial : Form
    {
        private static Motoclube MC;
        public FormInitial()
        {
            InitializeComponent();
        }

        public FormInitial(Motoclube _mc)
        {
            InitializeComponent();
            if (_mc != null)
            {
                MC = _mc;

                txtMotoclube.Text = MC.Desc;
                if (MC.ArrayByteImagem != null && MC.ArrayByteImagem.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(MC.ArrayByteImagem))
                    {
                        imgBrasao.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";

            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string arquivo = openFileDialog1.FileName;

                try
                {
                    string extension = System.IO.Path.GetExtension(arquivo.ToUpper());

                    if (extension != ".PNG" && extension != ".BMP" && extension != ".JPG" && extension != ".GIF" && extension != ".TIFF" && extension != ".JPEG")
                        throw new ErrorMessageException("Formato de imagem não compatível.");

                    using (FileStream fs = new FileStream(arquivo, FileMode.Open, FileAccess.Read))
                    {
                        imgBrasao.Image = Image.FromStream(fs);
                    }

                    imgBrasao.Enabled = true;
                    //btnImgRemove.Visible = true;
                }
                catch (ErrorMessageException eme)
                {
                    MessageBox.Show(eme.Message, "Formato Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void btnSaveMC_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMotoclube.Text.Trim()))
                    throw new ErrorMessageException("Digite o Nome do Motoclube para o Cadastro Inicial.");

                if (MC == null)
                    MC = new Motoclube();

                MC.Desc = txtMotoclube.Text;
                
                if (imgBrasao.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        //Path.GetExtension(CaminhoImagem)

                        imgBrasao.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        MC.ArrayByteImagem = ms.ToArray();
                    }
                }

                if (MC.Id == 0)
                {
                    new MCRepositorio().Adicionar(MC);
                    GerarEvento grdEvento = new GerarEvento(MC);
                    grdEvento.ShowDialog();
                }
                else
                {
                    new MCRepositorio().Atualizar(MC);
                    this.Close();
                }
                
            }
            catch(ErrorMessageException eme)
            {
                MessageBox.Show(eme.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex) { }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
