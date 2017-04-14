namespace prjSistema_Eleitoral
{
    partial class frmSistema_Eleitoral
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
            this.components = new System.ComponentModel.Container();
            this.lblNome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dica = new System.Windows.Forms.ToolTip(this.components);
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnCandidatos = new System.Windows.Forms.Button();
            this.btnEleitores = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.btnUrnas = new System.Windows.Forms.Button();
            this.btnEleicoes = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNome.Enabled = false;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNome.ForeColor = System.Drawing.Color.DimGray;
            this.lblNome.Location = new System.Drawing.Point(22, 6);
            this.lblNome.Multiline = true;
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(114, 28);
            this.lblNome.TabIndex = 30;
            this.lblNome.Text = "lblNome";
            this.lblNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.pcbLogo);
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 69);
            this.panel2.TabIndex = 13;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(26, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(331, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Tribunal Regional Eleitoral";
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbLogo.Image = global::prjSistema_Eleitoral.Properties.Resources.tre;
            this.pcbLogo.Location = new System.Drawing.Point(-60, -9);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(86, 88);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnUsuarios);
            this.panel3.Controls.Add(this.btnConfig);
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1285, 31);
            this.panel3.TabIndex = 14;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsuarios.Location = new System.Drawing.Point(142, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(96, 31);
            this.btnUsuarios.TabIndex = 32;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnConfig.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfig.Location = new System.Drawing.Point(236, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(118, 31);
            this.btnConfig.TabIndex = 31;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnMinimizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimizar.Location = new System.Drawing.Point(1207, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(39, 31);
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Gainsboro;
            this.panel13.Controls.Add(this.btnLogout);
            this.panel13.Controls.Add(this.lblNome);
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(142, 33);
            this.panel13.TabIndex = 27;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Gray;
            this.btnLogout.BackgroundImage = global::prjSistema_Eleitoral.Properties.Resources.exit;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(26, 31);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Firebrick;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(1246, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 31);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dica
            // 
            this.dica.AutoPopDelay = 5000;
            this.dica.InitialDelay = 200;
            this.dica.ReshowDelay = 0;
            // 
            // btnPartidos
            // 
            this.btnPartidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPartidos.BackColor = System.Drawing.Color.Peru;
            this.btnPartidos.BackgroundImage = global::prjSistema_Eleitoral.Properties.Resources.senado;
            this.btnPartidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPartidos.FlatAppearance.BorderSize = 0;
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnPartidos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPartidos.Location = new System.Drawing.Point(509, 31);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(155, 69);
            this.btnPartidos.TabIndex = 17;
            this.btnPartidos.Tag = "Partidos";
            this.btnPartidos.Text = " ";
            this.btnPartidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dica.SetToolTip(this.btnPartidos, "Partidos");
            this.btnPartidos.UseVisualStyleBackColor = false;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnCandidatos
            // 
            this.btnCandidatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCandidatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(109)))), ((int)(((byte)(142)))));
            this.btnCandidatos.BackgroundImage = global::prjSistema_Eleitoral.Properties.Resources.candidato;
            this.btnCandidatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCandidatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCandidatos.FlatAppearance.BorderSize = 0;
            this.btnCandidatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnCandidatos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCandidatos.Location = new System.Drawing.Point(354, 31);
            this.btnCandidatos.Name = "btnCandidatos";
            this.btnCandidatos.Size = new System.Drawing.Size(155, 69);
            this.btnCandidatos.TabIndex = 16;
            this.btnCandidatos.Tag = "Candidatos";
            this.btnCandidatos.Text = " ";
            this.btnCandidatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dica.SetToolTip(this.btnCandidatos, "Candidatos\r\n");
            this.btnCandidatos.UseVisualStyleBackColor = false;
            this.btnCandidatos.Click += new System.EventHandler(this.btnCandidatos_Click);
            // 
            // btnEleitores
            // 
            this.btnEleitores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEleitores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnEleitores.BackgroundImage = global::prjSistema_Eleitoral.Properties.Resources.eleitores;
            this.btnEleitores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEleitores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEleitores.FlatAppearance.BorderSize = 0;
            this.btnEleitores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEleitores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnEleitores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEleitores.Location = new System.Drawing.Point(664, 31);
            this.btnEleitores.Name = "btnEleitores";
            this.btnEleitores.Size = new System.Drawing.Size(155, 69);
            this.btnEleitores.TabIndex = 12;
            this.btnEleitores.Tag = "Eleitores";
            this.btnEleitores.Text = " ";
            this.btnEleitores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dica.SetToolTip(this.btnEleitores, "Eleitores");
            this.btnEleitores.UseVisualStyleBackColor = false;
            this.btnEleitores.Click += new System.EventHandler(this.btnEleitores_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCargos.BackgroundImage = global::prjSistema_Eleitoral.Properties.Resources.cargo;
            this.btnCargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCargos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargos.FlatAppearance.BorderSize = 0;
            this.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnCargos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCargos.Location = new System.Drawing.Point(819, 31);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(155, 69);
            this.btnCargos.TabIndex = 11;
            this.btnCargos.Tag = "Cargos";
            this.btnCargos.Text = " ";
            this.btnCargos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dica.SetToolTip(this.btnCargos, "Cargos");
            this.btnCargos.UseVisualStyleBackColor = false;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnUrnas
            // 
            this.btnUrnas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrnas.BackColor = System.Drawing.Color.Gray;
            this.btnUrnas.BackgroundImage = global::prjSistema_Eleitoral.Properties.Resources.urna;
            this.btnUrnas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrnas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrnas.FlatAppearance.BorderSize = 0;
            this.btnUrnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnUrnas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUrnas.Location = new System.Drawing.Point(1129, 31);
            this.btnUrnas.Name = "btnUrnas";
            this.btnUrnas.Size = new System.Drawing.Size(155, 69);
            this.btnUrnas.TabIndex = 6;
            this.btnUrnas.Tag = "Urnas";
            this.btnUrnas.Text = " ";
            this.btnUrnas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dica.SetToolTip(this.btnUrnas, "Urnas");
            this.btnUrnas.UseVisualStyleBackColor = false;
            this.btnUrnas.Click += new System.EventHandler(this.btnUrnas_Click);
            // 
            // btnEleicoes
            // 
            this.btnEleicoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEleicoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(71)))), ((int)(((byte)(113)))));
            this.btnEleicoes.BackgroundImage = global::prjSistema_Eleitoral.Properties.Resources.eleicao;
            this.btnEleicoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEleicoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEleicoes.FlatAppearance.BorderSize = 0;
            this.btnEleicoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEleicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnEleicoes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEleicoes.Location = new System.Drawing.Point(974, 31);
            this.btnEleicoes.Name = "btnEleicoes";
            this.btnEleicoes.Size = new System.Drawing.Size(155, 69);
            this.btnEleicoes.TabIndex = 5;
            this.btnEleicoes.Tag = "Eleições";
            this.btnEleicoes.Text = " ";
            this.btnEleicoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dica.SetToolTip(this.btnEleicoes, "Eleições");
            this.btnEleicoes.UseVisualStyleBackColor = false;
            this.btnEleicoes.Click += new System.EventHandler(this.btnEleicoes_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|All files (*.*)|*.*";
            // 
            // frmSistema_Eleitoral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1284, 737);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPartidos);
            this.Controls.Add(this.btnCandidatos);
            this.Controls.Add(this.btnEleitores);
            this.Controls.Add(this.btnCargos);
            this.Controls.Add(this.btnUrnas);
            this.Controls.Add(this.btnEleicoes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1250, 700);
            this.Name = "frmSistema_Eleitoral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "x";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSistema_Eleitoral_FormClosed);
            this.Load += new System.EventHandler(this.frmSistema_Eleitoral_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrnas;
        private System.Windows.Forms.Button btnEleicoes;
        private System.Windows.Forms.Button btnEleitores;
        private System.Windows.Forms.Button btnCargos;
        private System.Windows.Forms.TextBox lblNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCandidatos;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.ToolTip dica;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnUsuarios;

    }
}