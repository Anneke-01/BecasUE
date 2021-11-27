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
    class DUsuario
    {
        public DataTable Validar_Acceso(string usuario, string contraseña, string rol)
        {
            DataTable DtResultado = new DataTable("Inicio_Sesión");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {    // Cargando el conexión al servidor
                     //SqlCon.ConnectionString = Conexión.Cn;
                     // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                    SqlCommand SqlCmd = new SqlCommand("Validar_Acceso", SqlCon);
                    //SqlCmd.Connection = SqlCon;
                    //SqlCmd.CommandText = "Validar_Acceso";
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    //   Cargando los parámetros del procedimiento almacenado

                    //SqlParameter[] parametros = new SqlParameter[3];
                    //parametros[0] = new SqlParameter("@Usuario", SqlDbType.NVarChar, 30);
                    //parametros[0].Value = usuario;
                    //parametros[1] = new SqlParameter("@Contrasena", SqlDbType.NVarChar, 30);
                    //parametros[1].Value = contraseña;
                    //parametros[2] = new SqlParameter("@Rol", SqlDbType.NVarChar, 25);
                    //parametros[2].Value = rol;

                    //SqlCmd.Parameters.Add(parametros);


                    SqlParameter ParDato = new SqlParameter();
                    ParDato.ParameterName = "@Usuario";
                    ParDato.SqlDbType = SqlDbType.NVarChar;
                    ParDato.Size = 30;
                    ParDato.Value = usuario;
                    SqlCmd.Parameters.Add(ParDato);

                    SqlParameter ParDato1 = new SqlParameter();
                    ParDato1.ParameterName = "@Contrasena";
                    ParDato1.SqlDbType = SqlDbType.NVarChar;
                    ParDato1.Size = 30;
                    ParDato1.Value = contraseña;
                    SqlCmd.Parameters.Add(ParDato1);

                    SqlParameter ParDato2 = new SqlParameter();
                    ParDato2.ParameterName = "@Rol";
                    ParDato2.SqlDbType = SqlDbType.NVarChar;
                    ParDato2.Size = 25;
                    ParDato2.Value = rol;
                    SqlCmd.Parameters.Add(ParDato2);

                    SqlCmd.Connection.Open();

                    SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                    SqlDat.Fill(DtResultado);

                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.GetBaseException().Message);
                    DtResultado = null;

                }
            }
                
            return DtResultado;

        }
    }
}
