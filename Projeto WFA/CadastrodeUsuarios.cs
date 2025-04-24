namespace Projeto_WFA
{
    public partial class CadastrodeUsuarios : Form
    {
        public string Usuarios { get; set; }
        public int Id { get ;  set; }

        public CadastrodeUsuarios()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(txtNome.Text, txtCpf.Text, txtSenha.Text, txtTipodeUsuário.Text);
            usuario.Id.ToString();
            txtId.Text = usuario.Id.ToString();
            MessageBox.Show($"Usuário {txtNome.Text} cadastrado com sucesso!");
            CadastrodeUsuarios_Load(sender, e);
        }

        private void CadastrodeUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}