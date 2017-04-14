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
    public partial class frmConfiguracoes : Form
    {
        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConfiguracoes_Load(object sender, EventArgs e)
        {
            CodigoSQL.comando = new MySqlCommand("select * from usuario",CodigoSQL.conexao);
            CodigoSQL.Ler.Read();
            txtLogin.Text = CodigoSQL.Ler[0].ToString();
            txtNome.Text = CodigoSQL.Ler[1].ToString();
            CodigoSQL.Ler.Close();

            txtBanco.Text = CodigoSQL.conexao.Database;
            txtServer.Text = CodigoSQL.conexao.DataSource;
        }
    }
}
