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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuarios.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtUsuarios.Text, txtSenha.Text);
                if (usuario.Id > 0)
                {
                    if (usuario.Ativo)

                    {
                        // login aceito
                        // codígo para registrar o usuario logado
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sua conta está inativa. \n" +
                            "Procure um Administrador do Sistema.", $"Olá{usuario.Nome}");
                    }

                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos ou inexitentes!", "Login");
                }
            }
            else
            {
                MessageBox.Show("Os campos email e senha são obrigatórios!");
            }

        }
    }
}
