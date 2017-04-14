using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace prjSistema_Eleitoral
{
    public partial class frmEleitores : Form
    {
        public frmEleitores()
        {
            InitializeComponent();
            carregarLista();
        }

        #region Métodos
        private void carregarLista(string item = null)
        {
            txtEditNome.Clear();
            txtEditCpf.Clear();
            lbPesquisar.Items.Clear();

            CodigoSQL.comando = new MySqlCommand("SELECT nm_eleitor FROM eleitor order by nm_eleitor;", CodigoSQL.conexao);

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

        #region Visualizar
        string codigo;
        private void lbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPesquisar.SelectedItem != null && lbPesquisar.SelectedItem.ToString() != "não há eleitores")
            {
                pnlVisualizar.Visible = true;
                btnEditar.Visible = true;
                btnExcluir.Visible = true;
                btnAdicionar.Width = 188;

                CodigoSQL.comando = new MySqlCommand("SELECT * FROM eleitor where nm_eleitor = '" + lbPesquisar.SelectedItem + "'", CodigoSQL.conexao);

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
                    txtLerCPF.Text = "CPF: " + CodigoSQL.Ler[2].ToString() + " ";
                    codigo = CodigoSQL.Ler[0].ToString();
                }
                CodigoSQL.Ler.Close();

                #region verificar em quais eleições ja votou
                CodigoSQL.comando = new MySqlCommand("Select E.nm_eleicao from eleicao E Join eleicao_urna EU on (EU.cd_eleicao = E.cd_eleicao) Join eleitor_eleicao_urna EEU on (EEU.cd_eleicao = EU.cd_eleicao) Join eleitor P on (P.cd_eleitor = EEU.cd_eleitor) where P.cd_eleitor = "+ codigo, CodigoSQL.conexao);
                if (CodigoSQL.Ler.Read())
                {
                    lblEleicoesAtivas.ForeColor = Color.Green;
                    lblEleicoesAtivas.Text = "°já votou nas seguintes eleições:";
                    lblEleicoesAtivas.Cursor = System.Windows.Forms.Cursors.Hand;
                    lblNomeEleicao.Text = CodigoSQL.Ler[0].ToString();
                }
                else
                {
                    lblEleicoesAtivas.ForeColor = Color.Gray;
                    lblEleicoesAtivas.Text = "ainda não votou";
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

        private void btnImportarExcel_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Para importar dados de uma planilha Excel corretamente, coloque os NOMES na coluna A e os CPFs na coluna B.");

            OpenFileDialog planilha = new OpenFileDialog();
            planilha.Filter = "Planilha Excel 2007 ou superior | *.xlsx";

            if (planilha.ShowDialog() == DialogResult.OK)
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook workbook = app.Workbooks.Open(planilha.FileName);
                Excel.Worksheet worksheet = workbook.Worksheets[1];

                for (int i = 1; i <= worksheet.UsedRange.Rows.Count; i++)
                {
                    string nome = worksheet.Cells[i, 1].Value;
                    string cpf = worksheet.Cells[i, 2].Value;

                    if (nome == "")
                    {
                        continue;
                    }

                    if (cpf.Length < 12 || !cpf.Contains("-"))
                    {
                        continue;
                    }

                    CodigoSQL.comando = new MySqlCommand("INSERT INTO eleitor SELECT max(cd_eleitor) + 1, '"+ nome +"', '"+ cpf +"' from eleitor;",CodigoSQL.conexao);
                }
            
                workbook.Close(false, null, null);

                app.Quit();
            }
        }
        #endregion
    }
}
