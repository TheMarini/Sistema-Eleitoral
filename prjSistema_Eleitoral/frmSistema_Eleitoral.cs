using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace prjSistema_Eleitoral
{
    public partial class frmSistema_Eleitoral : Form
    {
        MdiClient mdi = null;
        public frmSistema_Eleitoral()
        {
            #region conectar
            try
            {
                CodigoSQL.conexao = new MySqlConnection("SERVER=localhost;UID=root;PASSWORD=root;DATABASE=Sistema_Eleitoral;");
                CodigoSQL.conexao.Open();
            }
            catch
            {
                if (MessageBox.Show("Não foi possível conectar com o servidor", "ATENÇÃO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Retry)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            #endregion

            frmLogin login = new frmLogin();
            login.ShowDialog();

            InitializeComponent();
            lblNome.Text = CodigoSQL.usuario;

            #region instanciar o MDI
            foreach (Control funcao in this.Controls)
            {
                if (funcao is MdiClient)
                {
                    mdi = funcao as MdiClient;
                    mdi.BackColor = Color.FromName("Control");

                    int style = GetWindowLong(mdi.Handle, GWL_STYLE);
                    int exStyle = GetWindowLong(mdi.Handle, GWL_EXSTYLE);

                    style &= ~WS_BORDER;
                    exStyle &= ~WS_EX_CLIENTEDGE;

                    SetWindowLong(mdi.Handle, GWL_STYLE, style);
                    SetWindowLong(mdi.Handle, GWL_EXSTYLE, exStyle);

                    SetWindowPos(mdi.Handle, IntPtr.Zero, 0, 0, 0, 0,
                        SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
                        SWP_NOOWNERZORDER | SWP_FRAMECHANGED);
                }
            }
            #endregion
        }

        #region Biblioteca MDI
        // Win32 Constants
        private const int GWL_STYLE = -16;
        private const int GWL_EXSTYLE = -20;

        private const int WS_BORDER = 0x00800000;
        private const int WS_EX_CLIENTEDGE = 0x00000200;

        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWP_NOREDRAW = 0x0008;
        private const uint SWP_NOACTIVATE = 0x0010;
        private const uint SWP_FRAMECHANGED = 0x0020;
        private const uint SWP_SHOWWINDOW = 0x0040;
        private const uint SWP_HIDEWINDOW = 0x0080;
        private const uint SWP_NOCOPYBITS = 0x0100;
        private const uint SWP_NOOWNERZORDER = 0x0200;
        private const uint SWP_NOSENDCHANGING = 0x0400;


        // Win32 Functions
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowLong(IntPtr hWnd, int Index);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SetWindowLong(IntPtr hWnd, int Index, int Value);

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter,
            int X, int Y, int cx, int cy, uint uFlags);
        #endregion

        #region frmLoad
        private void frmSistema_Eleitoral_Load(object sender, EventArgs e)
        {
            abrirForm(new frmCandidatos());
        }
        #endregion

        #region Métodos
        public void abrirForm(Form nome)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == nome.GetType())
                {
                    filho.Focus();
                    return;
                }
                else
                {
                    filho.Close();
                }
            }
            nome.MdiParent = this;

            nome.Location = new Point(0, 100);
            nome.Anchor = AnchorStyles.Top;
            nome.Anchor = AnchorStyles.Left;
            nome.Height = this.Height - 100;
            nome.Width = this.Width;
            nome.Show();
        }
        #endregion  

        #region Categorias
        private void btnCandidatos_Click(object sender, EventArgs e)
        {
            mdi.BackColor = btnCandidatos.BackColor;
            abrirForm(new frmCandidatos());
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            mdi.BackColor = btnPartidos.BackColor;
            abrirForm(new frmPartidos());
        }

        private void btnEleitores_Click(object sender, EventArgs e)
        {
            mdi.BackColor = btnEleitores.BackColor;
            abrirForm(new frmEleitores());
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            mdi.BackColor = btnCargos.BackColor;
            abrirForm(new frmCargos());
        }

        private void btnEleicoes_Click(object sender, EventArgs e)
        {
            mdi.BackColor = btnEleicoes.BackColor;
            abrirForm(new frmEleicoes());
        }

        private void btnUrnas_Click(object sender, EventArgs e)
        {
            mdi.BackColor = btnUrnas.BackColor;
            abrirForm(new frmUrnas());
        }
        #endregion

        #region Minimizar & Expandir
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Logout & Sair
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair dessa conta?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void frmSistema_Eleitoral_FormClosed(object sender, FormClosedEventArgs e)
        {
            CodigoSQL.conexao.Close();
        }
        #endregion

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfiguracoes config = new frmConfiguracoes();
            config.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usu = new frmUsuarios();
            usu.ShowDialog();
        }
    }
}
