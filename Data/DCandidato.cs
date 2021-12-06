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
    class DCandidato
    {
        public DataTable Mostrar_Candidatos()
        {
            DataTable DtResultado = new DataTable("Candidato");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("ListarCandidatos", SqlCon);
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

        public DataTable Insertar_HistorialA(int idCandidato,string tituloObtenido, DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable("InsertarHistorialAcademico");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {    
                   
                    SqlCommand SqlCmd = new SqlCommand("InsertarHistorial_Academico", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@IDCandidato";
                    p.SqlDbType = SqlDbType.Int;
                    p.Value = idCandidato;
                    SqlCmd.Parameters.Add(p);

                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@TituloObtenido";
                    p1.SqlDbType = SqlDbType.NVarChar;
                    p1.Size = 75;
                    p1.Value = tituloObtenido;
                    SqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter();
                    p2.ParameterName = "@FechaInicio";
                    p2.SqlDbType = SqlDbType.DateTime;
                    p2.Value = fechaInicio;
                    SqlCmd.Parameters.Add(p2);

                    SqlParameter p3 = new SqlParameter();
                    p3.ParameterName = "@FechaFin";
                    p3.SqlDbType = SqlDbType.DateTime;
                    p3.Value = fechaFin;
                    SqlCmd.Parameters.Add(p3);             

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

        public DataTable Insertar_HistorialLab(string puesto, string entidad,DateTime FechaInicio, DateTime FechaFin, int IdCandidato)
        {
            DataTable dt = new DataTable("InsertarHistorialLaboral");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("InsertarHistorial_Laboral", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@Puesto";
                    p.SqlDbType = SqlDbType.NVarChar;
                    p.Size = 75;
                    p.Value = puesto;
                    SqlCmd.Parameters.Add(p);

                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@Entidad";
                    p1.SqlDbType = SqlDbType.NVarChar;
                    p1.Size = 50;
                    p1.Value = entidad;
                    SqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter();
                    p2.ParameterName = "@FechaInicio";
                    p2.SqlDbType = SqlDbType.DateTime;
                    p2.Value = FechaInicio;
                    SqlCmd.Parameters.Add(p2);

                    SqlParameter p3 = new SqlParameter();
                    p3.ParameterName = "@FechaFin";
                    p3.SqlDbType = SqlDbType.DateTime;
                    p3.Value = FechaFin;
                    SqlCmd.Parameters.Add(p3);

                    SqlParameter p4 = new SqlParameter();
                    p4.ParameterName = "@IDCandidato";
                    p4.SqlDbType = SqlDbType.Int;
                    p4.Value = IdCandidato;
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

        public DataTable Listar_HistorialAC(int idCandidato)
        {
            DataTable DtResultado = new DataTable("HistorialAc");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("ListarHistorialAcademico", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@IDCandidato";
                    p.SqlDbType = SqlDbType.Int;
                    p.Value = idCandidato;
                    SqlCmd.Parameters.Add(p);
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
        public DataTable Listar_HistorialLab(int idCandidato)
        {
            DataTable DtResultado = new DataTable("HistorialLAb");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("ListarHistorialLaboral", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@IDCandidato";
                    p.SqlDbType = SqlDbType.Int;
                    p.Value = idCandidato;
                    SqlCmd.Parameters.Add(p);
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

        public DataTable Editar_HistorialLab(int id,string puesto, string entidad, DateTime FechaInicio, DateTime FechaFin)
        {
            DataTable dt = new DataTable("EditarHistorialLaboral");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("Editar_HistorialLaboral", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter pid = new SqlParameter();
                    pid.ParameterName = "@ID";
                    pid.SqlDbType = SqlDbType.Int;                 
                    pid.Value = id;
                    SqlCmd.Parameters.Add(pid);

                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@Puesto";
                    p.SqlDbType = SqlDbType.NVarChar;
                    p.Size = 75;
                    p.Value = puesto;
                    SqlCmd.Parameters.Add(p);

                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@Entidad";
                    p1.SqlDbType = SqlDbType.NVarChar;
                    p1.Size = 50;
                    p1.Value = entidad;
                    SqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter();
                    p2.ParameterName = "@FechaInicio";
                    p2.SqlDbType = SqlDbType.DateTime;
                    p2.Value = FechaInicio;
                    SqlCmd.Parameters.Add(p2);

                    SqlParameter p3 = new SqlParameter();
                    p3.ParameterName = "@FechaFin";
                    p3.SqlDbType = SqlDbType.DateTime;
                    p3.Value = FechaFin;
                    SqlCmd.Parameters.Add(p3);

                    //SqlParameter p4 = new SqlParameter();
                    //p4.ParameterName = "@IDCandidato";
                    //p4.SqlDbType = SqlDbType.Int;
                    //p4.Value = IdCandidato;
                    //SqlCmd.Parameters.Add(p4);


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


        public DataTable Editar_HistorialA(int id, string tituloObtenido, DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable("EditarHistorialAcademico");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("Editar_HistorialAcademico", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@ID";
                    p.SqlDbType = SqlDbType.Int;
                    p.Value = id;
                    SqlCmd.Parameters.Add(p);

                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@TituloObtenido";
                    p1.SqlDbType = SqlDbType.NVarChar;
                    p1.Size = 75;
                    p1.Value = tituloObtenido;
                    SqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter();
                    p2.ParameterName = "@FechaInicio";
                    p2.SqlDbType = SqlDbType.DateTime;
                    p2.Value = fechaInicio;
                    SqlCmd.Parameters.Add(p2);

                    SqlParameter p3 = new SqlParameter();
                    p3.ParameterName = "@FechaFin";
                    p3.SqlDbType = SqlDbType.DateTime;
                    p3.Value = fechaFin;
                    SqlCmd.Parameters.Add(p3);

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

        public DataTable Eliminar_HistorialLab(int id)
        {
            DataTable dt = new DataTable("EliminarHistorialLaboral");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("Eliminar_HistorialLaboral", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter pid = new SqlParameter();
                    pid.ParameterName = "@ID";
                    pid.SqlDbType = SqlDbType.Int;
                    pid.Value = id;
                    SqlCmd.Parameters.Add(pid);
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
        public DataTable Eliminar_HistorialAC(int id)
        {
            DataTable dt = new DataTable("Eliminar_HistorialAcademico");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("Eliminar_HistorialAcademico", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter pid = new SqlParameter();
                    pid.ParameterName = "@ID";
                    pid.SqlDbType = SqlDbType.Int;
                    pid.Value = id;
                    SqlCmd.Parameters.Add(pid);
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
