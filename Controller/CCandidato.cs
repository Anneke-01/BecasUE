using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaBecas.Data;
using System.Windows.Forms;


namespace SistemaBecas.Controller
{
    class CCandidato
    {
        public static DataTable Mostrar_Candidatos()
        {
            return new DCandidato().Mostrar_Candidatos();
        }
        public static DataTable Insertar_HistorialA(int idCandidato,string tituloObtenido, DateTime fechaInicio, DateTime fechaFin)
        {
            return new DCandidato().Insertar_HistorialA(idCandidato,tituloObtenido,fechaInicio,fechaFin);
        }

        public static DataTable Insertar_HistorialLab(string puesto, string entidad, DateTime FechaInicio, DateTime FechaFin, int IdCandidato)
        {
            return new DCandidato().Insertar_HistorialLab(puesto, entidad, FechaInicio, FechaFin, IdCandidato);
        }
        public static  DataTable Listar_HistorialAC(int idCandidato)
        {
            return new DCandidato().Listar_HistorialAC(idCandidato);
        }
        public static DataTable Listar_HistorialLab(int idCandidato)
        {
            return new DCandidato().Listar_HistorialLab(idCandidato);
        }
        public static DataTable Editar_HistorialLab(int id, string puesto, string entidad, DateTime FechaInicio, DateTime FechaFin)
        {
            return new DCandidato().Editar_HistorialLab(id, puesto, entidad, FechaInicio, FechaFin);
        }

        public static DataTable Editar_HistorialA(int id, string tituloObtenido, DateTime fechaInicio, DateTime fechaFin)
        {
            return new DCandidato().Editar_HistorialA(id, tituloObtenido, fechaInicio, fechaFin);
        }
        public static DataTable Eliminar_HistorialLab(int id)
        {
            return new DCandidato().Eliminar_HistorialLab(id);
        }
    }
}
