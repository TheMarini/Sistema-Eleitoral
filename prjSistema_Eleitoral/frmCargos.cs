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
    public partial class frmCargos : Form
    {
        public frmCargos()
        {
            InitializeComponent();
            carregarLista();
        }

        #region Métodos
        private void carregarLista(string item = null)
        {
            txtEditNome.Clear();
            txtEditQtdDigitos.Value = 1;
            lbPesquisar.Items.Clear();

            CodigoSQL.comando = new MySqlCommand("SELECT nm_cargo FROM cargo order by nm_cargo;", CodigoSQL.conexao);

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

            txtEditNome.Clear();
            txtEditQtdDigitos.Value = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlExpandir.Visible = true;
            pnlExpandir.BackColor = btnEditar.BackColor;
            txtEditNome.Focus();

            txtEditNome.Text = txtLerNome.Text;
            txtEditQtdDigitos.Value = int.Parse(lblLerQtdDigitos.Text);
        }
        #endregion

        #region Visualizar
        string codigo;
        private void lbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPesquisar.SelectedItem != null)
            {
                pnlVisualizar.Visible = true;

                CodigoSQL.comando = new MySqlCommand("SELECT * FROM cargo where nm_cargo = '" + lbPesquisar.SelectedItem.ToString() + "'", CodigoSQL.conexao);
                CodigoSQL.Ler.Read();
                txtLerCodigo.Text = "cód. " + CodigoSQL.Ler[0].ToString();
                txtLerNome.Text = CodigoSQL.Ler[1].ToString();
                lblLerQtdDigitos.Text = CodigoSQL.Ler[2].ToString();
                codigo = CodigoSQL.Ler[0].ToString();

                //só aparecer na aba Editar
                if (pnlExpandir.BackColor == btnEditar.BackColor)
                {
                    txtEditNome.Text = CodigoSQL.Ler[1].ToString();
                    txtEditQtdDigitos.Text = CodigoSQL.Ler[2].ToString();
                }

                CodigoSQL.Ler.Close();

                #region verificar se há em uma eleição desse cargo
                CodigoSQL.comando = new MySqlCommand("Select * from eleicao E Join cargo_eleicao CE on (CE.cd_eleicao = E.cd_eleicao) where (cd_cargo = '" + codigo + "');", CodigoSQL.conexao);
                if (CodigoSQL.Ler.Read())
                {
                    lblEleicoesAtivas.ForeColor = Color.Green;
                    lblEleicoesAtivas.Text = "°há eleições ativas nesse cargo";
                    lblEleicoesAtivas.Cursor = System.Windows.Forms.Cursors.Hand;
                }
                else
                {
                    lblEleicoesAtivas.ForeColor = Color.Gray;
                    lblEleicoesAtivas.Text = "não há eleições ativas nesse cargo";
                    lblEleicoesAtivas.Cursor = System.Windows.Forms.Cursors.Default;
                }
                CodigoSQL.Ler.Close();
                #endregion
            }
        }

        #region Eleições Ativas
        private void lblEleicoesAtivas_Click(object sender, EventArgs e)
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

        #region Adicionar/Editar/Excluir
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!txtEditNome.Text.Contains("'") && !txtEditNome.Text.Contains("--") && !txtEditNome.Text.Contains(';'))
            {
                try
                {
                    if (pnlExpandir.BackColor == btnAdicionar.BackColor)
                    {
                        CodigoSQL.comando = new MySqlCommand("Insert into cargo SELECT max(cd_cargo) + 1, '" + txtEditNome.Text + "', '" + txtEditQtdDigitos.Value + "' from cargo", CodigoSQL.conexao);

                        MessageBox.Show("Cargo gravado com sucesso");
                        carregarLista(txtEditNome.Text);
                        pnlExpandir.Visible = false;
                    }
                    else
                    {
                        CodigoSQL.comando = new MySqlCommand("Update cargo set nm_cargo = '" + txtEditNome.Text + "', qt_digitos_cargo = '" + txtEditQtdDigitos.Value + "' where (cd_cargo = '" + codigo + "')", CodigoSQL.conexao);

                        MessageBox.Show("Cargo alterado com sucesso");
                        carregarLista(txtEditNome.Text);
                        pnlExpandir.Visible = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Favor completar todos os campos corretamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else { MessageBox.Show("Nome inválido", "", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente exlcuir o cargo de " + lbPesquisar.SelectedItem + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    CodigoSQL.comando = new MySqlCommand("Delete from cargo where (cd_cargo = '" + codigo + "')", CodigoSQL.conexao);
                    carregarLista();
                }
                catch
                {
                    MessageBox.Show("Alguma eleição ainda está ligada à esse cargo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        #endregion
    }
}
