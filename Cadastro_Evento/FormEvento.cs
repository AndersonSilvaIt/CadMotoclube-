using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CadastroEvento_Core.Data.EF.Repositorios;
using CadastroEvento_Core.Entidades;
using System.Linq;

namespace Cadastro_Evento
{
    public partial class FormEvento : Form
    {
        private IList<Evento> ListEvento { get; set; }
        private static EventoList CadastroEvento;
        private Evento CadEvento { get; set; }
        private static EventoRepositorio eventRep = new EventoRepositorio();
        private static int TypeMode;

        public FormEvento()
        {
            InitializeComponent();
        }

        private void FormEvento_Load(object sender, EventArgs e)
        {
            AtualizaForm();
        }
        

        public FormEvento(EventoList listEvento, int _typeMode, Motoclube mc)
        {
            InitializeComponent();
            this.Text = "Cadastro do Evento    -   " + listEvento.Ano + "    " + listEvento.Texto;
            lblDesc.Text = string.Format("{2}     {0}    -    {1}  º  Aniversário", listEvento.Ano, listEvento.Aniversario, mc.Desc);
            timer1_Tick_1(null, null);

            TypeMode = _typeMode;

            grdEvento.DataSource = listEvento.Eventos;
            grdEvento.Refresh();

            CadastroEvento = listEvento;

            this.CadEvento = new Evento();
            BlockFields(groupMotoclube);
        }

        private void btnAddMC_Click(object sender, EventArgs e)
        {
            UnlockFields(groupMotoclube);
            ClearFields(groupMotoclube);
            txtData.Enabled = false;

            btnAddMC.Visible = false;
            btnSaveMC.Visible = true;
            btnCancel.Visible = true;
            btnDel.Visible = false;
            btnUpdate.Visible = false;
            txtData.Text = DateTime.Now.ToString();
            ddlUF.DataSource = DirtyDdlUF();
            ddlUF.Refresh();
            TypeMode = 1; //1 - Inclusão
            txtMotoclube.Focus();
            ddlTrofeu.Items.Clear();
            ddlTrofeu.Items.Add("");
            ddlTrofeu.Items.Add("Entregue");
            ddlTrofeu.Items.Add("Pendente");
            toolTip1.SetToolTip(btnCancel, "Cancelar Cadastro");
        }

