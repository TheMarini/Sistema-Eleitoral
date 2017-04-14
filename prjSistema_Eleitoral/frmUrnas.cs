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
    public partial class frmUrnas : Form
    {
        public frmUrnas()
        {
            InitializeComponent();
            carregarLista();
        }

        #region Métodos
        private void carregarLista(string item = null)
        {
            txtEditNome.Clear();
            lbPesquisar.Items.Clear();

            CodigoSQL.comando = new MySqlCommand("SELECT cd_urna FROM urna order by cd_urna;", CodigoSQL.conexao);

            while (CodigoSQL.Ler.Read())
            {
                lbPesquisar.Items.Add(CodigoSQL.Ler[0].ToString());
            }
            CodigoSQL.Ler.Close();

            if (item != null) { lbPesquisar.SelectedItem = item; }
            else { if (lbPesquisar.Items.Count > 0) { lbPesquisar.SelectedIndex = 0; } }
        }
        #endregion

        #region Filtrar
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                foreach (string item in lbPesquisar.Items)
                {
                    if (item.ToLower().IndexOf(txtPesquisar.Text.ToLower()) == 0)
                    {
                        lbPesquisar.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        #endregion

        #region Expandir
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            pnlExpandir.Visible = true;
            pnlExpandir.BackColor = btnAdicionar.BackColor;
            txtEditNome.Focus();

            CodigoSQL.comando = new MySqlCommand("SELECT max(cd_urna) + 1 from urna",CodigoSQL.conexao);
            CodigoSQL.Ler.Read();
            txtEditNome.Text = CodigoSQL.Ler[0].ToString();
            CodigoSQL.Ler.Close();
        }
        #endregion

        #region Visualizar
        string codigo;
        private void lbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPesquisar.SelectedItem != null)
            {
                pnlVisualizar.Visible = true;

                CodigoSQL.comando = new MySqlCommand("SELECT cd_urna FROM urna where cd_urna = '" + lbPesquisar.SelectedItem.ToString() + "'", CodigoSQL.conexao);
                CodigoSQL.Ler.Read();
                txtLerNome.Text = "Urna nº " + CodigoSQL.Ler[0].ToString();
                codigo = CodigoSQL.Ler[0].ToString();

                CodigoSQL.Ler.Close();

                #region verificar se há em uma eleição desse cargo
                CodigoSQL.comando = new MySqlCommand("Select E.nm_eleicao from eleicao E Join eleicao_urna EU on (EU.cd_eleicao = E.cd_eleicao) Join urna U on (U.cd_urna = EU.cd_urna) where U.cd_urna = '"+ codigo +"'", CodigoSQL.conexao);
                if (CodigoSQL.Ler.Read())
                {
                    lblEleicoesAtivas.ForeColor = Color.Green;
                    lblEleicoesAtivas.Text = "°há eleições ativas nessa urna";
                    lblEleicoesAtivas.Cursor = System.Windows.Forms.Cursors.Hand;
                    lblNomeEleicao.Text = CodigoSQL.Ler[0].ToString();
                }
                else
                {
                    lblEleicoesAtivas.ForeColor = Color.Gray;
                    lblEleicoesAtivas.Text = "não há eleições ativas nessa urna";
                    lblEleicoesAtivas.Cursor = System.Windows.Forms.Cursors.Default;
                    lblNomeEleicao.Text = "";
                }
                CodigoSQL.Ler.Close();
                #endregion
            }
        }

        #region Eleições Ativas
        private void lblNomeEleicao_Click(object sender, EventArgs e)
        {
            if (lblEleicoesAtivas.ForeColor == Color.Green)
            {
                foreach (Form filho in this.Parent.FindForm().MdiChildren)
                {
                    if (filho.GetType() == typeof(frmEleicoes))
                    {
                        filho.Focus();
                        return;
                    }
                }
                frmEleicoes eleicoes = new frmEleicoes();
                eleicoes.MdiParent = this.Parent.FindForm();

                eleicoes.Location = this.Location;
                eleicoes.Anchor = this.Anchor;
                eleicoes.Size = this.Size;
                eleicoes.Show();
            }
        }
        #endregion
        #endregion

        #region Adicionar/Excluir
        private void btnOk_Click(object sender, EventArgs e)
        {
            CodigoSQL.comando = new MySqlCommand("Insert into urna SELECT max(cd_urna) + 1 from urna", CodigoSQL.conexao);

            MessageBox.Show("Urna gravada com sucesso");
            carregarLista(txtEditNome.Text);
            pnlExpandir.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente exlcuir " + lbPesquisar.SelectedItem + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                CodigoSQL.comando = new MySqlCommand("Delete from eleitor_eleicao_urna where (cd_urna = '" + codigo + "')", CodigoSQL.conexao);
                CodigoSQL.comando = new MySqlCommand("Delete from eleicao_urna where (cd_urna = '" + codigo + "')", CodigoSQL.conexao);
                CodigoSQL.comando = new MySqlCommand("Delete from urna where (cd_urna = '" + codigo + "')", CodigoSQL.conexao);
                carregarLista();
            }
        }
        #endregion
    }
}
