using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace prjSistema_Eleitoral
{
    public partial class frmCandidatos : Form
    {
        public frmCandidatos()
        {
            InitializeComponent();
            carregarLista();

            if (!File.Exists(Application.StartupPath + @"\fotos dos candidatos\padrao.png"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\fotos dos candidatos");
                Image imagem = prjSistema_Eleitoral.Properties.Resources.candidato;
                imagem.Save(Application.StartupPath + @"\fotos dos candidatos\padrao.png");
            }
        }

        #region Métodos
        #region Carregar Lista
        bool bug;
        private void carregarLista(string item = null)
        {
            #region limpa histórico
            bug = true;
            txtEditNome.Clear();
            cbPesquisar.Items.Clear();
            cbPesquisar.Items.Add("--");
            cbPesquisar.SelectedIndex = 0;
            cbEditSigla.SelectedValue = null;
            cbEditSigla.Items.Clear();
            lbPesquisar.Items.Clear();
            FileDialog.FileName = "";
            bug = false;
            #endregion

            //Candidatos
            CodigoSQL.comando = new MySqlCommand("SELECT nm_candidato FROM candidato order by nm_candidato", CodigoSQL.conexao);
            while (CodigoSQL.Ler.Read())
            {
                lbPesquisar.Items.Add(CodigoSQL.Ler[0].ToString());
            }
            CodigoSQL.Ler.Close();

            //Partidos
            CodigoSQL.comando = new MySqlCommand("SELECT sg_partido FROM partido order by sg_partido", CodigoSQL.conexao);
            while (CodigoSQL.Ler.Read())
            {
                cbEditSigla.Items.Add(CodigoSQL.Ler[0].ToString());
                cbPesquisar.Items.Add(CodigoSQL.Ler[0].ToString());
            }
            CodigoSQL.Ler.Close();

            if (item != null) { lbPesquisar.SelectedItem = item; }
            else { if (lbPesquisar.Items.Count > 0) { lbPesquisar.SelectedIndex = 0; } }
        }
        #endregion

        #region Abrir Form
        public void abrirForm(Form nome)
        {
            foreach (Form filho in this.Parent.FindForm().MdiChildren)
            {
                if (filho.GetType() == nome.GetType())
                {
                    filho.Focus();
                    return;
                }
            }
            nome.MdiParent = this.Parent.FindForm();

            nome.Location = this.Location;
            nome.Anchor = this.Anchor;
            nome.Size = this.Size;
            nome.Show();
        }
        #endregion
        #endregion

        #region Filtrar
        #region Pelo Nome
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

        #region Pelo Partido
        private void cbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bug)
            {
                txtPesquisar.Clear();
                if (cbPesquisar.SelectedItem.ToString() != "--")
                {
                    lbPesquisar.Items.Clear();
                    CodigoSQL.comando = new MySqlCommand("SELECT nm_candidato FROM candidato where (sg_partido = '" + cbPesquisar.SelectedItem.ToString() + "') order by nm_candidato", CodigoSQL.conexao);

                    if (CodigoSQL.Ler.HasRows)
                    {
                        while (CodigoSQL.Ler.Read())
                        {
                            lbPesquisar.Items.Add(CodigoSQL.Ler[0].ToString());
                        }
                        CodigoSQL.Ler.Close();
                        lbPesquisar.SelectedIndex = 0;
                    }
                    else
                    {
                        lbPesquisar.Items.Add("não há candidatos");
                        pnlVisualizar.Visible = false;
                        pnlExpandir.Visible = false;
                        btnEditar.Visible = false;
                        btnExcluir.Visible = false;
                        btnAdicionar.Width = 322;
                        CodigoSQL.Ler.Close();
                    }
                }
                else { carregarLista(); }
            }
        }
        #endregion
        #endregion

        #region Expandir
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            pnlExpandir.Visible = true;
            pnlExpandir.BackColor = btnAdicionar.BackColor;
            txtEditNome.Focus();
            
            txtEditNome.Clear();
            cbEditSigla.SelectedItem = null;

            pcbEditFoto.Image = prjSistema_Eleitoral.Properties.Resources.candidato;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlExpandir.Visible = true;
            pnlExpandir.BackColor = btnEditar.BackColor;
            txtEditNome.Focus();

            txtEditNome.Text = txtLerNome.Text;
            cbEditSigla.SelectedItem = txtLerSigla.Text;

            pcbEditFoto.Image = pcbLerFoto.Image;
        }
        #endregion

        #region Visualizar
        string codigo;
        private void lbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPesquisar.SelectedItem != null && lbPesquisar.SelectedItem.ToString() != "não há candidatos")
            {
                pnlVisualizar.Visible = true;
                btnEditar.Visible = true;
                btnExcluir.Visible = true;
                btnAdicionar.Width = 188;

                CodigoSQL.comando = new MySqlCommand("SELECT * FROM candidato where nm_candidato = '" + lbPesquisar.SelectedItem + "'", CodigoSQL.conexao);

                #region verifica repetição
                if (lbPesquisar.SelectedIndex != 0) //para não dar erro de índice
                {
                    for (int i = lbPesquisar.SelectedIndex - 1; i >= 0; i--)
                    {
                        if (lbPesquisar.SelectedItem.ToString() == lbPesquisar.Items[i].ToString())
                        {
                            CodigoSQL.Ler.Read(); //muda de linha
                        }
                    }
                }
                #endregion
                
                if (CodigoSQL.Ler.Read()) //linha atual
                {
                    txtLerNome.Text = CodigoSQL.Ler[1].ToString();
                    txtLerCodigo.Text = "cód. " + CodigoSQL.Ler[0].ToString() + " ";
                    txtLerSigla.Text = CodigoSQL.Ler[2].ToString();
                    codigo = CodigoSQL.Ler[0].ToString();

                    string arquivo = Application.StartupPath + @"/fotos dos candidatos/" + codigo + ".png";

                    //verifica se o candidato possui uma imagem personalizada
                    if (File.Exists(arquivo)) { pcbLerFoto.ImageLocation = arquivo; }
                    else { pcbLerFoto.Image = prjSistema_Eleitoral.Properties.Resources.candidato; }

                    //só aparecer na aba Editar
                    if (pnlExpandir.BackColor == btnEditar.BackColor)
                    {
                        txtEditNome.Text = CodigoSQL.Ler[1].ToString();
                        cbEditSigla.SelectedItem = CodigoSQL.Ler[2].ToString();

                        if (File.Exists(arquivo)) { pcbEditFoto.ImageLocation = arquivo; }
                        else { pcbEditFoto.Image = prjSistema_Eleitoral.Properties.Resources.candidato; }
                    }
                }
                CodigoSQL.Ler.Close();

                #region verificar se está em uma eleição
                CodigoSQL.comando = new MySqlCommand("Select E.nm_eleicao from eleicao E Join cargo_eleicao_candidato C on (C.cd_eleicao = E.cd_eleicao) where (cd_candidato = " + codigo + ")", CodigoSQL.conexao);
                if (CodigoSQL.Ler.Read())
                {
                    lblEleicaoAtiva.ForeColor = Color.Green;
                    lblEleicaoAtiva.Text = "está em uma eleição ativa:";
                    lblNomeEleicao.Visible = true;
                    lblNomeEleicao.Text = CodigoSQL.Ler[0].ToString();
                }
                else
                {
                    lblEleicaoAtiva.ForeColor = Color.Gray;
                    lblEleicaoAtiva.Text = "não está em nenhuma eleição";
                    lblNomeEleicao.Visible = false;
                }
                CodigoSQL.Ler.Close();
                #endregion
            }
        }

        #region Eleições e Partidos
        private void lblNomeEleicao_Click(object sender, EventArgs e)
        {
            abrirForm(new frmEleicoes());
        }

        private void txtLerSigla_Click(object sender, EventArgs e)
        {
            abrirForm(new frmPartidos(txtLerSigla.Text));
        }
        #endregion
        #endregion

        #region Selecionar Foto
        string extensao;
        private void btnAbrirFoto_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                extensao = FileDialog.SafeFileName.Substring(FileDialog.SafeFileName.LastIndexOf('.'));

                if (extensao == ".png" || extensao == ".jpg" || extensao == ".jpeg")
                {
                    pcbEditFoto.Image = Image.FromFile(FileDialog.FileName);
                }
            }
        }
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
                        CodigoSQL.comando = new MySqlCommand("Insert into candidato SELECT max(cd_candidato) + 1, '" + txtEditNome.Text + "', '" + cbEditSigla.SelectedItem + "' from candidato", CodigoSQL.conexao);
                        MessageBox.Show("Candidato gravado com sucesso");

                        CodigoSQL.comando = new MySqlCommand("Select max(cd_candidato) from candidato", CodigoSQL.conexao);
                        CodigoSQL.Ler.Read();
                        codigo = CodigoSQL.Ler[0].ToString();
                        CodigoSQL.Ler.Close();
                    }
                    else
                    {
                        CodigoSQL.comando = new MySqlCommand("Update candidato set nm_candidato = '" + txtEditNome.Text + "', sg_partido = '" + cbEditSigla.SelectedItem.ToString() + "' where (cd_candidato = '" + codigo + "')", CodigoSQL.conexao);
                        MessageBox.Show("Candidato alterado com sucesso");
                    }

                    if (FileDialog.FileName != "")
                    {
                        File.Copy(FileDialog.FileName, Application.StartupPath + @"\fotos dos candidatos\" + codigo + ".png", true);
                    }

                    carregarLista(txtEditNome.Text);
                    pnlExpandir.Visible = false;
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
            if (MessageBox.Show("Deseja realmente exlcuir " + lbPesquisar.SelectedItem + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                CodigoSQL.comando = new MySqlCommand("Delete from cargo_eleicao_candidato where (cd_candidato = '" + codigo + "')", CodigoSQL.conexao);
                CodigoSQL.comando = new MySqlCommand("Delete from candidato where (cd_candidato = '" + codigo + "')", CodigoSQL.conexao);
                carregarLista();
            }
        }
        #endregion
    }
}
