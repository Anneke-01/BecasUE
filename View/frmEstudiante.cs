using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBecas.Data;
using SistemaBecas.Controller;

namespace SistemaBecas.View
{
    public partial class frmEstudiante : Form
    {
        int IdUser;
        public frmEstudiante(int idUser)
        {
            InitializeComponent();
            IdUser = idUser;
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            ListarPais();
            mostrarDatos();
            AccionGuardar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ListarPais()
        {
            DUsuario dPais = new DUsuario();
            cmbPais.DataSource = dPais.ListarPais();
            cmbPais.DisplayMember = "NombrePais";
            cmbPais.ValueMember = "IDPais";
            
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AccionEditar();
        }
        private void mostrarDatos()
        {
            DataTable respuesta = CUsuario.ObtenerCandidato(IdUser);
            if(respuesta.Rows.Count > 0)
            {
                DataRow dr = respuesta.Rows[0];
                txtPNombre.Text = dr["PrimerNombre"].ToString();
                txtSNombre.Text = dr["SegundoNombre"].ToString();
                txtPApellido.Text = dr["PrimerApellido"].ToString();
                txtSApellido.Text = dr["SegundoApellido"].ToString();
                txtCorreo.Text = dr["Correo"].ToString();
                txtPasaporte.Text = dr["NoPasaporte"].ToString();
                cmbPais.SelectedIndex = cmbPais.FindStringExact(dr["NombrePais"].ToString());
                
                
                

            } 

        }

        private void AccionEditar()
        {
            // Habilitar todos los textbox, deshabilitar el botón editar y habilitar el botón de guardar
            txtPNombre.Enabled = true;
            txtSNombre.Enabled = true;
            txtPApellido.Enabled = true;
            txtSApellido.Enabled = true;
            txtCorreo.Enabled = true;
            txtPasaporte.Enabled = true;
            cmbPais.Enabled = true;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
        }
        private void AccionGuardar()
        {
            // Habilitar todos los textbox, deshabilitar el botón guardar y habilitar el botón de editar
            txtPNombre.Enabled = false;
            txtSNombre.Enabled = false;
            txtPApellido.Enabled = false;
            txtSApellido.Enabled = false;
            txtCorreo.Enabled = false;
            txtPasaporte.Enabled = false;
            cmbPais.Enabled = false;
            btnEditar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AccionGuardar();
            CUsuario.EditarCandidato(IdUser,txtPNombre.Text,txtSNombre.Text,txtPApellido.Text,txtSApellido.Text,txtCorreo.Text,txtPasaporte.Text,int.Parse(cmbPais.SelectedValue.ToString()));
            mostrarDatos();
        }
    }
}
