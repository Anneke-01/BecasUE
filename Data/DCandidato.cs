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
    }
}
