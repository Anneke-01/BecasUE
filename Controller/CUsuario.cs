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
    class CUsuario
    {
        public static DataTable Validar_Acceso(string usuario, string contraseña, string rol)
        {
            return new DUsuario().Validar_Acceso(usuario, contraseña, rol);
        }
        
    }
}
