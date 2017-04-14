namespace prjSistema_Eleitoral
{
    partial class frmPartidos
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
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlVisualizar = new System.Windows.Forms.Panel();
            this.txtLerSigla = new System.Windows.Forms.TextBox();
            this.txtLerNumero = new System.Windows.Forms.TextBox();
            this.txtLerNome = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.ListBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.pnlExpandir = new System.Windows.Forms.Panel();
            this.txtEditNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEditSigla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtEditNome = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.pnlVisualizar.SuspendLayout();
            this.panel23.SuspendLayout();
            this.pnlExpandir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel17
            // 
            this.panel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel17.BackColor = System.Drawing.Color.LightGray;
            this.panel17.Location = new System.Drawing.Point(603, 403);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(5, 65);
            this.panel17.TabIndex = 65;
            // 
            // panel18
            // 
            this.panel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel18.BackColor = System.Drawing.Color.LightGray;
            this.panel18.Location = new System.Drawing.Point(280, 403);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(323, 6);
            this.panel18.TabIndex = 63;
            // 
            // panel19
            // 
            this.panel19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel19.BackColor = System.Drawing.Color.LightGray;
            this.panel19.Location = new System.Drawing.Point(282, 466);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(863, 5);
            this.panel19.TabIndex = 61;
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
            this.btnExcluir.TabIndex = 55;
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
            this.pnlVisualizar.Controls.Add(this.txtLerSigla);
            this.pnlVisualizar.Controls.Add(this.txtLerNumero);
            this.pnlVisualizar.Controls.Add(this.txtLerNome);
            this.pnlVisualizar.Location = new System.Drawing.Point(282, 470);
            this.pnlVisualizar.Name = "pnlVisualizar";
            this.pnlVisualizar.Size = new System.Drawing.Size(1000, 167);
            this.pnlVisualizar.TabIndex = 66;
            this.pnlVisualizar.Visible = false;
            // 
            // txtLerSigla
            // 
            this.txtLerSigla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLerSigla.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLerSigla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLerSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtLerSigla.ForeColor = System.Drawing.Color.Peru;
            this.txtLerSigla.Location = new System.Drawing.Point(5, 134);
            this.txtLerSigla.Name = "txtLerSigla";
            this.txtLerSigla.ReadOnly = true;
            this.txtLerSigla.Size = new System.Drawing.Size(106, 28);
            this.txtLerSigla.TabIndex = 40;
            this.txtLerSigla.Text = "sigla";
            // 
            // txtLerNumero
            // 
            this.txtLerNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLerNumero.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLerNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLerNumero.Enabled = false;
            this.txtLerNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtLerNumero.ForeColor = System.Drawing.Color.DimGray;
            this.txtLerNumero.Location = new System.Drawing.Point(949, 139);
            this.txtLerNumero.Name = "txtLerNumero";
            this.txtLerNumero.Size = new System.Drawing.Size(45, 24);
            this.txtLerNumero.TabIndex = 39;
            this.txtLerNumero.Text = "nº";
            this.txtLerNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtLerNome.Location = new System.Drawing.Point(9, 10);
            this.txtLerNome.Name = "txtLerNome";
            this.txtLerNome.Size = new System.Drawing.Size(985, 31);
            this.txtLerNome.TabIndex = 32;
            this.txtLerNome.Text = "Nome do Partido";
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
            this.btnEditar.TabIndex = 64;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel21
            // 
            this.panel21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel21.BackColor = System.Drawing.Color.LightGray;
            this.panel21.Location = new System.Drawing.Point(277, 596);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(5, 41);
            this.panel21.TabIndex = 59;
            // 
            // panel22
            // 
            this.panel22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel22.BackColor = System.Drawing.Color.LightGray;
            this.panel22.Location = new System.Drawing.Point(277, 1);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(5, 595);
            this.panel22.TabIndex = 58;
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
            this.btnAdicionar.TabIndex = 62;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panel23
            // 
            this.panel23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel23.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel23.Controls.Add(this.txtPesquisar);
            this.panel23.Location = new System.Drawing.Point(1, 596);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(276, 41);
            this.panel23.TabIndex = 56;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtPesquisar.Location = new System.Drawing.Point(6, 10);
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
            this.lbPesquisar.Location = new System.Drawing.Point(1, 5);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(276, 600);
            this.lbPesquisar.TabIndex = 39;
            this.lbPesquisar.SelectedIndexChanged += new System.EventHandler(this.lbPesquisar_SelectedIndexChanged);
            // 
            // panel24
            // 
            this.panel24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel24.BackColor = System.Drawing.Color.LightGray;
            this.panel24.Location = new System.Drawing.Point(1, 637);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(1281, 10);
            this.panel24.TabIndex = 57;
            // 
            // pnlExpandir
            // 
            this.pnlExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlExpandir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlExpandir.Controls.Add(this.txtEditNumero);
            this.pnlExpandir.Controls.Add(this.label6);
            this.pnlExpandir.Controls.Add(this.txtEditSigla);
            this.pnlExpandir.Controls.Add(this.label5);
            this.pnlExpandir.Controls.Add(this.btnOk);
            this.pnlExpandir.Controls.Add(this.txtEditNome);
            this.pnlExpandir.Location = new System.Drawing.Point(282, 346);
            this.pnlExpandir.Name = "pnlExpandir";
            this.pnlExpandir.Size = new System.Drawing.Size(1003, 121);
            this.pnlExpandir.TabIndex = 67;
            this.pnlExpandir.Visible = false;
            // 
            // txtEditNumero
            // 
            this.txtEditNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditNumero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEditNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEditNumero.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditNumero.Location = new System.Drawing.Point(926, 24);
            this.txtEditNumero.Name = "txtEditNumero";
            this.txtEditNumero.Size = new System.Drawing.Size(72, 24);
            this.txtEditNumero.TabIndex = 39;
            this.txtEditNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(937, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Número";
            // 
            // txtEditSigla
            // 
            this.txtEditSigla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditSigla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEditSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEditSigla.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditSigla.Location = new System.Drawing.Point(848, 24);
            this.txtEditSigla.Name = "txtEditSigla";
            this.txtEditSigla.Size = new System.Drawing.Size(72, 24);
            this.txtEditSigla.TabIndex = 37;
            this.txtEditSigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(867, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Sigla";
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
            this.btnOk.Location = new System.Drawing.Point(848, 65);
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
            this.txtEditNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtEditNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditNome.Location = new System.Drawing.Point(3, 10);
            this.txtEditNome.Name = "txtEditNome";
            this.txtEditNome.Size = new System.Drawing.Size(839, 38);
            this.txtEditNome.TabIndex = 31;
            this.txtEditNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel16
            // 
            this.panel16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel16.BackColor = System.Drawing.Color.LightGray;
            this.panel16.Location = new System.Drawing.Point(280, 466);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1008, 181);
            this.panel16.TabIndex = 60;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.LightGray;
            this.panel25.Location = new System.Drawing.Point(1, 0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(281, 5);
            this.panel25.TabIndex = 68;
            // 
            // frmPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1284, 647);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.pnlVisualizar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.lbPesquisar);
            this.Controls.Add(this.panel24);
            this.Controls.Add(this.pnlExpandir);
            this.Controls.Add(this.panel16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPartidos";
            this.Text = "Partidos";
            this.pnlVisualizar.ResumeLayout(false);
            this.pnlVisualizar.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.pnlExpandir.ResumeLayout(false);
            this.pnlExpandir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnlVisualizar;
        private System.Windows.Forms.TextBox txtLerSigla;
        private System.Windows.Forms.TextBox txtLerNumero;
        private System.Windows.Forms.TextBox txtLerNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ListBox lbPesquisar;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel pnlExpandir;
        private System.Windows.Forms.TextBox txtEditNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditSigla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtEditNome;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel25;

    }
}