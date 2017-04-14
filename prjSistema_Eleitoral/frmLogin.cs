using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prjSistema_Eleitoral
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Height = 194;
        }

        #region Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Contains("'") && !txtNome.Text.Contains("--") && !txtNome.Text.Contains(';') && !txtSenha.Text.Contains("'") && !txtSenha.Text.Contains("--") && !txtSenha.Text.Contains(';'))
            {
                CodigoSQL.comando = new MySqlCommand("SELECT * FROM usuario where nm_login = '" + txtNome.Text + "' and nm_senha = md5('" + txtSenha.Text + "')", CodigoSQL.conexao);
                if (CodigoSQL.Ler.Read())
                {
                    CodigoSQL.usuario = txtNome.Text;
                    CodigoSQL.Ler.Close();
                    this.Close();
                }
                else
                {
		            CodigoSQL.Ler.Close();
                    this.Height = 212;
                }
            }
            else
            {
                this.Visible = false;
                MessageBox.Show("HOJE NÃO ESPERTÃO", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                for (int i = 1; i > -1; i++)
                {
                    Console.Beep(1000, 1000);
                    Console.Beep(2000, 1000);
                }
            }
        }
        #endregion

        #region Sair
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CodigoSQL.usuario == null)
            {
                Environment.Exit(0);
            }
        }
        #endregion
    }
}
