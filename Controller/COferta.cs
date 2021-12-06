using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SistemaBecas.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaBecas.Controller
{
    class COferta
    {
        public static DataTable Insertar_Oferta(DateTime fechaInicio, DateTime fechafin, float monto, float financiamiento, int IDPrograma, int IDUniversidad, int IDPlanificacion)
        {
            return new DOferta().Insertar_Oferta(fechaInicio, fechafin, monto, financiamiento, IDPrograma, IDUniversidad, IDPlanificacion);
        }
        public static DataTable Listar_Oferta()
        {
            return new DOferta().Listar_Oferta();
        }
    }
}
