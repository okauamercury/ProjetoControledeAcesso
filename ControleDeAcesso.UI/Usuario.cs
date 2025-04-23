using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using System.Runtime.CompilerServices;

namespace ControleDeAcesso.UI
{
    public class Usuario
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; } 
        public int Id { get; set; }
        public string? Senha { get; set; }

        public void Usuarios(string nome, string cpf, int id)
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
        public static Usuario EfetuarLogin(string nome, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Entrando ";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario.Id = dr.GetInt32(0); // campo ID - int
                usuario.Nome = dr.GetString(1);// campo nome - varchar
                usuario.Cpf = dr.GetString(2); // cammpo CPF - varchar
                usuario.Senha = dr.GetString(4); // campo senha - bit
            }

            return usuario;
        }
        



    }


}
