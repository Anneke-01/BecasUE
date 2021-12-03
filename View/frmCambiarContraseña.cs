using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBecas.Controller;

namespace SistemaBecas.View
{
    public partial class frmCambiarContraseña : Form
    {
        int IdUser;
        public frmCambiarContraseña(int idUser)
        {
            InitializeComponent();
            IdUser = idUser;
        }

        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text == "" || txtNewPass.Text == "" || txtRepitPass.Text == "")
            {
                MessageBox.Show("Debes rellenar todos los campos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNewPass.Text != txtRepitPass.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CUsuario.Cambiar_Contrasena(IdUser, txtCurrentPass.Text, txtNewPass.Text);
                txtCurrentPass.Text = "";
                txtNewPass.Text = "";
                txtRepitPass.Text = "";
                MessageBox.Show("Se cambió la contraseña.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
