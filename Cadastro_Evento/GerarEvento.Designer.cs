namespace Cadastro_Evento
{
    partial class GerarEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerarEvento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNiver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.PictureBox();
            this.grdEventoList = new System.Windows.Forms.DataGridView();
            this.Paste = new System.Windows.Forms.DataGridViewImageColumn();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Texto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aniversario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMc = new System.Windows.Forms.Label();
            this.btnCadInitial = new System.Windows.Forms.Button();
            this.imgBrasao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEventoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBrasao)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 96;
            this.label4.Text = "Gerar novo Evento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 95;
            this.label3.Text = "º  Aniversário";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNiver
            // 
            this.txtNiver.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNiver.Location = new System.Drawing.Point(104, 322);
            this.txtNiver.Name = "txtNiver";
            this.txtNiver.Size = new System.Drawing.Size(30, 28);
            this.txtNiver.TabIndex = 90;
            this.txtNiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 94;
            this.label2.Text = "Eventos";
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(27, 322);
            this.txtAno.Mask = "0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(40, 28);
            this.txtAno.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 93;
            this.label1.Text = "Ano";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.White;
            this.btnAddEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEvent.Image")));
            this.btnAddEvent.Location = new System.Drawing.Point(249, 312);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(40, 40);
            this.btnAddEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddEvent.TabIndex = 92;
            this.btnAddEvent.TabStop = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click_1);
            // 
            // grdEventoList
            // 
            this.grdEventoList.AllowUserToAddRows = false;
            this.grdEventoList.AllowUserToDeleteRows = false;
            this.grdEventoList.AllowUserToResizeColumns = false;
            this.grdEventoList.AllowUserToResizeRows = false;
            this.grdEventoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEventoList.BackgroundColor = System.Drawing.Color.LightGray;
            this.grdEventoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEventoList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEventoList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.grdEventoList.ColumnHeadersHeight = 20;
            this.grdEventoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdEventoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Paste,
            this.Evento,
            this.DataCadastro,
            this.Id,
            this.Ano,
            this.Texto,
            this.Aniversario});
            this.grdEventoList.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEventoList.DefaultCellStyle = dataGridViewCellStyle24;
            this.grdEventoList.EnableHeadersVisualStyles = false;
            this.grdEventoList.GridColor = System.Drawing.Color.DimGray;
            this.grdEventoList.Location = new System.Drawing.Point(24, 89);
            this.grdEventoList.Name = "grdEventoList";
            this.grdEventoList.ReadOnly = true;
            this.grdEventoList.RowHeadersVisible = false;
            this.grdEventoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEventoList.ShowCellErrors = false;
            this.grdEventoList.ShowEditingIcon = false;
            this.grdEventoList.ShowRowErrors = false;
            this.grdEventoList.Size = new System.Drawing.Size(368, 150);
            this.grdEventoList.TabIndex = 91;
            this.grdEventoList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEventoList_CellClick_1);
            this.grdEventoList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEventoList_CellMouseEnter_1);
            this.grdEventoList.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEventoList_CellMouseLeave_1);
            // 
            // Paste
            // 
            this.Paste.FillWeight = 20.83444F;
            this.Paste.HeaderText = "";
            this.Paste.Image = ((System.Drawing.Image)(resources.GetObject("Paste.Image")));
            this.Paste.Name = "Paste";
            this.Paste.ReadOnly = true;
            // 
            // Evento
            // 
            this.Evento.DataPropertyName = "Eventos";
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            this.Evento.ReadOnly = true;
            this.Evento.Visible = false;
            // 
            // DataCadastro
            // 
            this.DataCadastro.DataPropertyName = "DataCadastro";
            this.DataCadastro.HeaderText = "DataCadastro";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.ReadOnly = true;
            this.DataCadastro.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Ano";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ano.DefaultCellStyle = dataGridViewCellStyle23;
            this.Ano.FillWeight = 65.30087F;
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            // 
            // Texto
            // 
            this.Texto.DataPropertyName = "Texto";
            this.Texto.FillWeight = 209.8647F;
            this.Texto.HeaderText = "Descrição";
            this.Texto.Name = "Texto";
            this.Texto.ReadOnly = true;
            // 
            // Aniversario
            // 
            this.Aniversario.DataPropertyName = "Aniversario";
            this.Aniversario.HeaderText = "Aniversario";
            this.Aniversario.Name = "Aniversario";
            this.Aniversario.ReadOnly = true;
            this.Aniversario.Visible = false;
            // 
            // lblMc
            // 
            this.lblMc.AutoSize = true;
            this.lblMc.BackColor = System.Drawing.Color.Transparent;
            this.lblMc.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMc.Location = new System.Drawing.Point(19, 9);
            this.lblMc.Name = "lblMc";
            this.lblMc.Size = new System.Drawing.Size(48, 28);
            this.lblMc.TabIndex = 97;
            this.lblMc.Text = "MC";
            // 
            // btnCadInitial
            // 
            this.btnCadInitial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadInitial.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadInitial.Location = new System.Drawing.Point(467, 334);
            this.btnCadInitial.Name = "btnCadInitial";
            this.btnCadInitial.Size = new System.Drawing.Size(125, 28);
            this.btnCadInitial.TabIndex = 98;
            this.btnCadInitial.Text = "Cadastro Inicial";
            this.btnCadInitial.UseVisualStyleBackColor = true;
            this.btnCadInitial.Click += new System.EventHandler(this.btnCadInitial_Click);
            // 
            // imgBrasao
            // 
            this.imgBrasao.BackColor = System.Drawing.Color.White;
            this.imgBrasao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBrasao.Location = new System.Drawing.Point(405, 89);
            this.imgBrasao.Name = "imgBrasao";
            this.imgBrasao.Size = new System.Drawing.Size(176, 139);
            this.imgBrasao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBrasao.TabIndex = 99;
            this.imgBrasao.TabStop = false;
            this.imgBrasao.Visible = false;
            // 
            // GerarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cadastro_Evento.Properties.Resources.route01_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 364);
            this.Controls.Add(this.imgBrasao);
            this.Controls.Add(this.btnCadInitial);
            this.Controls.Add(this.lblMc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNiver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.grdEventoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GerarEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Cadastro Motorcycle";
            this.Load += new System.EventHandler(this.GerarEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEventoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBrasao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNiver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnAddEvent;
        private System.Windows.Forms.DataGridView grdEventoList;
        private System.Windows.Forms.DataGridViewImageColumn Paste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Texto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aniversario;
        private System.Windows.Forms.Label lblMc;
        private System.Windows.Forms.Button btnCadInitial;
        private System.Windows.Forms.PictureBox imgBrasao;
    }
}