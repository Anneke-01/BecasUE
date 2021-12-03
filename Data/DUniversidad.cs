using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaBecas.Data
{
    class DUniversidad
    {
        private SqlDataReader leerFilas;
        private Conexión cn = new Conexión();
        private SqlCommand cm = new SqlCommand();
        public DataTable ListarUniversidad()
        {

            DataTable tabla = new DataTable();
            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "Listar_Universidades";
            cm.CommandType = CommandType.StoredProcedure;
            leerFilas = cm.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            cn.AbrirConexion();
            return tabla;
        }
    }
}
