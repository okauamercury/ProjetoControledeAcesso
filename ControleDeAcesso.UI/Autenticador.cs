using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAcesso.UI
{
    public class Autenticador
    {
        public bool ValidarLogin { get; set; }
        public string? Cpf { get; set; }
        public string? Senha { get; set; }

        public Autenticador(string cpf, string senha)
        {
            Cpf = cpf;
            Senha = senha;
        }
        public bool Autenticar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM Usuarios WHERE Cpf = @Cpf AND Senha = @Senha";
            cmd.Parameters.AddWithValue("@Cpf", Cpf);
            cmd.Parameters.AddWithValue("@Senha", Senha);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ValidarLogin = true;
                return ValidarLogin;
            }
            else
            {
                ValidarLogin = false;
                return ValidarLogin;
            }
        }
    }


}
