using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAcesso.UI
{
    public class RegistroEntrada
    {
        public int Id { get; set; } 
        public int usuarioId { get; set; }
        public DateTime DataHora { get; set; }
        public string? TipoOperação { get; set; } 

        public void RegistrarEntrada(int usuarioId, DateTime dataHora, string tipoOperacao)
        {
            this.usuarioId = usuarioId;
            DataHora = dataHora;
            TipoOperação = tipoOperacao;
        }
        public void RegistrarSaida(int usuarioId, DateTime dataHora, string tipoOperacao)
        {
            this.usuarioId = usuarioId;
            DataHora = dataHora;
            TipoOperação = tipoOperacao;
        }
        public void RegistrarEntrada()
        {
            var cmd = Banco.Abrir();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO RegistroEntrada (usuarioId, DataHora, TipoOperação) VALUES (@usuarioId, @DataHora, @TipoOperação)";
            cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
            cmd.Parameters.AddWithValue("@DataHora", DataHora);
            cmd.Parameters.AddWithValue("@TipoOperação", TipoOperação);
            cmd.ExecuteNonQuery();
        }
        public void ObterPorId()
        {
            var cmd = Banco.Abrir();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM RegistroEntrada WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0); // campo ID - int
                usuarioId = dr.GetInt32(1); // campo usuarioId - int
                DataHora = dr.GetDateTime(2); // campo DataHora - datetime
                TipoOperação = dr.GetString(3); // campo TipoOperação - varchar
            }
        }
    }
}
