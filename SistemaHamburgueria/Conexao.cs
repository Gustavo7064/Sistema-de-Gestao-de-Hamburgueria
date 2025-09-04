using MySql.Data.MySqlClient;
using System;
namespace SistemaHamburgueria
{
    class Conexao
    {
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=BDProjeto;user=root;pwd=12345678");
        public static string msg;

        public MySqlConnection ConnectarBD()
        {
            try
            {
                con.Open();
            }
        }
    }
}
