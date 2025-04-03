using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unach.Gastosdiarios.Conexion
{
    public class Conexion
    {
        private readonly string cadenaConexion =
           "server=localhost;" +
            "database=controlgastos;User Id=root;";
        public MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar =
                new MySqlConnection(cadenaConexion);

            try
            {
                conectar.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error");
            }
            return conectar;
        }
    }
}
