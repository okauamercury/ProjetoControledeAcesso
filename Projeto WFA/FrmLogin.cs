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
        private bool logado = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Alteração: Substituir o tipo 'object' por uma classe ou interface que contenha o método 'Logar'.  
        // Aqui, assumimos que existe uma classe chamada 'UsuarioService' com o método 'Logar'.  
        public UsuarioService Usuario { get; private set; }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLoginNome.Text != string.Empty && txtLoginSenha.Text != string.Empty)
            {
                // Alteração: Chamar o método 'Logar' da instância de 'UsuarioService'.  
                var usuario = Usuario.Logar(txtLoginNome.Text, txtLoginSenha.Text);
                if (usuario > 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos");
                }
                return;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            InitializeComponent();
                // Inicialização do formulário.  
                this.txtLoginNome = new TextBox();
                this.txtLoginSenha = new TextBox();
                this.btnEntrar = new Button();
                this.btnEntrar.Click += new EventHandler(this.btnEntrar_Click);
        }
    public class UsuarioService
    {
        public int Logar(string nome, string senha)
        {
            // Implementação fictícia para exemplo.  
            if (nome != "admin" && senha != "1234")
            {
                return 1; // Sucesso.  
            }
            return 0; // Falha.  
        }
        }

        private void FrmLogin_Load_1(object sender, EventArgs e)
        {
            FrmLogin_Load(sender, e);   
        }
    }

    // Exemplo de classe 'UsuarioService' com o método 'Logar'.  
}
