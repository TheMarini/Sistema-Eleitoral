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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            carregarlista();
            this.Height = 309;
        }

        #region Métodos
        private void carregarlista(string item = null)
        {

            //txtEditLogin.Clear();
            //txtEditNome.Clear();
            //txtSenha.Clear();
            //txtConfSenha.Clear();

            lbPesquisar.Items.Clear();
            CodigoSQL.comando = new MySqlCommand("select nm_login from usuario", CodigoSQL.conexao);
            while (CodigoSQL.Ler.Read())
            {
                lbPesquisar.Items.Add(CodigoSQL.Ler[0].ToString());
            }
            CodigoSQL.Ler.Close();

            if (item != null) { lbPesquisar.SelectedItem = item; }
            else { if (lbPesquisar.Items.Count > 0) { lbPesquisar.SelectedIndex = 0; } }
        }
        #endregion 

        #region Visualizar
        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodigoSQL.comando = new MySqlCommand("select * from usuario where nm_login = '"+ lbPesquisar.SelectedItem +"'", CodigoSQL.conexao);
            while (CodigoSQL.Ler.Read())
            {
                txtLerLogin.Text = CodigoSQL.Ler[0].ToString();
                txtLerNome.Text = CodigoSQL.Ler[1].ToString();
            }
            CodigoSQL.Ler.Close();
        }
        #endregion

        #region Login válido
        private void txtEditLogin_Leave(object sender, EventArgs e)
        {
            CodigoSQL.comando = new MySqlCommand("select nm_login from usuario where nm_login = '" + txtEditLogin.Text + "'", CodigoSQL.conexao);
            if (CodigoSQL.Ler.Read())
            {
                lblErroLogin.Visible = true;
            }
            else
            {
                lblErroLogin.Visible = false;
            }
            CodigoSQL.Ler.Close();
        }
        #endregion

        #region Adicionar/Excluir
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtConfSenha.Text)
            {
                lblErroSenha.Visible = false;
                try
                {
                    CodigoSQL.comando = new MySqlCommand("insert into usuario values ('" + txtEditLogin.Text + "', '" + txtEditNome.Text + "', md5('" + txtSenha.Text + "'))",CodigoSQL.conexao);
                }
                catch
                {
                    MessageBox.Show("Insira os dados corretamente");
                    return;
                }
            }
            else
            {
                lblErroSenha.Visible = true;
                return;
            }
            carregarlista(txtEditLogin.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            CodigoSQL.comando = new MySqlCommand("delete from usuario where (nm_login = '"+ lbPesquisar.SelectedItem +"')", CodigoSQL.conexao);
            carregarlista();
        }
        #endregion

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.Height = 460;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
