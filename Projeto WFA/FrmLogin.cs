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
    public partial class FrmLogin : Form
    {


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                var usuario = Usuario.Logar(txtNome.Text, txtSenha.Text);
                if (usuario > 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos");
                }

            }
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

    }

}
    