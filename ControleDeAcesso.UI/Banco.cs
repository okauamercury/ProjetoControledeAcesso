using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlConnector;

namespace ControleDeAcesso.UI
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new();
            string strConn = @"server=127.0.0.1;database=controledeacesso;user=root;password=";

            // string strConn = @"server=127.0.0.1;database=tdsqueuedb01;user=root;password=" // meu servidor local
            MySqlConnection cn = new(strConn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;
        }
    }
}
