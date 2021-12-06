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
        public DataTable Buscar_Universidad(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarUniversidad");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("Buscar_Universidad", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@Dato";
                    p1.SqlDbType = SqlDbType.NVarChar;
                    p1.Size = 30;
                    p1.Value = dato;
                    SqlCmd.Parameters.Add(p1);
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

        public DataTable Insertar_Universidad(string NombreUni, int IDCiudad, string Telefono, int IDPais, string direccion)
        {
            DataTable dt = new DataTable("InsertarUniversidad");
            using (SqlConnection SqlCon = new SqlConnection(Conexión.Cn))
            {
                try
                {

                    SqlCommand SqlCmd = new SqlCommand("Insertar_Universidad", SqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@NombreUni";
                    p.SqlDbType = SqlDbType.NVarChar;
                    p.Size = 80;
                    p.Value = NombreUni;
                    SqlCmd.Parameters.Add(p);

                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@IDCiudad";
                    p1.SqlDbType = SqlDbType.Int;
                    p1.Value = IDCiudad;
                    SqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter();
                    p2.ParameterName = "@Telefono";
                    p2.SqlDbType = SqlDbType.NVarChar;
                    p2.Size = 15;
                    p2.Value = Telefono;
                    SqlCmd.Parameters.Add(p2);

                    SqlParameter p3 = new SqlParameter();
                    p3.ParameterName = "@IDPais";
                    p3.SqlDbType = SqlDbType.Int;
                    p3.Value = IDPais;
                    SqlCmd.Parameters.Add(p3);

                    SqlParameter p4 = new SqlParameter();
                    p4.ParameterName = "@Direccion";
                    p4.SqlDbType = SqlDbType.NVarChar;
                    p4.Value = direccion;
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
    }
}
