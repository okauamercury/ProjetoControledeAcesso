namespace Projeto_WFA
{
    public partial class CadastrodeUsuarios : Form
    {
        public object Usuarios { get; private set; }

        public CadastrodeUsuarios()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Cpf = txtCpf.Text;
            usuario.CadastrodeUsuarios(usuario.Nome, usuario.Senha, usuario.Cpf);

           
                    
            
            
        }
    }
}