namespace prjSistema_Eleitoral
{
    partial class frmUrnas
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
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlVisualizar = new System.Windows.Forms.Panel();
            this.lblNomeEleicao = new System.Windows.Forms.Label();
            this.lblEleicoesAtivas = new System.Windows.Forms.Label();
            this.txtLerVotos = new System.Windows.Forms.TextBox();
            this.txtLerNome = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.ListBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.pnlExpandir = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtEditNome = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.pnlVisualizar.SuspendLayout();
            this.panel23.SuspendLayout();
            this.pnlExpandir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.LightGray;
            this.panel25.Location = new System.Drawing.Point(0, 0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(281, 5);
            this.panel25.TabIndex = 96;
            // 
            // panel17
            // 
            this.panel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel17.BackColor = System.Drawing.Color.LightGray;
            this.panel17.Location = new System.Drawing.Point(602, 403);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(5, 65);
            this.panel17.TabIndex = 93;
            // 
            // panel18
            // 
            this.panel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel18.BackColor = System.Drawing.Color.LightGray;
            this.panel18.Location = new System.Drawing.Point(279, 403);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(323, 6);
            this.panel18.TabIndex = 91;
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
            this.btnExcluir.Location = new System.Drawing.Point(578, 409);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(24, 59);
            this.btnExcluir.TabIndex = 85;
            this.btnExcluir.Tag = "Eleitores";
            this.btnExcluir.Text = " ";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pnlVisualizar
            // 
            this.pnlVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVisualizar.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlVisualizar.Controls.Add(this.lblNomeEleicao);
            this.pnlVisualizar.Controls.Add(this.lblEleicoesAtivas);
            this.pnlVisualizar.Controls.Add(this.txtLerVotos);
            this.pnlVisualizar.Controls.Add(this.txtLerNome);
            this.pnlVisualizar.Location = new System.Drawing.Point(281, 470);
            this.pnlVisualizar.Name = "pnlVisualizar";
            this.pnlVisualizar.Size = new System.Drawing.Size(1000, 167);
            this.pnlVisualizar.TabIndex = 94;
            this.pnlVisualizar.Visible = false;
            // 
            // lblNomeEleicao
            // 
            this.lblNomeEleicao.AutoSize = true;
            this.lblNomeEleicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNomeEleicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNomeEleicao.ForeColor = System.Drawing.Color.DimGray;
            this.lblNomeEleicao.Location = new System.Drawing.Point(13, 27);
            this.lblNomeEleicao.Name = "lblNomeEleicao";
            this.lblNomeEleicao.Size = new System.Drawing.Size(85, 15);
            this.lblNomeEleicao.TabIndex = 98;
            this.lblNomeEleicao.Text = "Eleições 2016";
            this.lblNomeEleicao.Click += new System.EventHandler(this.lblNomeEleicao_Click);
            // 
            // lblEleicoesAtivas
            // 
            this.lblEleicoesAtivas.AutoSize = true;
            this.lblEleicoesAtivas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEleicoesAtivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEleicoesAtivas.ForeColor = System.Drawing.Color.Green;
            this.lblEleicoesAtivas.Location = new System.Drawing.Point(7, 10);
            this.lblEleicoesAtivas.Name = "lblEleicoesAtivas";
            this.lblEleicoesAtivas.Size = new System.Drawing.Size(173, 15);
            this.lblEleicoesAtivas.TabIndex = 43;
            this.lblEleicoesAtivas.Text = "°há eleições ativas nessa urna";
            // 
            // txtLerVotos
            // 
            this.txtLerVotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLerVotos.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLerVotos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLerVotos.Enabled = false;
            this.txtLerVotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLerVotos.ForeColor = System.Drawing.Color.DimGray;
            this.txtLerVotos.Location = new System.Drawing.Point(6, 142);
            this.txtLerVotos.Name = "txtLerVotos";
            this.txtLerVotos.Size = new System.Drawing.Size(92, 19);
            this.txtLerVotos.TabIndex = 42;
            this.txtLerVotos.Text = "2347 votos";
            this.txtLerVotos.Visible = false;
            // 
            // txtLerNome
            // 
            this.txtLerNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLerNome.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLerNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLerNome.Enabled = false;
            this.txtLerNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic);
            this.txtLerNome.ForeColor = System.Drawing.Color.Gray;
            this.txtLerNome.Location = new System.Drawing.Point(10, 10);
            this.txtLerNome.Name = "txtLerNome";
            this.txtLerNome.Size = new System.Drawing.Size(985, 31);
            this.txtLerNome.TabIndex = 32;
            this.txtLerNome.Text = "Nome da Urna";
            this.txtLerNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel22
            // 
            this.panel22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel22.BackColor = System.Drawing.Color.LightGray;
            this.panel22.Location = new System.Drawing.Point(276, 1);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(5, 636);
            this.panel22.TabIndex = 88;
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
            this.btnAdicionar.Location = new System.Drawing.Point(280, 409);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(301, 59);
            this.btnAdicionar.TabIndex = 90;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panel23
            // 
            this.panel23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel23.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel23.Controls.Add(this.txtPesquisar);
            this.panel23.Location = new System.Drawing.Point(0, 596);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(276, 41);
            this.panel23.TabIndex = 86;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtPesquisar.Location = new System.Drawing.Point(7, 10);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(264, 23);
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
            this.lbPesquisar.Location = new System.Drawing.Point(0, 5);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(276, 600);
            this.lbPesquisar.TabIndex = 84;
            this.lbPesquisar.SelectedIndexChanged += new System.EventHandler(this.lbPesquisar_SelectedIndexChanged);
            // 
            // panel24
            // 
            this.panel24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel24.BackColor = System.Drawing.Color.LightGray;
            this.panel24.Location = new System.Drawing.Point(0, 637);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(1281, 10);
            this.panel24.TabIndex = 87;
            // 
            // pnlExpandir
            // 
            this.pnlExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlExpandir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlExpandir.Controls.Add(this.btnOk);
            this.pnlExpandir.Controls.Add(this.txtEditNome);
            this.pnlExpandir.Location = new System.Drawing.Point(281, 403);
            this.pnlExpandir.Name = "pnlExpandir";
            this.pnlExpandir.Size = new System.Drawing.Size(1003, 64);
            this.pnlExpandir.TabIndex = 95;
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
            this.btnOk.Location = new System.Drawing.Point(849, 8);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 49);
            this.btnOk.TabIndex = 40;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtEditNome
            // 
            this.txtEditNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditNome.Cursor = System.Windows.Forms.Cursors.No;
            this.txtEditNome.Enabled = false;
            this.txtEditNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtEditNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditNome.Location = new System.Drawing.Point(332, 14);
            this.txtEditNome.Name = "txtEditNome";
            this.txtEditNome.Size = new System.Drawing.Size(511, 38);
            this.txtEditNome.TabIndex = 31;
            this.txtEditNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel16
            // 
            this.panel16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel16.BackColor = System.Drawing.Color.LightGray;
            this.panel16.Location = new System.Drawing.Point(277, 466);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1007, 181);
            this.panel16.TabIndex = 97;
            // 
            // frmUrnas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1284, 647);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.lbPesquisar);
            this.Controls.Add(this.panel24);
            this.Controls.Add(this.pnlExpandir);
            this.Controls.Add(this.pnlVisualizar);
            this.Controls.Add(this.panel16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUrnas";
            this.Text = "frmCandidatos";
            this.pnlVisualizar.ResumeLayout(false);
            this.pnlVisualizar.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.pnlExpandir.ResumeLayout(false);
            this.pnlExpandir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnlVisualizar;
        private System.Windows.Forms.Label lblEleicoesAtivas;
        private System.Windows.Forms.TextBox txtLerVotos;
        private System.Windows.Forms.TextBox txtLerNome;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ListBox lbPesquisar;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel pnlExpandir;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtEditNome;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lblNomeEleicao;





    }
}