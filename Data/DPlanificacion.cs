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
    class DPlanificacion
    {
        public DataTable Insertar_Planificacion(int año, DateTime fechaApertura, DateTime fechaCierre, DateTime fechaCreacion, DateTime fechaAprobado, string estado, int idpais, int cantidadU)
        {
            DataTable dt = new DataTable("InsertarPrograma");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("Insertar_Planificacion", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@Año";
                    p.SqlDbType = SqlDbType.Int;
                    p.Value = año;
                    SqlCmd.Parameters.Add(p);

                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@FechaApertura";
                    p1.SqlDbType = SqlDbType.DateTime;
                    p1.Value = fechaApertura;
                    SqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter();
                    p2.ParameterName = "@FechaCierre";
                    p2.SqlDbType = SqlDbType.DateTime;
                    p2.Value = fechaCierre;
                    SqlCmd.Parameters.Add(p2);

                    SqlParameter p3 = new SqlParameter();
                    p3.ParameterName = "@FechaCreación";
                    p3.SqlDbType = SqlDbType.DateTime;
                    p3.Value = fechaCreacion;
                    SqlCmd.Parameters.Add(p3);

                    SqlParameter p4 = new SqlParameter();
                    p4.ParameterName = "@FechaAprobado";
                    p4.SqlDbType = SqlDbType.DateTime;
                    p4.Value = fechaAprobado;
                    SqlCmd.Parameters.Add(p4);

                    SqlParameter p5 = new SqlParameter();
                    p5.ParameterName = "@Estado";
                    p5.SqlDbType = SqlDbType.NVarChar;
                    p5.Size = 15;
                    p5.Value = estado;
                    SqlCmd.Parameters.Add(p5);

                    SqlParameter p6 = new SqlParameter();
                    p6.ParameterName = "@IDPais";
                    p6.SqlDbType = SqlDbType.Int;
                    p6.Value = idpais;
                    SqlCmd.Parameters.Add(p6);

                    SqlParameter p7 = new SqlParameter();
                    p6.ParameterName = "@CantidadUniversidades";
                    p6.SqlDbType = SqlDbType.Int;
                    p6.Value = cantidadU;
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

        public DataTable Listar_Pais()
        {
            DataTable DtResultado = new DataTable("ListarProducto");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("LISTAR_PRODUCTO", SqlCon);
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
        public DataTable Editar_Planificacion(int id, int año, DateTime fechaApertura, DateTime fechaCierre, DateTime fechaCreacion, DateTime fechaAprobado, string estado, int idpais, int cantidadU)
        {
            DataTable dt = new DataTable("EditarPlanificacion");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("Editar_Planificación", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter pid = new SqlParameter();
                    pid.ParameterName = "@ID";
                    pid.SqlDbType = SqlDbType.Int;
                    pid.Value = año;
                    SqlCmd.Parameters.Add(pid);

                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@Año";
                    p.SqlDbType = SqlDbType.Int;
                    p.Value = año;
                    SqlCmd.Parameters.Add(p);

                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@FechaApertura";
                    p1.SqlDbType = SqlDbType.DateTime;
                    p1.Value = fechaApertura;
                    SqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter();
                    p2.ParameterName = "@FechaCierre";
                    p2.SqlDbType = SqlDbType.DateTime;
                    p2.Value = fechaCierre;
                    SqlCmd.Parameters.Add(p2);

                    SqlParameter p3 = new SqlParameter();
                    p3.ParameterName = "@FechaCreación";
                    p3.SqlDbType = SqlDbType.DateTime;
                    p3.Value = fechaCreacion;
                    SqlCmd.Parameters.Add(p3);

                    SqlParameter p4 = new SqlParameter();
                    p4.ParameterName = "@FechaAprobado";
                    p4.SqlDbType = SqlDbType.DateTime;
                    p4.Value = fechaAprobado;
                    SqlCmd.Parameters.Add(p4);

                    SqlParameter p5 = new SqlParameter();
                    p5.ParameterName = "@Estado";
                    p5.SqlDbType = SqlDbType.NVarChar;
                    p5.Size = 15;
                    p5.Value = estado;
                    SqlCmd.Parameters.Add(p5);

                    SqlParameter p6 = new SqlParameter();
                    p6.ParameterName = "@IDPais";
                    p6.SqlDbType = SqlDbType.Int;
                    p6.Value = idpais;
                    SqlCmd.Parameters.Add(p6);

                    SqlParameter p7 = new SqlParameter();
                    p6.ParameterName = "@CantidadUniversidades";
                    p6.SqlDbType = SqlDbType.Int;
                    p6.Value = cantidadU;
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
    }
}
