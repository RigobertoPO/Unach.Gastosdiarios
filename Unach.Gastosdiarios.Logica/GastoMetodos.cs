using System;
using System.Collections.Generic;
using Unach.Gastosdiarios.Conexion;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unach.Gastosdiarios.Logica
{
    public class GastoMetodos
    {
        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> listaC = new List<Categoria>();
            listaC.Add(new Categoria { Id = 1, Descripcion = "Comida" });
            listaC.Add(new Categoria { Id = 2, Descripcion = "Viajes" });
            listaC.Add(new Categoria { Id = 3, Descripcion = "ropa" });
            return listaC;
        }
        public List<Gasto> ObtenerGastos()
        {
            List<Gasto> listaC = new List<Gasto>();
            GastosContext context = new GastosContext();
            listaC = context.ObtenerGastos();
            return listaC;
        }
    }
}
