using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_WFA
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            btnAcessar.Enabled = false;
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                btnAcessar.Enabled = true;
                this.Hide();
                FrmCadastrarUsuario cadastrarUsuario = new FrmCadastrarUsuario();
                cadastrarUsuario.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
                btnAcessar.Enabled = true;
            }
            return;
        }
    }
}
