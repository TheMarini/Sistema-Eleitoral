namespace prjSistema_Eleitoral
{
    partial class frmUsuarios
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
            this.txtLerNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLerLogin = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblErroSenha = new System.Windows.Forms.Label();
            this.lblErroLogin = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEditLogin = new System.Windows.Forms.TextBox();
            this.txtEditNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLerNome
            // 
            this.txtLerNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLerNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLerNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLerNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtLerNome.Location = new System.Drawing.Point(7, 10);
            this.txtLerNome.Name = "txtLerNome";
            this.txtLerNome.ReadOnly = true;
            this.txtLerNome.Size = new System.Drawing.Size(178, 19);
            this.txtLerNome.TabIndex = 1;
            this.txtLerNome.TabStop = false;
            this.txtLerNome.Text = "nome completo";
            this.txtLerNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Location = new System.Drawing.Point(-11, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 25);
            this.panel1.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(22, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Usuários";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoltar.Location = new System.Drawing.Point(305, -1);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(25, 26);
            this.btnVoltar.TabIndex = 49;
            this.btnVoltar.Text = "x";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 311);
            this.panel2.TabIndex = 51;
            // 
            // txtLerLogin
            // 
            this.txtLerLogin.BackColor = System.Drawing.SystemColors.Control;
            this.txtLerLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtLerLogin.ForeColor = System.Drawing.Color.Gray;
            this.txtLerLogin.Location = new System.Drawing.Point(157, 74);
            this.txtLerLogin.Name = "txtLerLogin";
            this.txtLerLogin.ReadOnly = true;
            this.txtLerLogin.Size = new System.Drawing.Size(100, 16);
            this.txtLerLogin.TabIndex = 2;
            this.txtLerLogin.TabStop = false;
            this.txtLerLogin.Text = "login";
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbPesquisar.ForeColor = System.Drawing.Color.DimGray;
            this.lbPesquisar.FormattingEnabled = true;
            this.lbPesquisar.ItemHeight = 15;
            this.lbPesquisar.Location = new System.Drawing.Point(10, 25);
            this.lbPesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(110, 285);
            this.lbPesquisar.TabIndex = 0;
            this.lbPesquisar.SelectedIndexChanged += new System.EventHandler(this.lstUsuarios_SelectedIndexChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdicionar.Location = new System.Drawing.Point(73, 147);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(103, 35);
            this.btnAdicionar.TabIndex = 60;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.btnExcluir.BackgroundImage = global::prjSistema_Eleitoral.Properties.Resources.trash;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnExcluir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Location = new System.Drawing.Point(176, 147);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(22, 35);
            this.btnExcluir.TabIndex = 61;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.lblErroSenha);
            this.panel3.Controls.Add(this.lblErroLogin);
            this.panel3.Controls.Add(this.btnOk);
            this.panel3.Controls.Add(this.txtConfSenha);
            this.panel3.Controls.Add(this.txtSenha);
            this.panel3.Controls.Add(this.txtEditLogin);
            this.panel3.Controls.Add(this.txtEditNome);
            this.panel3.Location = new System.Drawing.Point(0, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 159);
            this.panel3.TabIndex = 62;
            // 
            // lblErroSenha
            // 
            this.lblErroSenha.AutoSize = true;
            this.lblErroSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lblErroSenha.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErroSenha.Location = new System.Drawing.Point(236, 75);
            this.lblErroSenha.Name = "lblErroSenha";
            this.lblErroSenha.Size = new System.Drawing.Size(79, 16);
            this.lblErroSenha.TabIndex = 39;
            this.lblErroSenha.Text = "- não batem";
            this.lblErroSenha.Visible = false;
            // 
            // lblErroLogin
            // 
            this.lblErroLogin.AutoSize = true;
            this.lblErroLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lblErroLogin.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErroLogin.Location = new System.Drawing.Point(120, 46);
            this.lblErroLogin.Name = "lblErroLogin";
            this.lblErroLogin.Size = new System.Drawing.Size(129, 16);
            this.lblErroLogin.TabIndex = 38;
            this.lblErroLogin.Text = "- esse login já existe";
            this.lblErroLogin.Visible = false;
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
            this.btnOk.Location = new System.Drawing.Point(10, 101);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(296, 41);
            this.btnOk.TabIndex = 36;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConfSenha.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfSenha.Location = new System.Drawing.Point(126, 72);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(110, 23);
            this.txtConfSenha.TabIndex = 35;
            this.txtConfSenha.Text = "senha";
            this.txtConfSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfSenha.UseSystemPasswordChar = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenha.ForeColor = System.Drawing.Color.DimGray;
            this.txtSenha.Location = new System.Drawing.Point(10, 72);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(110, 23);
            this.txtSenha.TabIndex = 34;
            this.txtSenha.Text = "senha";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEditLogin
            // 
            this.txtEditLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEditLogin.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditLogin.Location = new System.Drawing.Point(10, 43);
            this.txtEditLogin.Name = "txtEditLogin";
            this.txtEditLogin.Size = new System.Drawing.Size(110, 23);
            this.txtEditLogin.TabIndex = 33;
            this.txtEditLogin.Text = "login";
            this.txtEditLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEditLogin.Leave += new System.EventHandler(this.txtEditLogin_Leave);
            // 
            // txtEditNome
            // 
            this.txtEditNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEditNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditNome.Location = new System.Drawing.Point(10, 11);
            this.txtEditNome.Name = "txtEditNome";
            this.txtEditNome.Size = new System.Drawing.Size(296, 23);
            this.txtEditNome.TabIndex = 32;
            this.txtEditNome.Text = "nome completo";
            this.txtEditNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "login:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.txtLerNome);
            this.panel4.Location = new System.Drawing.Point(121, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 39);
            this.panel4.TabIndex = 65;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Gerenciar Permissões de Acesso",
            "Gerência de Usuários",
            "Gerência de Partidos",
            "Gerência de Candidatos",
            "Gerência de Cargos",
            "Gerência de Urnas",
            "Gerência de Eleitores",
            "Gerência de Eleição",
            "Gráfico de Votação"});
            this.checkedListBox1.Location = new System.Drawing.Point(4, 6);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkedListBox1.Size = new System.Drawing.Size(187, 135);
            this.checkedListBox1.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(24, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Permissões de Acesso";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.checkedListBox1);
            this.panel5.Controls.Add(this.btnExcluir);
            this.panel5.Controls.Add(this.btnAdicionar);
            this.panel5.Location = new System.Drawing.Point(120, 129);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(198, 182);
            this.panel5.TabIndex = 68;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(120, 105);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(198, 26);
            this.panel6.TabIndex = 69;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 460);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLerLogin);
            this.Controls.Add(this.lbPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLerNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtLerLogin;
        private System.Windows.Forms.ListBox lbPesquisar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEditLogin;
        private System.Windows.Forms.TextBox txtEditNome;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblErroLogin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblErroSenha;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;

    }
}