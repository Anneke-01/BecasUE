using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaBecas.Data;
using System.Windows.Forms;

// Recibe parámetros, llama al modelo y el modelo le devuelve o no información, por lo que lo retorna

namespace SistemaBecas.Controller
{
    class CUsuario
    {
        public static DataTable Validar_Acceso(string usuario, string contraseña, string rol)
        {
            return new DUsuario().Validar_Acceso(usuario, contraseña, rol);
        }
        public static DataTable ObtenerCandidato(int idUsuario)
        {
            return new DUsuario().ObtenerCandidato(idUsuario);
        }
        public static DataTable EditarCandidato(int idUser, string PNombre, String SNombre, String PApellido, String SApellido, String Correo, String NPass, int Pais)
        {
            return new DUsuario().EditarCandidato(idUser, PNombre,SNombre,PApellido,SApellido,Correo,NPass,Pais);
        }
        public static DataTable Insertar_Usuario(string usuario, string contraseña, string rol)
        {
            return new DUsuario().Insertar_Usuario(usuario, contraseña, rol);
        }
        public static DataTable Cambiar_Contrasena(int idUsuario, string contraseña, string nuevaContra)
        {
            return new DUsuario().Cambiar_Contrasena(idUsuario, contraseña, nuevaContra);
        }

        public static DataTable Buscar_Usuario(string dato)
        {
            return new DUsuario().Buscar_Usuario(dato);
        }

        public static DataTable CambiarEstado(int idUsuario)
        {
            return new DUsuario().CambiarEstado(idUsuario);
        }
        public static DataTable ListarUsuarios()
        {
            return new DUsuario().ListarUsuarios();
        }

    }
}
