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
    class DOferta
    {
        public DataTable Insertar_Oferta(DateTime fechaInicio, DateTime fechafin, float monto, float financiamiento, int IDPrograma, int IDUniversidad, int IDPlanificacion)
        {
            DataTable dt = new DataTable("");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("Insertar_Oferta", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@FechaInicio";
                    p.SqlDbType = SqlDbType.DateTime;
                    p.Value = fechaInicio;
                    SqlCmd.Parameters.Add(p);

                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@FechaFin";
                    p1.SqlDbType = SqlDbType.DateTime;
                    p1.Value = fechafin;
                    SqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter();
                    p2.ParameterName = "@Monto";
                    p2.SqlDbType = SqlDbType.Float;
                    p2.Value = monto;
                    SqlCmd.Parameters.Add(p2);

                    SqlParameter p3 = new SqlParameter();
                    p3.ParameterName = "@MontoFinanciamiento";
                    p3.SqlDbType = SqlDbType.Float;
                    p3.Value = financiamiento;
                    SqlCmd.Parameters.Add(p3);

                    SqlParameter p4 = new SqlParameter();
                    p4.ParameterName = "@IDPrograma";
                    p4.SqlDbType = SqlDbType.Int;
                    p4.Value = IDPrograma;
                    SqlCmd.Parameters.Add(p4);


                    SqlParameter p5 = new SqlParameter();
                    p5.ParameterName = "@IDUniversidad";
                    p5.SqlDbType = SqlDbType.Int;
                    p5.Value = IDUniversidad;
                    SqlCmd.Parameters.Add(p5);

                    SqlParameter p6 = new SqlParameter();
                    p6.ParameterName = "@IDPlanificacion";
                    p6.SqlDbType = SqlDbType.Int;
                    p6.Value = IDPlanificacion;
                    SqlCmd.Parameters.Add(p6);


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

        public DataTable Listar_Oferta()
        {
            DataTable DtResultado = new DataTable("");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("Leer_Oferta", SqlCon);
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
