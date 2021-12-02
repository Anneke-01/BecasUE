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

namespace SistemaBecas.View
{
    public partial class frmPrograma : Form
    {
        public frmPrograma()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(txtTituloPrograma.Text == "" || cmbTipoEspecialidad.SelectedItem == null || txtCreditos.Text == "" || txtDiplomados.Text == "" || txtDuracion.Text == "" )
            {
                MessageBox.Show("Debes rellenar todos los campos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void frmPrograma_Load(object sender, EventArgs e)
        {
            ListarEspecialidad();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbTipoEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void ListarEspecialidad()
        {
            DPrograma dp= new DPrograma();
            cmbTipoEspecialidad.DataSource = dp.ListarEspecialidad();
            cmbTipoEspecialidad.DisplayMember = "TipoEspecialidad";
            cmbTipoEspecialidad.ValueMember = "TipoEspecialidad";
        }
    }
}
