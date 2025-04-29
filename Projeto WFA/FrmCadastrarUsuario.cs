using WinFormsLibrary1;


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
            
            
            Usuario usuario = new(txtCadastroNome.Text, txtCadastroCpf.Text, comboBox1.Text, txtCadastroSenha.Text);
            usuario.Inserir();
            
            MessageBox.Show("Usuário cadastrado com sucesso!");

         }

        private void CadastrarUsuario_Load(object sender, EventArgs e)
        {
          
        }

        private void CadastrodeUsuarios_Load(object sender, EventArgs e)
        {
           
        }
    }
}