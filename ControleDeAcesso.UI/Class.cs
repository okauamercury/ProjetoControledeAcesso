namespace ControleDeAcesso.UI
{
    public class Usuario
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; } 
        public int Id { get; set; }
        public string? Senha { get; set; }

        public void Usuario(string nome, string cpf, int id)
        {
            Nome = Nome;
            Cpf = Cpf;
            Id = Id;
            Senha = Senha;
        }
        public void Login(string nome, string cpf, int id)
        {
            Nome = nome;
            Cpf = cpf;
            Id = id;
            Senha = Senha;
        }
        public void EfetuarLogin(string nome, string senha, string cpf)
        {
            Nome = nome;
            Senha = senha;
            Cpf = cpf;
        }
        public static Usuario ObterPorId()
        {
            Usuario usuario = new Usuario();
            usuario.Nome = "Nome do Usuario";
            usuario.Cpf = "000.000.000-00";
            usuario.Id = 1;
            usuario.Senha = "Senha do Usuario";
            return usuario;
        }
        public void EfetuarLogin()
        {
            // Simulação de login
            if (Nome == "nome" && Senha == "1234")
            {
                // Login bem-sucedido
               MessageBox.Show("Login bem-sucedido!");
            }
            else
            {
                // Falha no login
                MessageBox.Show ("Login falhou. Verifique seu nome de usuário e senha.");
            }
        }
        public 



    }


}
