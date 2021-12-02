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
using SistemaBecas.Data;

namespace SistemaBecas.View
{
    public partial class frmNuevoUser : Form
    {
        public frmNuevoUser()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != txtRepetirContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsuario.Text == "" || txtContraseña.Text == "" || txtRepetirContra.Text == "" || cmbTipoUser.SelectedItem == null)
            {
                MessageBox.Show("Debes rellenar todos los campos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CUsuario.Insertar_Usuario(txtUsuario.Text, txtContraseña.Text, cmbTipoUser.SelectedItem.ToString());
                txtContraseña.Text = "";
                txtRepetirContra.Text = "";
                txtUsuario.Text = "";
                cmbTipoUser.Text = "";
                MessageBox.Show("Usuario agregado.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void frmNuevoUser_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbTipoUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
