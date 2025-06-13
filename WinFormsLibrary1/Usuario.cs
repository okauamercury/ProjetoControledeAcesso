using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using System.Runtime.CompilerServices;

namespace WinFormsLibrary1
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string TipoUsuario { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nome, string cpf, int id,string tipo, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Id = id;
            TipoUsuario = tipo;
            Senha = senha;
        }
        public Usuario(string nome, string cpf, string tipo, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipo;
            Senha = senha;
        }


        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
           

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuario where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario.Id = dr.GetInt32(0); 
                usuario.Nome = dr.GetString(1);
                usuario.Cpf = dr.GetString(2); 
                usuario.TipoUsuario = dr.GetString(3);
                usuario.Senha = dr.GetString(4); 
            }
            return usuario;
            

        }
        public static Usuario Logar(string nome, string senha)
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuario where nome = @nome and senha = md5(@senha)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario.Id = dr.GetInt32(0); // campo ID - int
                usuario.Nome = dr.GetString(1);// campo nome - varchar
                usuario.Cpf = dr.GetString(2); // cammpo CPF - varchar
                usuario.TipoUsuario = dr.GetString(3);
                usuario.Senha = dr.GetString(4); // campo senha - bit
            }

            return usuario;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into usuario(Nome, Cpf, TipoUsuario, Senha)" +
                $"values ('{Nome}', '{Cpf}', '{TipoUsuario}', md5('{Senha}'))";
            cmd.ExecuteNonQuery();          
        }
        public bool Atualizar()
      {
        var cmd = Banco.Abrir();
        cmd.CommandType = System.Data.CommandType;
        cmd.CommandText = $"update usuarios set usuario values (nome {Nome}, cpf {Cpf}, tipousuario{Tipousuario}, senha{Senha})";
        var cmd = cmd.ExecuteReader()
        {
            Usuario usuario = new();
            dr.GetInt32(0);
            dr.GetString(1);
            dr.GetString(2);
            dr.GetStrint(3);
            dr.GetString(4);
            

        }
        dr.Close();
        cmd.Connection.Close();
        return usuario; 

        
      }



    }


}
