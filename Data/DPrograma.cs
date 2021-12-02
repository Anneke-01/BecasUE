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
    class DPrograma
    {
        private int IDPrograma;
        private String TituloPrograma;
        private String TipoEspecialidad;
        private int Creditos;
        private int Diplomados;
        private int Duracion;

        public int IdPrograma { get => IDPrograma; set => IDPrograma = value; }
        public String Tituloprograma { get => TituloPrograma; set => TituloPrograma = value; }
        public String Tipoespecialidad { get => TipoEspecialidad; set => TipoEspecialidad = value; }
        public int creditos { get => Creditos; set => Creditos = value; }
        public int diplomado { get => Diplomados; set => Diplomados = value; }
        public int duracion { get => Duracion; set => Duracion = value; }

        //private SqlDataReader leerFilas;
        private Conexión cn = new Conexión();
        private SqlCommand cm = new SqlCommand();

        public string Insertar(DPrograma Programa)
        {
            string respuesta = "";
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {    
                   
                    SqlCommand SqlCmd = new SqlCommand("Insertar_Programas", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    //   Cargando los parámetros del procedimiento almacenado

                    SqlParameter[] parametros = new SqlParameter[3];
                    //parametros[0] = new SqlParameter("@Usuario", SqlDbType.NVarChar, 30);
                    //parametros[0].Value = usuario;
                    //parametros[1] = new SqlParameter("@Contrasena", SqlDbType.NVarChar, 30);
                    //parametros[1].Value = contraseña;
                    //parametros[2] = new SqlParameter("@Rol", SqlDbType.NVarChar, 25);
                    //parametros[2].Value = rol;

                    //SqlCmd.Parameters.Add(parametros);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);


                }
                return respuesta;
            }
        }


        
    }
}
