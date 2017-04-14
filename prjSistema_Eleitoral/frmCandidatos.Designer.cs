namespace prjSistema_Eleitoral
{
    partial class frmCandidatos
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
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pnlVisualizar = new System.Windows.Forms.Panel();
            this.lblNomeEleicao = new System.Windows.Forms.Label();
            this.lblEleicaoAtiva = new System.Windows.Forms.Label();
            this.txtLerSigla = new System.Windows.Forms.TextBox();
            this.txtLerCodigo = new System.Windows.Forms.TextBox();
            this.pcbLerFoto = new System.Windows.Forms.PictureBox();
            this.txtLerNome = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbPesquisar = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlExpandir = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbEditFoto = new System.Windows.Forms.PictureBox();
            this.btnAbrirFoto = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbEditSigla = new System.Windows.Forms.ComboBox();
            this.txtEditNome = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlVisualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLerFoto)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlExpandir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.LightGray;
            this.panel25.Location = new System.Drawing.Point(1, 0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(281, 5);
            this.panel25.TabIndex = 46;
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel14.BackColor = System.Drawing.Color.LightGray;
            this.panel14.Location = new System.Drawing.Point(603, 403);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(5, 65);
            this.panel14.TabIndex = 48;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel11.BackColor = System.Drawing.Color.LightGray;
            this.panel11.Location = new System.Drawing.Point(280, 403);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(323, 6);
            this.panel11.TabIndex = 44;
            // 
            // pnlVisualizar
            // 
            this.pnlVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVisualizar.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlVisualizar.Controls.Add(this.lblNomeEleicao);
            this.pnlVisualizar.Controls.Add(this.lblEleicaoAtiva);
            this.pnlVisualizar.Controls.Add(this.txtLerSigla);
            this.pnlVisualizar.Controls.Add(this.txtLerCodigo);
            this.pnlVisualizar.Controls.Add(this.pcbLerFoto);
            this.pnlVisualizar.Controls.Add(this.txtLerNome);
            this.pnlVisualizar.Location = new System.Drawing.Point(282, 470);
            this.pnlVisualizar.Name = "pnlVisualizar";
            this.pnlVisualizar.Size = new System.Drawing.Size(1002, 167);
            this.pnlVisualizar.TabIndex = 49;
            // 
            // lblNomeEleicao
            // 
            this.lblNomeEleicao.AutoSize = true;
            this.lblNomeEleicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNomeEleicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNomeEleicao.ForeColor = System.Drawing.Color.DimGray;
            this.lblNomeEleicao.Location = new System.Drawing.Point(5, 26);
            this.lblNomeEleicao.Name = "lblNomeEleicao";
            this.lblNomeEleicao.Size = new System.Drawing.Size(85, 15);
            this.lblNomeEleicao.TabIndex = 43;
            this.lblNomeEleicao.Text = "Eleições 2016";
            this.lblNomeEleicao.Click += new System.EventHandler(this.lblNomeEleicao_Click);
            // 
            // lblEleicaoAtiva
            // 
            this.lblEleicaoAtiva.AutoSize = true;
            this.lblEleicaoAtiva.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEleicaoAtiva.ForeColor = System.Drawing.Color.Green;
            this.lblEleicaoAtiva.Location = new System.Drawing.Point(6, 11);
            this.lblEleicaoAtiva.Name = "lblEleicaoAtiva";
            this.lblEleicaoAtiva.Size = new System.Drawing.Size(130, 13);
            this.lblEleicaoAtiva.TabIndex = 42;
            this.lblEleicaoAtiva.Text = "está em uma eleição ativa";
            // 
            // txtLerSigla
            // 
            this.txtLerSigla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLerSigla.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLerSigla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLerSigla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLerSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtLerSigla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(109)))), ((int)(((byte)(142)))));
            this.txtLerSigla.Location = new System.Drawing.Point(5, 135);
            this.txtLerSigla.Name = "txtLerSigla";
            this.txtLerSigla.ReadOnly = true;
            this.txtLerSigla.Size = new System.Drawing.Size(117, 28);
            this.txtLerSigla.TabIndex = 41;
            this.txtLerSigla.Text = "partido";
            this.txtLerSigla.Click += new System.EventHandler(this.txtLerSigla_Click);
            // 
            // txtLerCodigo
            // 
            this.txtLerCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLerCodigo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLerCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLerCodigo.Enabled = false;
            this.txtLerCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.txtLerCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtLerCodigo.Location = new System.Drawing.Point(755, 145);
            this.txtLerCodigo.Name = "txtLerCodigo";
            this.txtLerCodigo.Size = new System.Drawing.Size(92, 14);
            this.txtLerCodigo.TabIndex = 40;
            this.txtLerCodigo.Text = "cód.143 ";
            this.txtLerCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pcbLerFoto
            // 
            this.pcbLerFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbLerFoto.BackColor = System.Drawing.Color.Transparent;
            this.pcbLerFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbLerFoto.Image = global::prjSistema_Eleitoral.Properties.Resources.candidato;
            this.pcbLerFoto.Location = new System.Drawing.Point(853, 11);
            this.pcbLerFoto.Name = "pcbLerFoto";
            this.pcbLerFoto.Size = new System.Drawing.Size(141, 148);
            this.pcbLerFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLerFoto.TabIndex = 35;
            this.pcbLerFoto.TabStop = false;
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
            this.txtLerNome.Text = "Nome do Candidato";
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
            this.btnEditar.Location = new System.Drawing.Point(465, 409);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 59);
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Location = new System.Drawing.Point(277, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 595);
            this.panel7.TabIndex = 43;
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
            this.btnAdicionar.Location = new System.Drawing.Point(281, 409);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(188, 59);
            this.btnAdicionar.TabIndex = 45;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.cbPesquisar);
            this.panel4.Controls.Add(this.txtPesquisar);
            this.panel4.Location = new System.Drawing.Point(1, 596);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 41);
            this.panel4.TabIndex = 41;
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
            this.cbPesquisar.SelectedIndexChanged += new System.EventHandler(this.cbPesquisar_SelectedIndexChanged);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtPesquisar.Location = new System.Drawing.Point(6, 10);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(193, 23);
            this.txtPesquisar.TabIndex = 21;
            this.txtPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
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
            this.lbPesquisar.Location = new System.Drawing.Point(1, 5);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(276, 600);
            this.lbPesquisar.TabIndex = 39;
            this.lbPesquisar.SelectedIndexChanged += new System.EventHandler(this.lbPesquisar_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(1, 469);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1286, 178);
            this.panel5.TabIndex = 42;
            // 
            // pnlExpandir
            // 
            this.pnlExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlExpandir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlExpandir.Controls.Add(this.label2);
            this.pnlExpandir.Controls.Add(this.pcbEditFoto);
            this.pnlExpandir.Controls.Add(this.btnAbrirFoto);
            this.pnlExpandir.Controls.Add(this.btnOk);
            this.pnlExpandir.Controls.Add(this.cbEditSigla);
            this.pnlExpandir.Controls.Add(this.txtEditNome);
            this.pnlExpandir.Location = new System.Drawing.Point(282, 222);
            this.pnlExpandir.Name = "pnlExpandir";
            this.pnlExpandir.Size = new System.Drawing.Size(1002, 245);
            this.pnlExpandir.TabIndex = 50;
            this.pnlExpandir.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(837, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Sigla do partido";
            // 
            // pcbEditFoto
            // 
            this.pcbEditFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbEditFoto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcbEditFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbEditFoto.Image = global::prjSistema_Eleitoral.Properties.Resources.candidato;
            this.pcbEditFoto.Location = new System.Drawing.Point(9, 11);
            this.pcbEditFoto.Name = "pcbEditFoto";
            this.pcbEditFoto.Size = new System.Drawing.Size(159, 165);
            this.pcbEditFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEditFoto.TabIndex = 34;
            this.pcbEditFoto.TabStop = false;
            // 
            // btnAbrirFoto
            // 
            this.btnAbrirFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrirFoto.Location = new System.Drawing.Point(174, 153);
            this.btnAbrirFoto.Name = "btnAbrirFoto";
            this.btnAbrirFoto.Size = new System.Drawing.Size(31, 23);
            this.btnAbrirFoto.TabIndex = 33;
            this.btnAbrirFoto.Text = "...";
            this.btnAbrirFoto.UseVisualStyleBackColor = true;
            this.btnAbrirFoto.Click += new System.EventHandler(this.btnAbrirFoto_Click);
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
            this.btnOk.Location = new System.Drawing.Point(841, 190);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 49);
            this.btnOk.TabIndex = 30;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbEditSigla
            // 
            this.cbEditSigla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEditSigla.DropDownHeight = 300;
            this.cbEditSigla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbEditSigla.FormattingEnabled = true;
            this.cbEditSigla.IntegralHeight = false;
            this.cbEditSigla.Location = new System.Drawing.Point(930, 55);
            this.cbEditSigla.Name = "cbEditSigla";
            this.cbEditSigla.Size = new System.Drawing.Size(63, 28);
            this.cbEditSigla.TabIndex = 32;
            // 
            // txtEditNome
            // 
            this.txtEditNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtEditNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditNome.Location = new System.Drawing.Point(175, 11);
            this.txtEditNome.Name = "txtEditNome";
            this.txtEditNome.Size = new System.Drawing.Size(818, 38);
            this.txtEditNome.TabIndex = 31;
            this.txtEditNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Location = new System.Drawing.Point(277, 596);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 41);
            this.panel8.TabIndex = 51;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.LightGray;
            this.panel12.Location = new System.Drawing.Point(282, 466);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1003, 5);
            this.panel12.TabIndex = 52;
            // 
            // FileDialog
            // 
            this.FileDialog.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|All files (*.*)|*.*";
            this.FileDialog.Title = "Selecionar foto";
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
            this.btnExcluir.Location = new System.Drawing.Point(582, 409);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(21, 59);
            this.btnExcluir.TabIndex = 40;
            this.btnExcluir.Tag = "Eleitores";
            this.btnExcluir.Text = " ";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(109)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1284, 647);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.pnlVisualizar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbPesquisar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlExpandir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCandidatos";
            this.Text = "frmCandidatos";
            this.pnlVisualizar.ResumeLayout(false);
            this.pnlVisualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLerFoto)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlExpandir.ResumeLayout(false);
            this.pnlExpandir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnlVisualizar;
        private System.Windows.Forms.TextBox txtLerCodigo;
        private System.Windows.Forms.PictureBox pcbLerFoto;
        private System.Windows.Forms.TextBox txtLerNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ListBox lbPesquisar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlExpandir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbEditFoto;
        private System.Windows.Forms.Button btnAbrirFoto;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbEditSigla;
        private System.Windows.Forms.TextBox txtEditNome;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblEleicaoAtiva;
        private System.Windows.Forms.Label lblNomeEleicao;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.TextBox txtLerSigla;

    }
}