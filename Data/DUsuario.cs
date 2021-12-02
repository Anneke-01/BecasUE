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

        private SqlDataReader leerFilas;
        private Conexión cn = new Conexión();
        private SqlCommand cm = new SqlCommand();
        public DataTable Validar_Acceso(string usuario, string contraseña, string rol)
        {
            DataTable DtResultado = new DataTable("Inicio_Sesión");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {   
             
                    SqlCommand SqlCmd = new SqlCommand("Validar_Acceso", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
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

        public DataTable ListarPais()
        {

            DataTable tabla = new DataTable();
            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "Listar_Pais";
            cm.CommandType = CommandType.StoredProcedure;
            leerFilas = cm.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            cn.AbrirConexion();
            return tabla;
        }
        public DataTable ObtenerCandidato(int idUsuario)
        {
            DataTable DtResultado = new DataTable("Candidato");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("Obtener_Candidato", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter ParDato = new SqlParameter();
                    ParDato.ParameterName = "@IDUsuario";
                    ParDato.SqlDbType = SqlDbType.Int;
                    ParDato.Value = idUsuario;
                    SqlCmd.Parameters.Add(ParDato);

                    
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

        public DataTable EditarCandidato(int idUser, string PNombre, String SNombre, String PApellido, String SApellido, String Correo, String NPass, int Pais)
        {
            DataTable DtResultado = new DataTable("Candidato");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("EditarDatos_Candidatos", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter ParDato = new SqlParameter();

                    ParDato.ParameterName = "@IDUsuario";
                    ParDato.SqlDbType = SqlDbType.Int;
                    ParDato.Value = idUser;
                    SqlCmd.Parameters.Add(ParDato);

                    SqlParameter ParDato1 = new SqlParameter();
                    ParDato1.ParameterName = "@PrimerNombre";
                    ParDato1.SqlDbType = SqlDbType.NVarChar;
                    ParDato1.Size = 50;
                    ParDato1.Value = PNombre;
                    SqlCmd.Parameters.Add(ParDato1);

                    SqlParameter ParDato2 = new SqlParameter();
                    ParDato2.ParameterName = "@SegundoNombre";
                    ParDato2.SqlDbType = SqlDbType.NVarChar;
                    ParDato2.Size = 50;
                    ParDato2.Value = SNombre;
                    SqlCmd.Parameters.Add(ParDato2);

                    SqlParameter ParDato3 = new SqlParameter();
                    ParDato3.ParameterName = "@PrimerApellido";
                    ParDato3.SqlDbType = SqlDbType.NVarChar;
                    ParDato3.Size = 50;
                    ParDato3.Value = PApellido;
                    SqlCmd.Parameters.Add(ParDato3);

                    SqlParameter ParDato4 = new SqlParameter();
                    ParDato4.ParameterName = "@SegundoApellido";
                    ParDato4.SqlDbType = SqlDbType.NVarChar;
                    ParDato4.Size = 50;
                    ParDato4.Value = SApellido;
                    SqlCmd.Parameters.Add(ParDato4);

                    SqlParameter ParDato5 = new SqlParameter();
                    ParDato5.ParameterName = "@Correo";
                    ParDato5.SqlDbType = SqlDbType.NVarChar;
                    ParDato5.Size = 50;
                    ParDato5.Value = Correo;
                    SqlCmd.Parameters.Add(ParDato5);

                    SqlParameter ParDato6 = new SqlParameter();
                    ParDato6.ParameterName = "@NoPasaporte";
                    ParDato6.SqlDbType = SqlDbType.NVarChar;
                    ParDato6.Size = 100;
                    ParDato6.Value = NPass;
                    SqlCmd.Parameters.Add(ParDato6);

                    SqlParameter ParDato7 = new SqlParameter();
                    ParDato7.ParameterName = "@IDPais";
                    ParDato7.SqlDbType = SqlDbType.Int;       
                    ParDato7.Value = Pais ;
                    SqlCmd.Parameters.Add(ParDato7);

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

        public DataTable Insertar_Usuario(string usuario, string contraseña,string rol)
        {
            DataTable DtResultado = new DataTable("InsertarUsuario");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("Insertar_Usuario", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter ParDato = new SqlParameter();
                    ParDato.ParameterName = "@Usuario";
                    ParDato.SqlDbType = SqlDbType.NVarChar;
                    ParDato.Size = 30;
                    ParDato.Value = usuario;
                    SqlCmd.Parameters.Add(ParDato);

                    SqlParameter ParDato1 = new SqlParameter();
                    ParDato1.ParameterName = "@Contraseña";
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
