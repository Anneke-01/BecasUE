using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaBecas.Data;

namespace SistemaBecas.Controller
{
    class CCandidato
    {
        public static DataTable Mostrar_Candidatos()
        {
            return new DCandidato().Mostrar_Candidatos();
        }
    }
}
