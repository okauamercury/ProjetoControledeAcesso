using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using System.Runtime.CompilerServices;

namespace ControleDeAcesso.UI
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string Cpf { get; set; }
        public string Tipo { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nome, string cpf, int id,string tipo, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Id = id;
            Tipo = tipo;
            Senha = senha;
        }
        public Usuario(string nome, string cpf, string tipo, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
            Senha = senha;
        }


        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario.Id = dr.GetInt32(0); 
                usuario.Nome = dr.GetString(1);
                usuario.Cpf = dr.GetString(2); 
                usuario.Tipo = dr.GetString(3);
                usuario.Senha = dr.GetString(4); 
            }
            return usuario;
        }
        public static Usuario Logar(string nome, string senha)
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where nome = @nome and senha = md5(@senha)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario.Id = dr.GetInt32(0); // campo ID - int
                usuario.Nome = dr.GetString(1);// campo nome - varchar
                usuario.Cpf = dr.GetString(2); // cammpo CPF - varchar
                usuario.Tipo = dr.GetString(3);
                usuario.Senha = dr.GetString(4); // campo senha - bit
            }

            return usuario;
        }
        public void CadastrarUsuario()
        {
           Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into usuarios(nome, cof, tipo, senha)" +
                $"values ('{Nome}', '{Cpf}', '{Tipo}, 'md5('{Senha}')";
            cmd.ExecuteNonQuery();
           
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into usuarios(nome, cpf, tipo, senha)" +
                $"values ('{Nome}', '{Cpf}', '{Tipo}, 'md5('{Senha}')";
            cmd.ExecuteNonQuery();
        }


    }


}
