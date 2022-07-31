namespace Cadastro_Evento
{
    partial class FormInitial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInitial));
            this.txtMotoclube = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseImg = new System.Windows.Forms.Button();
            this.imgBrasao = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveMC = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBrasao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveMC)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMotoclube
            // 
            this.txtMotoclube.BackColor = System.Drawing.Color.LightGray;
            this.txtMotoclube.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotoclube.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotoclube.Location = new System.Drawing.Point(12, 92);
            this.txtMotoclube.MaxLength = 35;
            this.txtMotoclube.Name = "txtMotoclube";
            this.txtMotoclube.Size = new System.Drawing.Size(391, 33);
            this.txtMotoclube.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 60;
            this.label1.Text = "Motoclube";
            // 
            // btnChooseImg
            // 
            this.btnChooseImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChooseImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChooseImg.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImg.ForeColor = System.Drawing.Color.Black;
            this.btnChooseImg.Location = new System.Drawing.Point(270, 165);
            this.btnChooseImg.Name = "btnChooseImg";
            this.btnChooseImg.Size = new System.Drawing.Size(133, 32);
            this.btnChooseImg.TabIndex = 103;
            this.btnChooseImg.Text = "Escolher Imagem";
            this.btnChooseImg.UseVisualStyleBackColor = true;
            this.btnChooseImg.Click += new System.EventHandler(this.btnChooseImg_Click);
            // 
            // imgBrasao
            // 
            this.imgBrasao.BackColor = System.Drawing.Color.White;
            this.imgBrasao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBrasao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBrasao.Enabled = false;
            this.imgBrasao.Location = new System.Drawing.Point(12, 165);
            this.imgBrasao.Name = "imgBrasao";
            this.imgBrasao.Size = new System.Drawing.Size(252, 199);
            this.imgBrasao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBrasao.TabIndex = 102;
            this.imgBrasao.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSaveMC
            // 
            this.btnSaveMC.BackColor = System.Drawing.Color.White;
            this.btnSaveMC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveMC.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveMC.Image")));
            this.btnSaveMC.Location = new System.Drawing.Point(12, 385);
            this.btnSaveMC.Name = "btnSaveMC";
            this.btnSaveMC.Size = new System.Drawing.Size(40, 40);
            this.btnSaveMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSaveMC.TabIndex = 104;
            this.btnSaveMC.TabStop = false;
            this.btnSaveMC.Click += new System.EventHandler(this.btnSaveMC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 105;
            this.label2.Text = "Brasão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 26);
            this.label3.TabIndex = 106;
            this.label3.Text = "Cadastro Inicial";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(417, 437);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveMC);
            this.Controls.Add(this.btnChooseImg);
            this.Controls.Add(this.imgBrasao);
            this.Controls.Add(this.txtMotoclube);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInitial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO INICIAL";
            ((System.ComponentModel.ISupportInitialize)(this.imgBrasao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveMC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMotoclube;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseImg;
        private System.Windows.Forms.PictureBox imgBrasao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox btnSaveMC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}