        private void btnSaveMC_Click(object sender, EventArgs e)
        {
            getFields(CadEvento);
            if (string.IsNullOrWhiteSpace(txtMotoclube.Text))
            {
                txtMotoclube.Focus();
                MessageBox.Show("Campo Motoclube é obrigatório.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TypeMode == 1)
            {
                eventRep.Adicionar(CadEvento);
                if (CadastroEvento.Eventos == null)
                    CadastroEvento.Eventos = new List<Evento>();
                CadastroEvento.Eventos.Add(CadEvento);
                AtualizaForm();
                btnAddMC.Visible = true;
                btnSaveMC.Visible = false;
                btnCancel.Visible = false;
            }
            else
            {
                if (CadEvento != null)
                {
                    eventRep.Atualizar(CadEvento);
                    AtualizaForm();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TypeMode = 2; // Alteração
            btnAddMC.Visible = false;
            btnSaveMC.Visible = true;
            btnUpdate.Visible = false;
            btnDel.Visible = false;
            btnCancel.Visible = true;
            toolTip1.SetToolTip(btnCancel, "Cancelar Alteração");
            UnlockFields(groupMotoclube);
            txtData.Enabled = false;
            toolTip1.SetToolTip(btnCancel, "Cancelar Alteração");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (TypeMode == 1)
            {
                btnAddMC.Visible = true;
                btnCancel.Visible = false;
                btnSaveMC.Visible = false;
                ClearFields(groupMotoclube);
                BlockFields(groupMotoclube);
            }
            else if (TypeMode == 2)
            {
                btnSaveMC.Visible = false;
                btnAddMC.Visible = true;
                btnCancel.Visible = false;
                btnDel.Visible = true;
                btnUpdate.Visible = true;
                BlockFields(groupMotoclube);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            TypeMode = 3;
            string msg = "Cofirma exclusão do Clube? " + CadEvento.Motoclube;

            var result = MessageBox.Show(msg, "Excluir Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                eventRep.Excluir(CadEvento);
                AtualizaForm();
            }

        }

        private void AtualizaForm()
        {
            ListEvento = eventRep.GetEventosByEventosListId(CadastroEvento.Id);
            grdEvento.DataSource = ListEvento;
            grdEvento.Refresh();

            ddlUfSearch.DataSource = DirtyDdlUF();
            ddlUfSearch.Refresh();

            ClearFields(groupMotoclube);
            BlockFields(groupMotoclube);
            btnUpdate.Visible = false;
            btnDel.Visible = false;
            btnCancel.Visible = false;
            btnSaveMC.Visible = false;
            ddlUF.Text = string.Empty;
            btnAddMC.Visible = true;

            int qtd = grdEvento.Rows.Count;
            if (qtd == 0 || qtd == 1)
                lblCountMC.Text = qtd + " Motoclube cadastrado";
            else
                lblCountMC.Text = qtd + " Motoclubes cadastrados";

            ddlTrofeu.Items.Clear();
        }

        private void DirtyFields(Evento evento)
        {
            if (evento != null)
            {
                txtMotoclube.Text = evento.Motoclube;
                txtMember.Text = evento.Membro;
                txtPresidente.Text = evento.Presidente;
                txtRua.Text = evento.Logradouro;
                txtCEP.Text = evento.CEP;
                txtFone.Text = evento.Fone;
                txtCell.Text = evento.Celular;
                txtEmail.Text = evento.Email;
                txtCity.Text = evento.Cidade;
                txtNumber.Text = evento.Numero;
                ddlUF.DataSource = DirtyDdlUF();
                ddlUF.Refresh();

                txtData.Text = evento.DataCadastro.ToString("dd/MM/yyyy HH:mm:ss");

                if (!string.IsNullOrWhiteSpace(evento.UF))
                    ddlUF.SelectedItem = evento.UF;

                ddlTrofeu.Items.Clear();
                ddlTrofeu.Items.Add("");
                ddlTrofeu.Items.Add("Entregue");
                ddlTrofeu.Items.Add("Pendente");

                if (!string.IsNullOrWhiteSpace(evento.Trofeu))
                    ddlTrofeu.SelectedItem = evento.Trofeu;
            }
        }

        private void imgSearch_Click(object sender, EventArgs e)
        {
            string uf = ddlUfSearch.Text;
            string trofeu = ddlTrofeuSearch.Text;


            grdEvento.DataSource = eventRep.SearchEvento(txtMCSearch.Text,
                                                        txtPresidenteSearch.Text, txtCitySearch.Text,
                                                         txtMemberSearch.Text, uf, trofeu, CadastroEvento.Id);
            grdEvento.Refresh();

            lblCountMC.Text = grdEvento.Rows.Count + " Motoclubes Cadastrados.";
        }

        private void imgUpdate_Click(object sender, EventArgs e)
        {
            ClearFields(groupSearchMember);
            ddlTrofeuSearch.Items.Clear();

            ddlTrofeuSearch.Items.Add("");
            ddlTrofeuSearch.Items.Add("Entregue");
            ddlTrofeuSearch.Items.Add("Pendente");

            grdEvento.DataSource = ListEvento;
            grdEvento.Refresh();
        }

        public static void ClearFields(Control controls)
        {
            foreach (Control ctr in controls.Controls)
            {
                if (ctr is ComboBox)
                {
                    ((ComboBox)ctr).Text = string.Empty;
                }

                if (ctr is TextBox)
                    ((TextBox)ctr).Text = string.Empty;

                if (ctr is MaskedTextBox)
                    ((MaskedTextBox)ctr).Text = string.Empty;

                if (ctr is CheckBox)
                    ((CheckBox)ctr).Checked = false;

                if (ctr is TabControl)
                {
                    foreach (Control ctrTab in ctr.Controls)
                    {
                        if (ctrTab is TabPage)
                        {
                            foreach (Control ctrTabPage in ctrTab.Controls)
                            {
                                if (ctrTabPage is GroupBox)
                                {
                                    foreach (Control ctrGroup in ctrTabPage.Controls)
                                    {
                                        if (ctrGroup is TextBox)
                                            ((TextBox)ctrGroup).Text = string.Empty;

                                        if (ctrGroup is MaskedTextBox)
                                            ((MaskedTextBox)ctrGroup).Clear();
                                    }
                                }

                                if (ctrTabPage is TextBox)
                                    ((TextBox)ctrTabPage).Text = string.Empty;

                                if (ctrTabPage is MaskedTextBox)
                                    ((MaskedTextBox)ctrTabPage).Text = string.Empty;

                            }
                        }
                    }
                }

                if (ctr is GroupBox)
                {
                    foreach (Control ctrGroup in ctr.Controls)
                    {
                        if (ctrGroup is TextBox)
                            ((TextBox)ctrGroup).Text = string.Empty;

                        if (ctrGroup is MaskedTextBox)
                            ((MaskedTextBox)ctrGroup).Text = string.Empty;

                        if (ctrGroup is ComboBox)
                        {
                            ((ComboBox)ctrGroup).Text = string.Empty;
                        }
                    }
                }

                if (ctr is Panel)
                {
                    foreach (Control ctrPanel in ctr.Controls)
                    {
                        if (ctrPanel is TextBox)
                            ((TextBox)ctrPanel).Text = string.Empty;

                        if (ctrPanel is MaskedTextBox)
                            ((MaskedTextBox)ctrPanel).Text = string.Empty;
                    }
                }

            }
        }

        public static void BlockFields(Control controls)
        {
            if (controls is Panel)
            {
                foreach (Control ctrPanel in controls.Controls)
                {
                    if (ctrPanel is GroupBox)
                    {
                        foreach (Control ctrGroup in ctrPanel.Controls)
                        {
                            if (ctrGroup is TextBox)
                                ((TextBox)ctrGroup).Enabled = false;

                            if (ctrGroup is MaskedTextBox)
                                ((MaskedTextBox)ctrGroup).Enabled = false;

                            if (ctrGroup is ComboBox)
                                ((ComboBox)ctrGroup).Enabled = false;

                            if (ctrGroup is CheckBox)
                                ((CheckBox)ctrGroup).Enabled = false;

                            if (ctrGroup is RadioButton)
                                ((RadioButton)ctrGroup).Enabled = false;

                            //if (ctrGroup is PictureBox)
                            //((PictureBox)ctrGroup).Enabled = false;
                        }
                    }

                    if (ctrPanel is TextBox)
                        ((TextBox)ctrPanel).Enabled = false;

                    if (ctrPanel is MaskedTextBox)
                        ((MaskedTextBox)ctrPanel).Enabled = false;

                    if (ctrPanel is ComboBox)
                        ((ComboBox)ctrPanel).Enabled = false;

                    if (ctrPanel is RadioButton)
                        ((RadioButton)ctrPanel).Enabled = false;

                    //if (ctrPanel is PictureBox)
                    //((PictureBox)ctrPanel).Enabled = false;

                }
            }
            else if (controls is GroupBox)
            {
                foreach (Control ctrGroup in controls.Controls)
                {
                    if (ctrGroup is TextBox)
                        ((TextBox)ctrGroup).Enabled = false;

                    if (ctrGroup is MaskedTextBox)
                        ((MaskedTextBox)ctrGroup).Enabled = false;

                    if (ctrGroup is ComboBox)
                        ((ComboBox)ctrGroup).Enabled = false;

                    if (ctrGroup is CheckBox)
                    {
                        ((CheckBox)ctrGroup).Checked = false;
                        ((CheckBox)ctrGroup).Enabled = false;
                    }

                    if (ctrGroup is RadioButton)
                        ((RadioButton)ctrGroup).Enabled = false;

                    //if (ctrGroup is PictureBox)
                    //  ((PictureBox)ctrGroup).Enabled = false;

                }
            }
            else if (controls is TabPage)
            {
                foreach (Control ctrTabPage in controls.Controls)
                {
                    if (ctrTabPage is TextBox)
                        ((TextBox)ctrTabPage).Enabled = false;

                    if (ctrTabPage is MaskedTextBox)
                        ((MaskedTextBox)ctrTabPage).Enabled = false;

                    if (ctrTabPage is ComboBox)
                        ((ComboBox)ctrTabPage).Enabled = false;

                    if (ctrTabPage is CheckBox)
                    {
                        ((CheckBox)ctrTabPage).Checked = false;
                        ((CheckBox)ctrTabPage).Enabled = false;
                    }

                    if (ctrTabPage is RadioButton)
                        ((RadioButton)ctrTabPage).Enabled = false;

                    //if (ctrTabPage is PictureBox)
                    //  ((PictureBox)ctrTabPage).Enabled = false;

                }
            }
        }

        public static void UnlockFields(Control controls)
        {
            if (controls is Panel)
            {
                foreach (Control ctrPanel in controls.Controls)
                {
                    if (ctrPanel is GroupBox)
                    {
                        foreach(Control ctrGroup in ctrPanel.Controls)
                        {
                            if (ctrGroup is TextBox)
                                ((TextBox)ctrGroup).Enabled = true;

                            if (ctrGroup is MaskedTextBox)
                                ((MaskedTextBox)ctrGroup).Enabled = true;

                            if (ctrGroup is ComboBox)
                                ((ComboBox)ctrGroup).Enabled = true;

                            if (ctrGroup is RadioButton)
                                ((RadioButton)ctrGroup).Enabled = true;

                            if (ctrGroup is PictureBox && ((PictureBox)ctrGroup).Name == "btnChooseImg")
                              ((PictureBox)ctrGroup).Visible = true;

                            if (ctrGroup is Button && ((Button)ctrGroup).Name == "btnChooseImg")
                            {
                                ((Button)ctrGroup).Visible = true;
                                ((Button)ctrGroup).Enabled = true;
                            }


                            //    if (ctrGroup is PictureBox)
                            //      ((PictureBox)ctrGroup).Enabled = true;
                        }
                    }

                    if (ctrPanel is TextBox)
                        ((TextBox)ctrPanel).Enabled = true;

                    if (ctrPanel is MaskedTextBox)
                        ((MaskedTextBox)ctrPanel).Enabled = true;

                    if (ctrPanel is ComboBox)
                        ((ComboBox)ctrPanel).Enabled = true;

                    if (ctrPanel is RadioButton)
                        ((RadioButton)ctrPanel).Enabled = true;

                    if (ctrPanel is PictureBox && ((PictureBox)ctrPanel).Name == "btnChooseImg")
                        ((PictureBox)ctrPanel).Visible = true;

                    if (ctrPanel is Button && ((Button)ctrPanel).Name == "btnChooseImg")
                        ((Button)ctrPanel).Visible = true;

                    if (ctrPanel is Button && ((Button)ctrPanel).Name == "btnChooseImg")
                    {
                        ((Button)ctrPanel).Visible = true;
                        ((Button)ctrPanel).Enabled = true;
                    }
                    //if (ctrPanel is PictureBox)
                    //  ((PictureBox)ctrPanel).Enabled = true;
                }
            }
            if (controls is GroupBox)
            {
                foreach (Control ctrGroup in controls.Controls)
                {
                    if (ctrGroup is TextBox)
                        ((TextBox)ctrGroup).Enabled = true;

                    if (ctrGroup is MaskedTextBox)
                        ((MaskedTextBox)ctrGroup).Enabled = true;

                    if (ctrGroup is ComboBox)
                        ((ComboBox)ctrGroup).Enabled = true;

                    if (ctrGroup is CheckBox)
                        ((CheckBox)ctrGroup).Enabled = true;

                    if (ctrGroup is RadioButton)
                        ((RadioButton)ctrGroup).Enabled = true;

                    if (ctrGroup is PictureBox && ((PictureBox)ctrGroup).Name == "btnChooseImg")
                        ((PictureBox)ctrGroup).Visible = true;

                    if (ctrGroup is Button && ((Button)ctrGroup).Name == "btnChooseImg")
                    {
                        ((Button)ctrGroup).Visible = true;
                        ((Button)ctrGroup).Enabled = true;
                    }

                    //if (ctrGroup is PictureBox)
                    //  ((PictureBox)ctrGroup).Enabled = true;
                }
            }
        }

        public List<string> DirtyDdlUF()
        {
            string estados = ("AC - AL - AP - AM - BA - CE - DF - ES - GO - MA - MT - MS - MG - PA - PB - PR - PE - PI - RJ - RN - RS - RO - RR - SC - SP - SE - TO");
            List<string> listEstados = new List<string>();

            listEstados.Add("");

            foreach (string uf in estados.Split('-'))
            {
                listEstados.Add(uf.Trim());
            }

            return listEstados;
        }

        private void getFields(Evento evento)
        {
            evento.Motoclube = txtMotoclube.Text;
            evento.Membro = txtMember.Text;
            evento.Presidente = txtPresidente.Text;
            evento.Logradouro = txtRua.Text;
            evento.Numero = txtNumber.Text;
            evento.Cidade = txtCity.Text;
            evento.UF = ddlUF.SelectedValue.ToString();
            evento.CEP = txtCEP.Text;
            evento.Fone = txtFone.Text;
            evento.Celular = txtCell.Text;
            evento.Email = txtEmail.Text;
            evento.Trofeu = ddlTrofeu.Text;
            evento.EventoListId = CadastroEvento.Id;
            evento.DataCadastro = Convert.ToDateTime(txtData.Text);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void grdEvento_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexColum = e.ColumnIndex;

            if (indexColum > 0)
            {
                List<Evento> eventoOrder = (List<Evento>)grdEvento.DataSource;
                switch (indexColum)
                {
                    case 1:
                        eventoOrder = eventoOrder.OrderBy(p => p.Motoclube).ToList();
                        break;

                    case 2:
                        eventoOrder = eventoOrder.OrderBy(p => p.Membro).ToList();
                        break;

                    case 3:
                        eventoOrder = eventoOrder.OrderBy(p => p.Presidente).ToList();
                        break;

                    case 6:
                        eventoOrder = eventoOrder.OrderBy(p => p.Cidade).ToList();
                        break;

                    case 7:
                        eventoOrder = eventoOrder.OrderBy(p => p.UF).ToList();
                        break;

                    case 13:
                        eventoOrder = eventoOrder.OrderBy(p => p.Trofeu).ToList();
                        break;

                    default:
                        break;
                }

                grdEvento.DataSource = eventoOrder;
                grdEvento.Refresh();
            }

        }

        private void grdEvento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var teste = (Evento)grdEvento.SelectedRows[0].DataBoundItem;

                if (teste != null)
                {
                    CadEvento = new Evento();
                    CadEvento = teste;
                    DirtyFields(CadEvento);
                    btnUpdate.Visible = true;
                    btnDel.Visible = true;
                    BlockFields(groupMotoclube);
                    btnSaveMC.Visible = false;
                    btnAddMC.Visible = true;
                    btnCancel.Visible = false;
                }
            }

        }
    }
}
