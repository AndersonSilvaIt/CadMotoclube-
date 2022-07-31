using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroEvento_Core.Data.EF.Repositorios;
using CadastroEvento_Core.Entidades;
using System.IO;

namespace Cadastro_Evento
{
    public partial class GerarEvento : Form
    {
        private EventoList Cadastro = new EventoList();
        private static EventoListRepositorio eventListRep = new EventoListRepositorio();
        private static Motoclube Motoclube;

        public GerarEvento()
        {
            InitializeComponent();
        }

        public GerarEvento(Motoclube mc)
        {
            InitializeComponent();

            lblMc.Text = mc.Desc;
            Motoclube = mc;

            if (mc.ArrayByteImagem != null && mc.ArrayByteImagem.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(mc.ArrayByteImagem))
                {
                    imgBrasao.Visible = true;
                    imgBrasao.Image = Image.FromStream(ms);
                }
            }

        }

        private void GerarEvento_Load(object sender, EventArgs e)
        {
            grdEventoList.DataSource = eventListRep.GetAllEntities();
            grdEventoList.Refresh();
        }
        
        private void btnAddEvent_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAno.Text.Trim()) || string.IsNullOrWhiteSpace(txtNiver.Text.Trim()))
                    throw new ErrorMessageException("Para gerar um novo cadastro é preciso preencher os campos Ano e Idade que o clube está fazendo.");

                int niver = 0;

                if (Int32.TryParse(txtNiver.Text.Trim(), out niver) && niver > 0)
                {
                    Cadastro.Ano = int.Parse(txtAno.Text);
                    Cadastro.Aniversario = niver;
                    Cadastro.Texto = txtNiver.Text + " º Aniversário";
                }
                else
                {
                    txtNiver.Focus();
                    throw new ErrorMessageException("Aniversário inválido.");
                }

                if (eventListRep.VerifyIfExistEventByYear(Cadastro.Ano))
                    throw new ErrorMessageException("Já contém um evento para o ano " + Cadastro.Ano);

                eventListRep.Adicionar(Cadastro);
                //this.Close();
                FormEvento frmEvento = new FormEvento(Cadastro, 1, Motoclube);
                frmEvento.ShowDialog();

                txtAno.Text = "";
                txtNiver.Text = "";

                grdEventoList.DataSource = eventListRep.GetAllEntities();
                grdEventoList.Refresh();

            }
            catch (ErrorMessageException eme)
            {
                MessageBox.Show(eme.Message, "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }

        }

        private void grdEventoList_CellMouseEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 0)
            {
                grdEventoList.Cursor = Cursors.Hand;
                DataGridViewCell cell = grdEventoList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Abrir cadastro";
            }
            else
                grdEventoList.Cursor = Cursors.Default;
        }

        private void grdEventoList_CellMouseLeave_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex != 0)
                grdEventoList.Cursor = Cursors.Default;
        }

        private void grdEventoList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                Cadastro = (EventoList)grdEventoList.SelectedRows[0].DataBoundItem;
                //this.Close();
                Cadastro = eventListRep.FindEventoList(Cadastro.Id);

                FormEvento frmEvento = new FormEvento(Cadastro, 2, Motoclube);
                frmEvento.ShowDialog();
            }
        }

        private void btnCadInitial_Click(object sender, EventArgs e)
        {
            FormInitial frmInitial = new FormInitial(Motoclube);
            frmInitial.ShowDialog();

            lblMc.Text = Motoclube.Desc;
            if (Motoclube.ArrayByteImagem != null && Motoclube.ArrayByteImagem.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(Motoclube.ArrayByteImagem))
                {
                    imgBrasao.Visible = true;
                    imgBrasao.Image = Image.FromStream(ms);
                }
            }

        }
    }
}
