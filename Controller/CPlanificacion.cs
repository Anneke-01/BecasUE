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
    class CPlanificacion
    {
        public static DataTable Insertar_Planificacion(int año, DateTime fechaApertura, DateTime fechaCierre, DateTime fechaCreacion, DateTime fechaAprobado, string estado, int idpais, int cantidadU)
        {
            return new DPlanificacion().Insertar_Planificacion(año, fechaApertura, fechaCierre, fechaCreacion, fechaAprobado, estado, idpais, cantidadU);
        }

        public static DataTable Editar_Planificacion(int id, int año, DateTime fechaApertura, DateTime fechaCierre, DateTime fechaCreacion, DateTime fechaAprobado, string estado, int idpais, int cantidadU)
        {
            return new DPlanificacion().Editar_Planificacion(id, año, fechaApertura, fechaCierre, fechaCreacion, fechaAprobado, estado, idpais, cantidadU);
        }
    }
}
