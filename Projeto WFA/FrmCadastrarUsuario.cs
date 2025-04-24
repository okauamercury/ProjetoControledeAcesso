namespace Projeto_WFA
{
    public partial class FrmCadastrarUsuario : Form
    {
        public string Usuarios { get; set; }
        public int Id { get ;  set; }

        public FrmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

         public void btnInserir_Click(object sender, EventArgs e)
         {
            Usuario usuario = new(txtNome.Text, txtCpf.Text, txtSenha.Text, txtTipodeUsuário.Text);
            usuario.Inserir();
            
            MessageBox.Show($"Usuário {txtNome.Text} cadastrado com sucesso!");
            CadastrodeUsuarios_Load(sender, e);
         }


        private void CadastrodeUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}