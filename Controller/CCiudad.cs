using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaBecas.Data;


namespace SistemaBecas.Controller
{
    class CCiudad
    {
        public static  DataTable Listar_Ciudad()
        {
            return new DCiudad().Listar_Ciudad();
        }
    }
}
