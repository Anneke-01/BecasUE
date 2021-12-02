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
    class CPrograma
    {
        public static DataTable Insertar_Programa(string TituloPrograma, string TipoEspecialidad, int creditos, int diplomados, string duracion)
        {
            return new DPrograma().Insertar_Programa(TituloPrograma, TipoEspecialidad, creditos, diplomados, duracion);
        }
        public static DataTable Leer_Programa()
        {
            return new DPrograma().Leer_Programa();
        }
    }
}
