﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaBecas.Data
{
    class Conexión
    {
        
        public static string Cn = "Data Source=.;Initial Catalog=BecasEstudioUE;user=AdminBecas;password=Becas2021*";
        private SqlConnection conexion = new SqlConnection(Cn);
        public SqlConnection AbrirConexion()
        {
            if(conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
                
            }
            return conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if(conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }


    }
}
