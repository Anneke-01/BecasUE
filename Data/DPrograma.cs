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

        public DataTable Insertar_Programa(string TituloPrograma, string TipoEspecialidad, int creditos,int diplomados,string duracion)
        {
            DataTable dt = new DataTable("InsertarPrograma");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {    
                   
                    SqlCommand SqlCmd = new SqlCommand("Insertar_Programas", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@TituloPrograma";
                    p.SqlDbType = SqlDbType.NVarChar;
                    p.Size = 70;
                    p.Value = TituloPrograma;
                    SqlCmd.Parameters.Add(p);

                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@TipoEspecialidad";
                    p1.SqlDbType = SqlDbType.NVarChar;
                    p1.Size = 70;
                    p1.Value = TipoEspecialidad;
                    SqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter();
                    p2.ParameterName = "@Creditos";
                    p2.SqlDbType = SqlDbType.Int;
                    p2.Value = creditos;
                    SqlCmd.Parameters.Add(p2);

                    SqlParameter p3 = new SqlParameter();
                    p3.ParameterName = "@Diplomados";
                    p3.SqlDbType = SqlDbType.Int;
                    p3.Value = creditos;
                    SqlCmd.Parameters.Add(p3);

                    SqlParameter p4 = new SqlParameter();
                    p4.ParameterName = "@Duracion";
                    p4.SqlDbType = SqlDbType.NVarChar;
                    p4.Size = 15;
                    p4.Value = duracion;
                    SqlCmd.Parameters.Add(p4);

                    SqlCmd.Connection.Open();

                    SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                    SqlDat.Fill(dt);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);


                }
                return dt;
            }
        }


        public DataTable Leer_Programa()
        {
            DataTable DtResultado = new DataTable("InsertarPrograma");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("Leer_Programas", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
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
