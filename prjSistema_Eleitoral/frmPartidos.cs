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
    public partial class frmPartidos : Form
    {
        public frmPartidos(string partido = null)
        {
            InitializeComponent();
            carregarLista(partido);
        }

        #region Métodos
        private void carregarLista(string item = null)
        {
            txtEditNome.Clear();
            txtEditNumero.Clear();
            txtEditSigla.Clear();
            lbPesquisar.Items.Clear();

            CodigoSQL.comando = new MySqlCommand("SELECT sg_partido FROM partido order by sg_partido;", CodigoSQL.conexao);

            while (CodigoSQL.Ler.Read())
            {
                lbPesquisar.Items.Add(CodigoSQL.Ler[0].ToString());
            }
            CodigoSQL.Ler.Close();

            if (item != null) { lbPesquisar.SelectedItem = item; }
            else { if (lbPesquisar.Items.Count > 0) { lbPesquisar.SelectedIndex = 0; } }     
        }
        #endregion

        #region Expandir
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            pnlExpandir.Visible = true;
            pnlExpandir.BackColor = btnAdicionar.BackColor;
            txtEditNome.Focus();

            txtEditNome.Clear();
            txtEditSigla.Clear();
            txtEditNumero.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlExpandir.Visible = true;
            pnlExpandir.BackColor = btnEditar.BackColor;
            txtEditNome.Focus();

            txtEditNome.Text = txtLerNome.Text;
            txtEditSigla.Text = txtLerSigla.Text;
            txtEditNumero.Text = txtLerNumero.Text;
        }
        #endregion

        #region Visualizar
        private void lbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPesquisar.SelectedItem != null)
            {
                pnlVisualizar.Visible = true;

                CodigoSQL.comando = new MySqlCommand("SELECT * FROM partido where sg_partido = '" + lbPesquisar.SelectedItem.ToString() + "'", CodigoSQL.conexao);
                CodigoSQL.Ler.Read();
                txtLerSigla.Text = CodigoSQL.Ler[0].ToString();
                txtLerNome.Text = CodigoSQL.Ler[1].ToString();
                txtLerNumero.Text = CodigoSQL.Ler[2].ToString();

                //só aparecer na aba Editar
                if (pnlExpandir.BackColor == btnEditar.BackColor) 
                {
                    txtEditSigla.Text = CodigoSQL.Ler[0].ToString();
                    txtEditNome.Text = CodigoSQL.Ler[1].ToString();
                    txtEditNumero.Text = CodigoSQL.Ler[2].ToString();
                }

                CodigoSQL.Ler.Close();
            }
        }
        #endregion

        #region Adicionar/Editar/Excluir
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (pnlExpandir.BackColor == btnAdicionar.BackColor)
                {
                    CodigoSQL.comando = new MySqlCommand("Insert into partido values ('" + txtEditSigla.Text + "', '" + txtEditNome.Text + "', " + txtEditNumero.Text + ");", CodigoSQL.conexao);
                    
                    MessageBox.Show("Partido gravado com sucesso");
                    carregarLista(txtEditSigla.Text);
                    pnlExpandir.Visible = false;
                }
                else
                {

                    CodigoSQL.comando = new MySqlCommand("Update partido set sg_partido = '" + txtEditSigla.Text + "', nm_partido = '" + txtEditNome.Text + "', cd_nr_partido = '" + txtEditNumero.Text + "' where (sg_partido = '" + txtLerSigla.Text + "')", CodigoSQL.conexao);
                   
                    MessageBox.Show("Candidato alterado com sucesso");
                    carregarLista(txtEditSigla.Text);                
                    pnlExpandir.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Favor completar todos os campos corretamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente exlcuir o " + lbPesquisar.SelectedItem + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    CodigoSQL.comando = new MySqlCommand("Delete from partido where (sg_partido = '" + txtLerSigla.Text + "')", CodigoSQL.conexao);
                    carregarLista();
                }
                catch
                {
                    MessageBox.Show("Algum candidato ainda está ligado à esse partido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
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

    }
}
