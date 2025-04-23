namespace Projeto_WFA
{
    public partial class form1 : Form
    {
        public object Usuarios { get; private set; }

        public form1()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                if (txtNome.Text != string.Empty && txtSenha.Text != string.Empty)
                {
                    var usuario = Usuarios.Efetuarlogin(txtNome.Text, txtSenha.Text, txtCpf.Text);
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
}