using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaBecas.Data;
using System.Windows.Forms;

namespace SistemaBecas.Controller
{
    class CUniversidad
    {
        public static DataTable ListarUniversidad()
        {
            return new DUniversidad().ListarUniversidad();
        }
        
        public static DataTable Buscar_Universidad(string dato)
        {
            return new DUniversidad().Buscar_Universidad(dato);
        }
        public static DataTable Insertar_Universidad(string NombreUni, int IDCiudad, string Telefono, int IDPais, string direccion)
        {
            return new DUniversidad().Insertar_Universidad(NombreUni, IDCiudad, Telefono, IDPais, direccion);
        }
    }
}
