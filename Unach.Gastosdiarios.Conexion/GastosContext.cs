using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unach.Gastosdiarios.Conexion
{
    public class GastosContext
    {
        public List<Gasto> ObtenerGastos()
        {
            List<Gasto> _gastos =
                        new List<Gasto>();
            Conexion _conexion =
                new Conexion();
            using (MySqlConnection conn=
                _conexion.ObtenerConexion())
            {
                string query = "Select * from Gastos";
                MySqlCommand cmd = 
                    new MySqlCommand(query, conn);
                MySqlDataReader reader = 
                    cmd.ExecuteReader();
                while (reader.Read())
                {
                    _gastos.Add(new Gasto {Id=int.Parse(reader["Id"].ToString()),
                        Descripcion=reader["Descripcion"].ToString(),
                        Monto=decimal.Parse(reader["Monto"].ToString()),
                        IdCategoria = int.Parse(reader["IdCategoria"].ToString()),
                        FechaRegistro = DateTime.Parse(reader["FechaRegistro"].ToString()),
                        Activo = Convert.ToBoolean(reader["Activo"].ToString())
                    });
                }
                return _gastos;
            }
        }
        
    }
}
