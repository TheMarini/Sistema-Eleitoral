namespace prjSistema_Eleitoral
{
    partial class frmEleitores
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
            this.panel25 = new System.Windows.Forms.Panel();
            this.btnImportarExcel = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlExpandir = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtEditNome = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lbPesquisar = new System.Windows.Forms.ListBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblEleicoesAtivas = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pnlVisualizar = new System.Windows.Forms.Panel();
            this.txtLerCPF = new System.Windows.Forms.TextBox();
            this.txtLerNome = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtEditCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeEleicao = new System.Windows.Forms.Label();
            this.cbPesquisar = new System.Windows.Forms.ComboBox();
            this.pnlExpandir.SuspendLayout();
            this.pnlVisualizar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.LightGray;
            this.panel25.Location = new System.Drawing.Point(-1, 0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(281, 5);
            this.panel25.TabIndex = 60;
            // 
            // btnImportarExcel
            // 
            this.btnImportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportarExcel.Location = new System.Drawing.Point(330, 93);
            this.btnImportarExcel.Name = "btnImportarExcel";
            this.btnImportarExcel.Size = new System.Drawing.Size(121, 23);
            this.btnImportarExcel.TabIndex = 33;
            this.btnImportarExcel.Text = "importar do Excel";
            this.btnImportarExcel.UseVisualStyleBackColor = true;
            this.btnImportarExcel.Click += new System.EventHandler(this.btnImportarExcel_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(-1, 469);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1286, 178);
            this.panel5.TabIndex = 56;
            // 
            // pnlExpandir
            // 
            this.pnlExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlExpandir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlExpandir.Controls.Add(this.txtEditCpf);
            this.pnlExpandir.Controls.Add(this.btnImportarExcel);
            this.pnlExpandir.Controls.Add(this.btnOk);
            this.pnlExpandir.Controls.Add(this.txtEditNome);
            this.pnlExpandir.Location = new System.Drawing.Point(280, 347);
            this.pnlExpandir.Name = "pnlExpandir";
            this.pnlExpandir.Size = new System.Drawing.Size(1002, 120);
            this.pnlExpandir.TabIndex = 64;
            this.pnlExpandir.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOk.ForeColor = System.Drawing.Color.DimGray;
            this.btnOk.Location = new System.Drawing.Point(841, 65);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 49);
            this.btnOk.TabIndex = 30;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // txtEditNome
            // 
            this.txtEditNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtEditNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditNome.Location = new System.Drawing.Point(9, 10);
            this.txtEditNome.Name = "txtEditNome";
            this.txtEditNome.Size = new System.Drawing.Size(760, 38);
            this.txtEditNome.TabIndex = 31;
            this.txtEditNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.LightGray;
            this.panel12.Location = new System.Drawing.Point(280, 466);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1003, 5);
            this.panel12.TabIndex = 66;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Location = new System.Drawing.Point(275, 596);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 41);
            this.panel8.TabIndex = 65;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.btnExcluir.BackgroundImage = global::prjSistema_Eleitoral.Properties.Resources.trash;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Location = new System.Drawing.Point(580, 409);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(21, 59);
            this.btnExcluir.TabIndex = 54;
            this.btnExcluir.Tag = "Eleitores";
            this.btnExcluir.Text = " ";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbPesquisar.ForeColor = System.Drawing.Color.DimGray;
            this.lbPesquisar.FormattingEnabled = true;
            this.lbPesquisar.ItemHeight = 20;
            this.lbPesquisar.Location = new System.Drawing.Point(-1, 5);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(276, 600);
            this.lbPesquisar.TabIndex = 53;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtPesquisar.Location = new System.Drawing.Point(6, 10);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(193, 23);
            this.txtPesquisar.TabIndex = 21;
            this.txtPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel14.BackColor = System.Drawing.Color.LightGray;
            this.panel14.Location = new System.Drawing.Point(601, 403);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(5, 65);
            this.panel14.TabIndex = 62;
            // 
            // lblEleicoesAtivas
            // 
            this.lblEleicoesAtivas.AutoSize = true;
            this.lblEleicoesAtivas.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEleicoesAtivas.ForeColor = System.Drawing.Color.Green;
            this.lblEleicoesAtivas.Location = new System.Drawing.Point(6, 11);
            this.lblEleicoesAtivas.Name = "lblEleicoesAtivas";
            this.lblEleicoesAtivas.Size = new System.Drawing.Size(162, 13);
            this.lblEleicoesAtivas.TabIndex = 42;
            this.lblEleicoesAtivas.Text = "°já votou nas seguintes eleições:";
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel11.BackColor = System.Drawing.Color.LightGray;
            this.panel11.Location = new System.Drawing.Point(278, 403);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(323, 6);
            this.panel11.TabIndex = 58;
            // 
            // pnlVisualizar
            // 
            this.pnlVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVisualizar.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlVisualizar.Controls.Add(this.lblNomeEleicao);
            this.pnlVisualizar.Controls.Add(this.lblEleicoesAtivas);
            this.pnlVisualizar.Controls.Add(this.txtLerCPF);
            this.pnlVisualizar.Controls.Add(this.txtLerNome);
            this.pnlVisualizar.Location = new System.Drawing.Point(280, 470);
            this.pnlVisualizar.Name = "pnlVisualizar";
            this.pnlVisualizar.Size = new System.Drawing.Size(1002, 167);
            this.pnlVisualizar.TabIndex = 63;
            // 
            // txtLerCPF
            // 
            this.txtLerCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLerCPF.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLerCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLerCPF.Enabled = false;
            this.txtLerCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.txtLerCPF.ForeColor = System.Drawing.Color.DimGray;
            this.txtLerCPF.Location = new System.Drawing.Point(899, 145);
            this.txtLerCPF.Name = "txtLerCPF";
            this.txtLerCPF.Size = new System.Drawing.Size(92, 14);
            this.txtLerCPF.TabIndex = 40;
            this.txtLerCPF.Text = "CPF: ";
            this.txtLerCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLerNome
            // 
            this.txtLerNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLerNome.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLerNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLerNome.Enabled = false;
            this.txtLerNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtLerNome.ForeColor = System.Drawing.Color.Gray;
            this.txtLerNome.Location = new System.Drawing.Point(9, 11);
            this.txtLerNome.Name = "txtLerNome";
            this.txtLerNome.Size = new System.Drawing.Size(838, 31);
            this.txtLerNome.TabIndex = 32;
            this.txtLerNome.Text = "Nome do Eleitor";
            this.txtLerNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.Silver;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.Location = new System.Drawing.Point(463, 409);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 59);
            this.btnEditar.TabIndex = 61;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Location = new System.Drawing.Point(275, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 595);
            this.panel7.TabIndex = 57;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdicionar.Location = new System.Drawing.Point(279, 409);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(188, 59);
            this.btnAdicionar.TabIndex = 59;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.cbPesquisar);
            this.panel4.Controls.Add(this.txtPesquisar);
            this.panel4.Location = new System.Drawing.Point(-1, 596);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 41);
            this.panel4.TabIndex = 55;
            // 
            // txtEditCpf
            // 
            this.txtEditCpf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtEditCpf.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditCpf.Location = new System.Drawing.Point(775, 10);
            this.txtEditCpf.Mask = "000,000,000-00";
            this.txtEditCpf.Name = "txtEditCpf";
            this.txtEditCpf.Size = new System.Drawing.Size(216, 38);
            this.txtEditCpf.TabIndex = 36;
            this.txtEditCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNomeEleicao
            // 
            this.lblNomeEleicao.AutoSize = true;
            this.lblNomeEleicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNomeEleicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNomeEleicao.ForeColor = System.Drawing.Color.DimGray;
            this.lblNomeEleicao.Location = new System.Drawing.Point(8, 27);
            this.lblNomeEleicao.Name = "lblNomeEleicao";
            this.lblNomeEleicao.Size = new System.Drawing.Size(85, 15);
            this.lblNomeEleicao.TabIndex = 43;
            this.lblNomeEleicao.Text = "Eleições 2016";
            // 
            // cbPesquisar
            // 
            this.cbPesquisar.DisplayMember = "0";
            this.cbPesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPesquisar.FormattingEnabled = true;
            this.cbPesquisar.Items.AddRange(new object[] {
            "--"});
            this.cbPesquisar.Location = new System.Drawing.Point(205, 9);
            this.cbPesquisar.Name = "cbPesquisar";
            this.cbPesquisar.Size = new System.Drawing.Size(65, 24);
            this.cbPesquisar.TabIndex = 24;
            // 
            // frmEleitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1284, 647);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lbPesquisar);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.pnlVisualizar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.pnlExpandir);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEleitores";
            this.Text = "frmCandidatos";
            this.pnlExpandir.ResumeLayout(false);
            this.pnlExpandir.PerformLayout();
            this.pnlVisualizar.ResumeLayout(false);
            this.pnlVisualizar.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Button btnImportarExcel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlExpandir;
        private System.Windows.Forms.MaskedTextBox txtEditCpf;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtEditNome;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ListBox lbPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblEleicoesAtivas;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel pnlVisualizar;
        private System.Windows.Forms.TextBox txtLerCPF;
        private System.Windows.Forms.TextBox txtLerNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNomeEleicao;
        private System.Windows.Forms.ComboBox cbPesquisar;



    }
}